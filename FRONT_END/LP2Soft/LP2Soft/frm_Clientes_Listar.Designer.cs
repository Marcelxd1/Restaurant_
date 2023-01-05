namespace LP2Soft
{
    partial class frm_Clientes_Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes_Listar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvListarClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNuvo = new Guna.UI2.WinForms.Guna2Button();
            this.rbPersona = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbEmpresa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cbSector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbActividad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderRadius = 10;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.FillColor = System.Drawing.Color.Transparent;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Image = global::LP2Soft.Properties.Resources.edit;
            this.btnModificar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificar.ImageSize = new System.Drawing.Size(28, 25);
            this.btnModificar.Location = new System.Drawing.Point(843, 303);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.PressedColor = System.Drawing.Color.Red;
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(149, 45);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::LP2Soft.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.ImageSize = new System.Drawing.Size(28, 25);
            this.btnEliminar.Location = new System.Drawing.Point(843, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedColor = System.Drawing.Color.Red;
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(149, 45);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.AllowUserToAddRows = false;
            this.dgvListarClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarClientes.ColumnHeadersHeight = 24;
            this.dgvListarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.RUC,
            this.DNIRUC,
            this.Column4,
            this.VIP,
            this.Asociado,
            this.Sector,
            this.Actividad,
            this.Razon});
            this.dgvListarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarClientes.EnableHeadersVisualStyles = false;
            this.dgvListarClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.Location = new System.Drawing.Point(25, 252);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.ReadOnly = true;
            this.dgvListarClientes.RowHeadersVisible = false;
            this.dgvListarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarClientes.Size = new System.Drawing.Size(800, 305);
            this.dgvListarClientes.TabIndex = 40;
            this.dgvListarClientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListarClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvListarClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvListarClientes.ThemeStyle.ReadOnly = true;
            this.dgvListarClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListarClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListarClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListarClientes_CellFormatting);
            // 
            // Nro
            // 
            this.Nro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nro.FillWeight = 58.58155F;
            this.Nro.HeaderText = "ID";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 50;
            // 
            // RUC
            // 
            this.RUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.ReadOnly = true;
            this.RUC.Width = 150;
            // 
            // DNIRUC
            // 
            this.DNIRUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DNIRUC.FillWeight = 69.81967F;
            this.DNIRUC.HeaderText = "DNI";
            this.DNIRUC.MinimumWidth = 100;
            this.DNIRUC.Name = "DNIRUC";
            this.DNIRUC.ReadOnly = true;
            this.DNIRUC.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.FillWeight = 380F;
            this.Column4.HeaderText = "Nombre";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 240;
            // 
            // VIP
            // 
            this.VIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VIP.HeaderText = "VIP";
            this.VIP.Name = "VIP";
            this.VIP.ReadOnly = true;
            // 
            // Asociado
            // 
            this.Asociado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Asociado.HeaderText = "Asociado";
            this.Asociado.MinimumWidth = 100;
            this.Asociado.Name = "Asociado";
            this.Asociado.ReadOnly = true;
            // 
            // Sector
            // 
            this.Sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Width = 140;
            // 
            // Actividad
            // 
            this.Actividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            this.Actividad.Width = 150;
            // 
            // Razon
            // 
            this.Razon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Razon.HeaderText = "Razón Social";
            this.Razon.Name = "Razon";
            this.Razon.ReadOnly = true;
            this.Razon.Width = 170;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.MediumPurple;
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.Parent = this.txtBuscar;
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBuscar.FocusedState.Parent = this.txtBuscar;
            this.txtBuscar.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBuscar.HoverState.Parent = this.txtBuscar;
            this.txtBuscar.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.Location = new System.Drawing.Point(25, 108);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.txtBuscar.PlaceholderText = "Ingrese nombre";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(432, 36);
            this.txtBuscar.TabIndex = 39;
            this.txtBuscar.TextOffset = new System.Drawing.Point(0, -2);
            this.txtBuscar.IconRightClick += new System.EventHandler(this.txtBuscar_IconRightClick);
            this.txtBuscar.DoubleClick += new System.EventHandler(this.txtBuscar_DoubleClick);
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.Color.White;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblDatosUsuario.Location = new System.Drawing.Point(24, 23);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(270, 31);
            this.lblDatosUsuario.TabIndex = 37;
            this.lblDatosUsuario.Text = "Gestión de Clientes";
            this.lblDatosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(-7, -1);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(1021, 588);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 41;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // btnNuvo
            // 
            this.btnNuvo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuvo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuvo.BackgroundImage")));
            this.btnNuvo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuvo.BorderRadius = 10;
            this.btnNuvo.CheckedState.Parent = this.btnNuvo;
            this.btnNuvo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuvo.CustomImages.Parent = this.btnNuvo;
            this.btnNuvo.FillColor = System.Drawing.Color.Transparent;
            this.btnNuvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuvo.ForeColor = System.Drawing.Color.White;
            this.btnNuvo.HoverState.Parent = this.btnNuvo;
            this.btnNuvo.Image = global::LP2Soft.Properties.Resources._new;
            this.btnNuvo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNuvo.ImageSize = new System.Drawing.Size(28, 25);
            this.btnNuvo.Location = new System.Drawing.Point(843, 252);
            this.btnNuvo.Name = "btnNuvo";
            this.btnNuvo.PressedColor = System.Drawing.Color.Red;
            this.btnNuvo.ShadowDecoration.Parent = this.btnNuvo;
            this.btnNuvo.Size = new System.Drawing.Size(149, 45);
            this.btnNuvo.TabIndex = 44;
            this.btnNuvo.Text = "Nuevo";
            this.btnNuvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNuvo.Click += new System.EventHandler(this.btnNuvo_Click);
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.BackColor = System.Drawing.Color.White;
            this.rbPersona.Checked = true;
            this.rbPersona.CheckedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.rbPersona.CheckedState.BorderThickness = 0;
            this.rbPersona.CheckedState.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.rbPersona.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPersona.CheckedState.InnerOffset = -4;
            this.rbPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersona.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rbPersona.Location = new System.Drawing.Point(497, 108);
            this.rbPersona.Name = "rbPersona";
            this.rbPersona.Size = new System.Drawing.Size(93, 24);
            this.rbPersona.TabIndex = 45;
            this.rbPersona.TabStop = true;
            this.rbPersona.Text = "Persona";
            this.rbPersona.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPersona.UncheckedState.BorderThickness = 2;
            this.rbPersona.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPersona.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPersona.UseVisualStyleBackColor = false;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.BackColor = System.Drawing.Color.White;
            this.rbEmpresa.CheckedState.BorderColor = System.Drawing.Color.MediumPurple;
            this.rbEmpresa.CheckedState.BorderThickness = 0;
            this.rbEmpresa.CheckedState.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.rbEmpresa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbEmpresa.CheckedState.InnerOffset = -4;
            this.rbEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.rbEmpresa.Location = new System.Drawing.Point(616, 108);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(98, 24);
            this.rbEmpresa.TabIndex = 46;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbEmpresa.UncheckedState.BorderThickness = 2;
            this.rbEmpresa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbEmpresa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbEmpresa.UseVisualStyleBackColor = false;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // cbSector
            // 
            this.cbSector.BackColor = System.Drawing.Color.White;
            this.cbSector.BorderColor = System.Drawing.Color.MediumPurple;
            this.cbSector.BorderRadius = 10;
            this.cbSector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSector.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbSector.FocusedColor = System.Drawing.Color.Empty;
            this.cbSector.FocusedState.Parent = this.cbSector;
            this.cbSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSector.ForeColor = System.Drawing.Color.Black;
            this.cbSector.FormattingEnabled = true;
            this.cbSector.HoverState.Parent = this.cbSector;
            this.cbSector.ItemHeight = 30;
            this.cbSector.ItemsAppearance.Parent = this.cbSector;
            this.cbSector.Location = new System.Drawing.Point(100, 158);
            this.cbSector.Name = "cbSector";
            this.cbSector.ShadowDecoration.Parent = this.cbSector;
            this.cbSector.Size = new System.Drawing.Size(181, 36);
            this.cbSector.TabIndex = 47;
            this.cbSector.SelectedIndexChanged += new System.EventHandler(this.cbSector_SelectedIndexChanged);
            // 
            // cbActividad
            // 
            this.cbActividad.BackColor = System.Drawing.Color.White;
            this.cbActividad.BorderColor = System.Drawing.Color.MediumPurple;
            this.cbActividad.BorderRadius = 10;
            this.cbActividad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbActividad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActividad.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbActividad.FocusedColor = System.Drawing.Color.Empty;
            this.cbActividad.FocusedState.Parent = this.cbActividad;
            this.cbActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActividad.ForeColor = System.Drawing.Color.Black;
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.HoverState.Parent = this.cbActividad;
            this.cbActividad.ItemHeight = 30;
            this.cbActividad.ItemsAppearance.Parent = this.cbActividad;
            this.cbActividad.Location = new System.Drawing.Point(392, 158);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.ShadowDecoration.Parent = this.cbActividad;
            this.cbActividad.Size = new System.Drawing.Size(198, 36);
            this.cbActividad.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sector:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(299, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Actividad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.BackgroundImage")));
            this.btnBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCliente.BorderRadius = 10;
            this.btnBuscaCliente.CheckedState.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCliente.CustomImages.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCliente.HoverState.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Image = global::LP2Soft.Properties.Resources.lupa1;
            this.btnBuscaCliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.ImageSize = new System.Drawing.Size(22, 22);
            this.btnBuscaCliente.Location = new System.Drawing.Point(710, 158);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.PressedColor = System.Drawing.Color.Red;
            this.btnBuscaCliente.ShadowDecoration.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Size = new System.Drawing.Size(115, 39);
            this.btnBuscaCliente.TabIndex = 155;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.Click += new System.EventHandler(this.txtBuscar_IconRightClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 157;
            this.label4.Text = "Búsqueda de clientes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 158;
            this.label3.Text = "Lista de clientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Clientes_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.rbPersona);
            this.Controls.Add(this.btnNuvo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListarClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Clientes_Listar";
            this.Text = "Listar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListarClientes;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblDatosUsuario;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnNuvo;
        private Guna.UI2.WinForms.Guna2RadioButton rbPersona;
        private Guna.UI2.WinForms.Guna2RadioButton rbEmpresa;
        private Guna.UI2.WinForms.Guna2ComboBox cbSector;
        private Guna.UI2.WinForms.Guna2ComboBox cbActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnBuscaCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
    }
}