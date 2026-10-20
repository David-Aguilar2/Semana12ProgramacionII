using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Forms;
using System.Globalization;

namespace MiTiendaPOS
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //Método generico para abrir cualquier formulario como ventana modal
        private void AbrirFormulario<T>() where T : Form, new()
        {
            try
            {
                using var form = new T();
                form.StartPosition = FormStartPosition.CenterParent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var region = new CultureInfo("es-SV");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", region);
            lblEstado.Text = "Listo!";
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategorias form = new FrmCategorias();
            form.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e) => AbrirFormulario<FrmVentas>();

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.ShowDialog();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos form = new FrmProductos();
            form.ShowDialog();
        }
    }
}
