namespace MiTiendaPOS.Forms
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpEncabezado = new GroupBox();
            lblVenta = new Label();
            cboUsuario = new ComboBox();
            lblUsuario = new Label();
            cboCliente = new ComboBox();
            lblCliente = new Label();
            grpDetalle = new GroupBox();
            lblTotal = new Label();
            btnQuitar = new Button();
            dgvDetalle = new DataGridView();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            lblCantidad = new Label();
            cboProducto = new ComboBox();
            lblProducto = new Label();
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 12);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(572, 145);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la venta";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(11, 96);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(136, 20);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Editando venta #3";
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(365, 39);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(197, 28);
            cboUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(292, 42);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(80, 39);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(193, 28);
            cboCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(11, 41);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Location = new Point(12, 163);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(572, 377);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de productos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(265, 328);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(143, 31);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:  $0.00";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(11, 333);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(138, 29);
            btnQuitar.TabIndex = 11;
            btnQuitar.Text = "Quitar linea";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(6, 88);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(556, 232);
            dgvDetalle.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(424, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(340, 43);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(55, 27);
            nudCantidad.TabIndex = 8;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(289, 45);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(45, 20);
            lblCantidad.TabIndex = 7;
            lblCantidad.Text = "Cant.:";
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(85, 40);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(193, 28);
            cboProducto.TabIndex = 6;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(7, 44);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Producto:";
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(590, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(400, 589);
            grpHistorial.TabIndex = 2;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(6, 26);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(388, 523);
            dgvVentas.TabIndex = 11;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(18, 564);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(138, 29);
            btnNueva.TabIndex = 12;
            btnNueva.Text = "Nueva Venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.MenuHighlight;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(208, 564);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar Venta";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(393, 564);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 613);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(grpHistorial);
            Controls.Add(grpDetalle);
            Controls.Add(grpEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de ventas";
            Load += FrmVentas_Load;
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private GroupBox grpDetalle;
        private GroupBox grpHistorial;
        private Label lblCliente;
        private ComboBox cboCliente;
        private ComboBox cboUsuario;
        private Label lblUsuario;
        private Label lblVenta;
        private ComboBox cboProducto;
        private Label lblProducto;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private DataGridView dgvVentas;
        private Button btnQuitar;
        private Label lblTotal;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}