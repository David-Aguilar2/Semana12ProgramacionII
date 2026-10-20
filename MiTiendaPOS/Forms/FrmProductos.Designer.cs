namespace MiTiendaPOS.Forms
{
    partial class FrmProductos
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
            grpDatos = new GroupBox();
            btnReactivar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            chkActivo = new CheckBox();
            nudStock = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            cboCategoria = new ComboBox();
            txtNombre = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblModo = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            cboFiltroCategoria = new ComboBox();
            lblFIltro = new Label();
            dgvProductos = new DataGridView();
            lblResumen = new Label();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnReactivar);
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Controls.Add(btnGuardar);
            grpDatos.Controls.Add(btnNuevo);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(nudStock);
            grpDatos.Controls.Add(nudPrecio);
            grpDatos.Controls.Add(cboCategoria);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(lblCategoria);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(lblModo);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(342, 373);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del producto";
            // 
            // btnReactivar
            // 
            btnReactivar.Location = new Point(124, 341);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(94, 29);
            btnReactivar.TabIndex = 13;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(224, 306);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(124, 306);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(20, 306);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(115, 244);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(115, 201);
            nudStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(150, 27);
            nudStock.TabIndex = 8;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudPrecio.Location = new Point(115, 159);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 7;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(115, 111);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(206, 28);
            cboCategoria.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 67);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(206, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(9, 204);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(9, 159);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(9, 116);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(9, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModo.Location = new Point(9, 34);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(120, 20);
            lblModo.TabIndex = 0;
            lblModo.Text = "Producto nuevo";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(425, 41);
            txtBuscar.MaxLength = 100;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(164, 27);
            txtBuscar.TabIndex = 14;
            txtBuscar.TextChanged += Filtros_Changed;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(359, 42);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(61, 20);
            lblBuscar.TabIndex = 13;
            lblBuscar.Text = "Buscar:";
            // 
            // cboFiltroCategoria
            // 
            cboFiltroCategoria.FormattingEnabled = true;
            cboFiltroCategoria.Location = new Point(694, 42);
            cboFiltroCategoria.Name = "cboFiltroCategoria";
            cboFiltroCategoria.Size = new Size(196, 28);
            cboFiltroCategoria.TabIndex = 14;
            cboFiltroCategoria.SelectedIndexChanged += Filtros_Changed;
            // 
            // lblFIltro
            // 
            lblFIltro.AutoSize = true;
            lblFIltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFIltro.Location = new Point(605, 46);
            lblFIltro.Name = "lblFIltro";
            lblFIltro.Size = new Size(80, 20);
            lblFIltro.TabIndex = 13;
            lblFIltro.Text = "Categoría:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(369, 82);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(874, 428);
            dgvProductos.TabIndex = 15;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(369, 524);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(82, 20);
            lblResumen.TabIndex = 16;
            lblResumen.Text = "Resumen: -";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 553);
            Controls.Add(lblResumen);
            Controls.Add(dgvProductos);
            Controls.Add(cboFiltroCategoria);
            Controls.Add(lblFIltro);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Productos";
            Load += FrmProductos_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatos;
        private Label lblModo;
        private Label lblNombre;
        private Label lblCategoria;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtNombre;
        private NumericUpDown nudStock;
        private NumericUpDown nudPrecio;
        private ComboBox cboCategoria;
        private CheckBox chkActivo;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private ComboBox cboFiltroCategoria;
        private Label lblFIltro;
        private DataGridView dgvProductos;
        private Label lblResumen;
        private Button btnReactivar;
    }
}