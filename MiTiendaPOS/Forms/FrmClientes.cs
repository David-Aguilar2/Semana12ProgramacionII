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
    public partial class FrmClientes : Form
    {

        private readonly ClienteService _servicio = new();
        private int _idSeleccionado = 0;//para registro nuevo

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            LimpiarFormulario();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = _servicio.Listar(txtBuscar.Text)
                .Select(c => new { c.Id, c.Nombre })
                .ToList();
        }
        private void LimpiarFormulario()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            btnEliminar.Enabled = false;
            dgvClientes.ClearSelection();
            txtNombre.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvClientes.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells["Id"].Value);
            Cliente? cliente = _servicio.ObtenerPorId(id);
            if (cliente == null) return;

            _idSeleccionado = cliente.Id;
            txtNombre.Text = cliente.Nombre;
            txtCorreo.Text = cliente.Correo;
            txtTelefono.Text = cliente.Telefono;
            btnEliminar.Enabled = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var cliente = new Cliente
                {
                    Id = _idSeleccionado,
                    Nombre = txtNombre.Text,
                    Correo = txtCorreo.Text,
                    Telefono = txtTelefono.Text
                };
                if (_idSeleccionado == 0)
                    _servicio.Crear(cliente);

                else
                    _servicio.Actualizar(cliente);
                MessageBox.Show("Cliente guardado con éxito.", "MiTiendaPOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "No se pudo guardar",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarClientes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;
            var respuesta = MessageBox.Show($"¿Estás seguro de eliminar el cliente \"{txtNombre.Text}\"?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;
            try
            {
                _servicio.Eliminar(_idSeleccionado);
                MessageBox.Show("Cliente eliminado con éxito.", "MiTiendaPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarClientes();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
