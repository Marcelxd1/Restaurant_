namespace LP2Soft
{
    partial class frm_Caja_Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Caja_Pedido));
            this.lblPedidos = new System.Windows.Forms.Label();
            this.gbIngresos = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pbCLiente = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.txtDNIRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbnBoleta = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbnFactura = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblMesa = new System.Windows.Forms.Label();
            this.dgvPedidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVuelto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImporte = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbnEfectivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbnTarjeta = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gbIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.Color.White;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(315, 21);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(186, 29);
            this.lblPedidos.TabIndex = 111;
            this.lblPedidos.Text = "Procesar Pago";
            // 
            // gbIngresos
            // 
            this.gbIngresos.Controls.Add(this.pbCLiente);
            this.gbIngresos.Controls.Add(this.btnBuscar);
            this.gbIngresos.Controls.Add(this.txtDNIRUC);
            this.gbIngresos.Controls.Add(this.label2);
            this.gbIngresos.Controls.Add(this.txtNombre);
            this.gbIngresos.Controls.Add(this.label1);
            this.gbIngresos.Controls.Add(this.label7);
            this.gbIngresos.Controls.Add(this.rbnBoleta);
            this.gbIngresos.Controls.Add(this.rbnFactura);
            this.gbIngresos.Controls.Add(this.lblMesa);
            this.gbIngresos.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.gbIngresos.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.gbIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngresos.ForeColor = System.Drawing.Color.Black;
            this.gbIngresos.Location = new System.Drawing.Point(19, 63);
            this.gbIngresos.Name = "gbIngresos";
            this.gbIngresos.ShadowDecoration.Parent = this.gbIngresos;
            this.gbIngresos.Size = new System.Drawing.Size(377, 235);
            this.gbIngresos.TabIndex = 112;
            this.gbIngresos.Text = "Datos del Comprobante";
            this.gbIngresos.TextOffset = new System.Drawing.Point(-4, -10);
            // 
            // pbCLiente
            // 
            this.pbCLiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCLiente.Image = global::LP2Soft.Properties.Resources.User;
            this.pbCLiente.Location = new System.Drawing.Point(11, 109);
            this.pbCLiente.Name = "pbCLiente";
            this.pbCLiente.Size = new System.Drawing.Size(69, 77);
            this.pbCLiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCLiente.TabIndex = 147;
            this.pbCLiente.TabStop = false;
            this.pbCLiente.Click += new System.EventHandler(this.pbCLiente_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.CheckedState.Parent = this.btnBuscar;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.CustomImages.Parent = this.btnBuscar;
            this.btnBuscar.FillColor = System.Drawing.Color.Black;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.HoverState.Parent = this.btnBuscar;
            this.btnBuscar.Location = new System.Drawing.Point(137, 195);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.ShadowDecoration.Parent = this.btnBuscar;
            this.btnBuscar.Size = new System.Drawing.Size(96, 28);
            this.btnBuscar.TabIndex = 146;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNIRUC
            // 
            this.txtDNIRUC.BackColor = System.Drawing.Color.White;
            this.txtDNIRUC.BorderColor = System.Drawing.Color.White;
            this.txtDNIRUC.BorderRadius = 10;
            this.txtDNIRUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNIRUC.DefaultText = "";
            this.txtDNIRUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNIRUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNIRUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIRUC.DisabledState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIRUC.Enabled = false;
            this.txtDNIRUC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDNIRUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIRUC.FocusedState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDNIRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIRUC.HoverState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Location = new System.Drawing.Point(159, 149);
            this.txtDNIRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNIRUC.Multiline = true;
            this.txtDNIRUC.Name = "txtDNIRUC";
            this.txtDNIRUC.PasswordChar = '\0';
            this.txtDNIRUC.PlaceholderText = "";
            this.txtDNIRUC.ReadOnly = true;
            this.txtDNIRUC.SelectedText = "";
            this.txtDNIRUC.ShadowDecoration.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Size = new System.Drawing.Size(204, 37);
            this.txtDNIRUC.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 113;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.Enabled = false;
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(159, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(204, 37);
            this.txtNombre.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "DNI/RUC:";
            // 
            // rbnBoleta
            // 
            this.rbnBoleta.AutoSize = true;
            this.rbnBoleta.BackColor = System.Drawing.Color.White;
            this.rbnBoleta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnBoleta.CheckedState.BorderThickness = 0;
            this.rbnBoleta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnBoleta.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbnBoleta.CheckedState.InnerOffset = -4;
            this.rbnBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnBoleta.Location = new System.Drawing.Point(182, 53);
            this.rbnBoleta.Name = "rbnBoleta";
            this.rbnBoleta.Size = new System.Drawing.Size(68, 22);
            this.rbnBoleta.TabIndex = 70;
            this.rbnBoleta.Text = "Boleta";
            this.rbnBoleta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbnBoleta.UncheckedState.BorderThickness = 2;
            this.rbnBoleta.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbnBoleta.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbnBoleta.UseVisualStyleBackColor = false;
            // 
            // rbnFactura
            // 
            this.rbnFactura.AutoSize = true;
            this.rbnFactura.BackColor = System.Drawing.Color.White;
            this.rbnFactura.Checked = true;
            this.rbnFactura.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnFactura.CheckedState.BorderThickness = 0;
            this.rbnFactura.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnFactura.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbnFactura.CheckedState.InnerOffset = -4;
            this.rbnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFactura.Location = new System.Drawing.Point(60, 53);
            this.rbnFactura.Name = "rbnFactura";
            this.rbnFactura.Size = new System.Drawing.Size(76, 22);
            this.rbnFactura.TabIndex = 69;
            this.rbnFactura.TabStop = true;
            this.rbnFactura.Text = "Factura";
            this.rbnFactura.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbnFactura.UncheckedState.BorderThickness = 2;
            this.rbnFactura.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbnFactura.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbnFactura.UseVisualStyleBackColor = false;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.White;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(6, 30);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(165, 20);
            this.lblMesa.TabIndex = 64;
            this.lblMesa.Text = "Tipo de Documento";
            // 
            // dgvPedidos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedidos.ColumnHeadersHeight = 22;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Importe});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgvPedidos.Location = new System.Drawing.Point(402, 63);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(405, 235);
            this.dgvPedidos.TabIndex = 113;
            this.dgvPedidos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgvPedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvPedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPedidos.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvPedidos.ThemeStyle.ReadOnly = false;
            this.dgvPedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvPedidos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedidos_CellFormatting);
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Producto.FillWeight = 170F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 170;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad.FillWeight = 85F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 85;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.FillWeight = 70F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 70;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Importe.FillWeight = 71.47622F;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Width = 80;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.btnPagar);
            this.guna2GroupBox1.Controls.Add(this.btnImprimir);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.txtVuelto);
            this.guna2GroupBox1.Controls.Add(this.label10);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.txtImporte);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.txtTotal);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.rbnEfectivo);
            this.guna2GroupBox1.Controls.Add(this.rbnTarjeta);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(19, 304);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(788, 187);
            this.guna2GroupBox1.TabIndex = 147;
            this.guna2GroupBox1.Text = "Pago";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(-4, -10);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(647, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 154;
            this.label12.Text = "Pagar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 147;
            this.label5.Text = "Comprobante";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.BackgroundImage = global::LP2Soft.Properties.Resources.pago;
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Location = new System.Drawing.Point(662, 103);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(65, 47);
            this.btnPagar.TabIndex = 153;
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::LP2Soft.Properties.Resources.imprmir;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Location = new System.Drawing.Point(662, 30);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(65, 47);
            this.btnImprimir.TabIndex = 152;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(350, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 151;
            this.label11.Text = "S/.";
            // 
            // txtVuelto
            // 
            this.txtVuelto.BackColor = System.Drawing.Color.White;
            this.txtVuelto.BorderColor = System.Drawing.Color.White;
            this.txtVuelto.BorderRadius = 10;
            this.txtVuelto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVuelto.DefaultText = "";
            this.txtVuelto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVuelto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVuelto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVuelto.DisabledState.Parent = this.txtVuelto;
            this.txtVuelto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVuelto.Enabled = false;
            this.txtVuelto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtVuelto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVuelto.FocusedState.Parent = this.txtVuelto;
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.ForeColor = System.Drawing.Color.Black;
            this.txtVuelto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVuelto.HoverState.Parent = this.txtVuelto;
            this.txtVuelto.Location = new System.Drawing.Point(383, 133);
            this.txtVuelto.Margin = new System.Windows.Forms.Padding(4);
            this.txtVuelto.Multiline = true;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.PasswordChar = '\0';
            this.txtVuelto.PlaceholderText = "";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.SelectedText = "";
            this.txtVuelto.ShadowDecoration.Parent = this.txtVuelto;
            this.txtVuelto.Size = new System.Drawing.Size(202, 39);
            this.txtVuelto.TabIndex = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(350, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 149;
            this.label10.Text = "S/.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 148;
            this.label9.Text = "Vuelto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 147;
            this.label8.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.White;
            this.txtImporte.BorderColor = System.Drawing.Color.White;
            this.txtImporte.BorderRadius = 10;
            this.txtImporte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImporte.DefaultText = "";
            this.txtImporte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImporte.DisabledState.Parent = this.txtImporte;
            this.txtImporte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImporte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImporte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImporte.FocusedState.Parent = this.txtImporte;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.Black;
            this.txtImporte.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImporte.HoverState.Parent = this.txtImporte;
            this.txtImporte.Location = new System.Drawing.Point(383, 62);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Multiline = true;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PasswordChar = '\0';
            this.txtImporte.PlaceholderText = "";
            this.txtImporte.SelectedText = "";
            this.txtImporte.ShadowDecoration.Parent = this.txtImporte;
            this.txtImporte.Size = new System.Drawing.Size(202, 37);
            this.txtImporte.TabIndex = 145;
            this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "S/.";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.White;
            this.txtTotal.BorderRadius = 10;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(60, 62);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(190, 37);
            this.txtTotal.TabIndex = 144;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tipo de Pago";
            // 
            // rbnEfectivo
            // 
            this.rbnEfectivo.AutoSize = true;
            this.rbnEfectivo.BackColor = System.Drawing.Color.White;
            this.rbnEfectivo.Checked = true;
            this.rbnEfectivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnEfectivo.CheckedState.BorderThickness = 0;
            this.rbnEfectivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnEfectivo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbnEfectivo.CheckedState.InnerOffset = -4;
            this.rbnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEfectivo.Location = new System.Drawing.Point(60, 133);
            this.rbnEfectivo.Name = "rbnEfectivo";
            this.rbnEfectivo.Size = new System.Drawing.Size(79, 22);
            this.rbnEfectivo.TabIndex = 70;
            this.rbnEfectivo.TabStop = true;
            this.rbnEfectivo.Text = "Efectivo";
            this.rbnEfectivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbnEfectivo.UncheckedState.BorderThickness = 2;
            this.rbnEfectivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbnEfectivo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbnEfectivo.UseVisualStyleBackColor = false;
            // 
            // rbnTarjeta
            // 
            this.rbnTarjeta.AutoSize = true;
            this.rbnTarjeta.BackColor = System.Drawing.Color.White;
            this.rbnTarjeta.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnTarjeta.CheckedState.BorderThickness = 0;
            this.rbnTarjeta.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbnTarjeta.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbnTarjeta.CheckedState.InnerOffset = -4;
            this.rbnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTarjeta.Location = new System.Drawing.Point(182, 133);
            this.rbnTarjeta.Name = "rbnTarjeta";
            this.rbnTarjeta.Size = new System.Drawing.Size(71, 22);
            this.rbnTarjeta.TabIndex = 69;
            this.rbnTarjeta.Text = "Tarjeta";
            this.rbnTarjeta.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbnTarjeta.UncheckedState.BorderThickness = 2;
            this.rbnTarjeta.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbnTarjeta.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbnTarjeta.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Total a Pagar";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(826, 515);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 110;
            this.guna2PictureBox3.TabStop = false;
            // 
            // frm_Caja_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 514);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.gbIngresos);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Caja_Pedido";
            this.Text = "frm_Caja_Pedido";
            this.gbIngresos.ResumeLayout(false);
            this.gbIngresos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedidos;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2GroupBox gbIngresos;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rbnBoleta;
        private Guna.UI2.WinForms.Guna2RadioButton rbnFactura;
        private Guna.UI2.WinForms.Guna2TextBox txtDNIRUC;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtImporte;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rbnEfectivo;
        private Guna.UI2.WinForms.Guna2RadioButton rbnTarjeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtVuelto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pbCLiente;
    }
}