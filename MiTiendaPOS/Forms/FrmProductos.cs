using MiTiendaPOS.Models;
using MiTiendaPOS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTiendaPOS.Forms
{
    public partial class FrmProductos : Form
    {
        private readonly ProductoService _servicio = new();
        private int _idSeleccionado = 0;   // 0 = producto nuevo
        private bool _cargando = true;     // evita filtrar mientras se llenan los combos

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            _cargando = false;
            CargarProductos();
            Limpiar();
        }

        // ComboBox de la FK: el usuario ve Nombre, el programa recibe Id
        private void CargarCategorias()
        {
            var categorias = _servicio.ListarCategorias();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "Id";
            cboCategoria.DataSource = categorias;

            // Filtro: la misma lista con la opción "(Todas)" (Id = 0) al inicio
            var filtro = new List<Categoria>
            {
                new Categoria { Id = 0, Nombre = "(Todas)" }
            };
            filtro.AddRange(categorias);
            cboFiltroCategoria.DisplayMember = "Nombre";
            cboFiltroCategoria.ValueMember = "Id";
            cboFiltroCategoria.DataSource = filtro;
        }

        private void CargarProductos()
        {
            if (_cargando) return;
            int categoriaId = cboFiltroCategoria.SelectedValue is int id ? id : 0;

            // Lista ya filtrada
            var lista = _servicio.Listar(txtBuscar.Text.Trim(), categoriaId)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    Categoria = p.Categoria.Nombre,
                    Precio = p.PrecioUnitario,
                    p.Stock,
                    Estado = p.Activo ? "Activo" : "Inactivo"
                })
                .ToList();

            dgvProductos.DataSource = lista;
            if (dgvProductos.Columns["Precio"] != null)
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";

            // Resumen respetando los filtros activos
            int cantidad = lista.Count;
            decimal valorInventario = lista.Sum(p => p.Precio * p.Stock);

            lblResumen.Text = $"Productos listados: {cantidad}   |   " +
                              $"Valor del inventario: {valorInventario:N2}";
        }

        private void Limpiar()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            chkActivo.Checked = true;
            if (cboCategoria.Items.Count > 0) cboCategoria.SelectedIndex = 0;
            lblModo.Text = "Producto nuevo";
            btnEliminar.Enabled = false;
            btnReactivar.Visible = false;
            btnReactivar.Enabled = false;
            dgvProductos.ClearSelection();
            txtNombre.Focus();
        }

        // Carga el producto seleccionado en los controles para editarlo
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;                  // clic en el encabezado
            int id = (int)dgvProductos.Rows[e.RowIndex].Cells["Id"].Value;
            Producto? p = _servicio.ObtenerPorId(id);
            if (p == null) return;

            _idSeleccionado = p.Id;
            txtNombre.Text = p.Nombre;
            cboCategoria.SelectedValue = p.CategoriaId;  // selecciona el combo por la FK
            nudPrecio.Value = p.PrecioUnitario;
            nudStock.Value = p.Stock;
            chkActivo.Checked = p.Activo;
            lblModo.Text = $"Editando producto #{p.Id}";
            btnEliminar.Enabled = true;

            btnReactivar.Visible = !p.Activo;
            btnReactivar.Enabled = !p.Activo;
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Nos aseguramos de tener la columna Stock (puede no existir si la grilla está vacía)
            if (dgvProductos.Columns["Stock"] == null) return;

            var valorStock = dgvProductos.Rows[e.RowIndex].Cells["Stock"].Value;
            if (valorStock == null) return;

            if (int.TryParse(valorStock.ToString(), out int stock) && stock < 5)
            {
                // Pintar toda la fila de rojo
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.Font =
                    new Font(dgvProductos.DefaultCellStyle.Font, FontStyle.Bold);
            }
            else
            {
                // Restablecer estilo
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                dgvProductos.Rows[e.RowIndex].DefaultCellStyle.Font =
                    new Font(dgvProductos.DefaultCellStyle.Font, FontStyle.Regular);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedValue is not int categoriaId)
            {
                MessageBox.Show("Primero registre al menos una categoría.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var producto = new Producto
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                CategoriaId = categoriaId,               // FK tomada del ComboBox
                PrecioUnitario = nudPrecio.Value,
                Stock = (int)nudStock.Value,
                Activo = chkActivo.Checked
            };

            try
            {
                bool esNuevo = _idSeleccionado == 0;
                _servicio.Guardar(producto);
                MessageBox.Show(esNuevo ? "Producto registrado." : "Producto actualizado.",
                    "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;

            var respuesta = MessageBox.Show($"¿Eliminar el producto #{_idSeleccionado}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                string mensaje = _servicio.Eliminar(_idSeleccionado);  // físico o lógico
                MessageBox.Show(mensaje, "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e) => Limpiar();

        // Compartido por txtBuscar y cboFiltroCategoria: filtra mientras se escribe
        private void Filtros_Changed(object sender, EventArgs e) => CargarProductos();

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;

            var producto = _servicio.ObtenerPorId(_idSeleccionado);
            if (producto == null)
            {
                MessageBox.Show("El producto ya no existe.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            producto.Activo = true;

            try
            {
                _servicio.Guardar(producto);
                MessageBox.Show($"Producto #{producto.Id} reactivado.", "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo reactivar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
