namespace MiTiendaPOS
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            mnuPrincipal = new MenuStrip();
            mnuSalir = new ToolStripMenuItem();
            mnuCatalogos = new ToolStripMenuItem();
            mnuCategorias = new ToolStripMenuItem();
            mnuProductos = new ToolStripMenuItem();
            mnuClientes = new ToolStripMenuItem();
            mnuOperaciones = new ToolStripMenuItem();
            mnuVentas = new ToolStripMenuItem();
            stsEstado = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            lblFecha = new ToolStripStatusLabel();
            pnlMenuLateral = new Panel();
            btnVentas = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnCategoria = new Button();
            label2 = new Label();
            label1 = new Label();
            picLogo = new PictureBox();
            mnuPrincipal.SuspendLayout();
            stsEstado.SuspendLayout();
            pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.ImageScalingSize = new Size(20, 20);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuSalir, mnuCatalogos, mnuOperaciones });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(1182, 28);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(52, 24);
            mnuSalir.Text = "&Salir";
            // 
            // mnuCatalogos
            // 
            mnuCatalogos.DropDownItems.AddRange(new ToolStripItem[] { mnuCategorias, mnuProductos, mnuClientes });
            mnuCatalogos.Name = "mnuCatalogos";
            mnuCatalogos.Size = new Size(90, 24);
            mnuCatalogos.Text = "Catálogos";
            // 
            // mnuCategorias
            // 
            mnuCategorias.Name = "mnuCategorias";
            mnuCategorias.Size = new Size(163, 26);
            mnuCategorias.Text = "Categorías";
            // 
            // mnuProductos
            // 
            mnuProductos.Name = "mnuProductos";
            mnuProductos.Size = new Size(163, 26);
            mnuProductos.Text = "Productos";
            // 
            // mnuClientes
            // 
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(163, 26);
            mnuClientes.Text = "Clientes";
            // 
            // mnuOperaciones
            // 
            mnuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { mnuVentas });
            mnuOperaciones.Name = "mnuOperaciones";
            mnuOperaciones.Size = new Size(106, 24);
            mnuOperaciones.Text = "Operaciones";
            // 
            // mnuVentas
            // 
            mnuVentas.Name = "mnuVentas";
            mnuVentas.Size = new Size(135, 26);
            mnuVentas.Text = "Ventas";
            // 
            // stsEstado
            // 
            stsEstado.ImageScalingSize = new Size(20, 20);
            stsEstado.Items.AddRange(new ToolStripItem[] { lblEstado, lblFecha });
            stsEstado.Location = new Point(0, 647);
            stsEstado.Name = "stsEstado";
            stsEstado.Size = new Size(1182, 26);
            stsEstado.TabIndex = 1;
            stsEstado.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(1110, 20);
            lblEstado.Spring = true;
            lblEstado.Text = "Listo!";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 20);
            lblFecha.Text = "(Fecha)";
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.FromArgb(0, 0, 64);
            pnlMenuLateral.Controls.Add(btnVentas);
            pnlMenuLateral.Controls.Add(btnClientes);
            pnlMenuLateral.Controls.Add(btnProductos);
            pnlMenuLateral.Controls.Add(btnCategoria);
            pnlMenuLateral.Controls.Add(label2);
            pnlMenuLateral.Controls.Add(label1);
            pnlMenuLateral.Location = new Point(0, 27);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(246, 621);
            pnlMenuLateral.TabIndex = 2;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(0, 0, 64);
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(3, 381);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(240, 84);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(0, 0, 64);
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(3, 291);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(240, 84);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(0, 0, 64);
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(3, 204);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(240, 84);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.FromArgb(0, 0, 64);
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.FlatAppearance.BorderColor = Color.MidnightBlue;
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategoria.ForeColor = Color.White;
            btnCategoria.Location = new Point(3, 117);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(240, 84);
            btnCategoria.TabIndex = 2;
            btnCategoria.Text = "Categorías";
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(247, 40);
            label2.TabIndex = 1;
            label2.Text = "Menú Principal";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 50);
            label1.TabIndex = 0;
            label1.Text = "MiTiendaPOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(249, 27);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(933, 621);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(picLogo);
            Controls.Add(pnlMenuLateral);
            Controls.Add(stsEstado);
            Controls.Add(mnuPrincipal);
            MainMenuStrip = mnuPrincipal;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(1000, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiTiendaPOS - Sistema de Punto de Venta";
            Load += Form1_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            stsEstado.ResumeLayout(false);
            stsEstado.PerformLayout();
            pnlMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private StatusStrip stsEstado;
        private Panel pnlMenuLateral;
        private PictureBox picLogo;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem mnuCatalogos;
        private ToolStripMenuItem mnuCategorias;
        private ToolStripMenuItem mnuProductos;
        private ToolStripMenuItem mnuClientes;
        private ToolStripMenuItem mnuOperaciones;
        private ToolStripMenuItem mnuVentas;
        private Label label1;
        private Label label2;
        private Button btnCategoria;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnClientes;
        private ToolStripStatusLabel lblEstado;
        private ToolStripStatusLabel lblFecha;
    }
}
