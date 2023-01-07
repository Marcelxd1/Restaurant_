namespace LP2Soft
{
    partial class frm_Gestion_Usuario_Listar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Gestion_Usuario_Listar));
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.dgvListarUsuarios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApPaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSueldo = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBoxBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBuscaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApPaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApMaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.Color.White;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosUsuario.Location = new System.Drawing.Point(24, 23);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(279, 31);
            this.lblDatosUsuario.TabIndex = 30;
            this.lblDatosUsuario.Text = "Gestión de Usuarios";
            this.lblDatosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListarUsuarios
            // 
            this.dgvListarUsuarios.AllowUserToAddRows = false;
            this.dgvListarUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListarUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarUsuarios.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvListarUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarUsuarios.ColumnHeadersHeight = 24;
            this.dgvListarUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Salario,
            this.Correo});
            this.dgvListarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarUsuarios.EnableHeadersVisualStyles = false;
            this.dgvListarUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarUsuarios.Location = new System.Drawing.Point(30, 203);
            this.dgvListarUsuarios.Name = "dgvListarUsuarios";
            this.dgvListarUsuarios.ReadOnly = true;
            this.dgvListarUsuarios.RowHeadersVisible = false;
            this.dgvListarUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarUsuarios.Size = new System.Drawing.Size(788, 354);
            this.dgvListarUsuarios.TabIndex = 33;
            this.dgvListarUsuarios.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvListarUsuarios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarUsuarios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListarUsuarios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListarUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListarUsuarios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListarUsuarios.ThemeStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dgvListarUsuarios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarUsuarios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvListarUsuarios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListarUsuarios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListarUsuarios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListarUsuarios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListarUsuarios.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvListarUsuarios.ThemeStyle.ReadOnly = true;
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarUsuarios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListarUsuarios_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 10.0247F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 13.75396F;
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 380.7106F;
            this.Column3.HeaderText = "Nombre Completo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.FillWeight = 22.17966F;
            this.Column5.HeaderText = "Rol";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.FillWeight = 73.33102F;
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 105;
            // 
            // Salario
            // 
            this.Salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Width = 90;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 270;
            // 
            // epRol
            // 
            this.epRol.ContainerControl = this;
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApPaterno
            // 
            this.epApPaterno.ContainerControl = this;
            // 
            // epApMaterno
            // 
            this.epApMaterno.ContainerControl = this;
            // 
            // epTelefono
            // 
            this.epTelefono.ContainerControl = this;
            // 
            // epSueldo
            // 
            this.epSueldo.ContainerControl = this;
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.Color.Transparent;
            this.cboRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cboRol.BorderRadius = 10;
            this.cboRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cboRol.FocusedColor = System.Drawing.Color.Empty;
            this.cboRol.FocusedState.Parent = this.cboRol;
            this.cboRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.ForeColor = System.Drawing.Color.Black;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRol.HoverState.Parent = this.cboRol;
            this.cboRol.ItemHeight = 30;
            this.cboRol.ItemsAppearance.Parent = this.cboRol;
            this.cboRol.Location = new System.Drawing.Point(459, 114);
            this.cboRol.Name = "cboRol";
            this.cboRol.ShadowDecoration.Parent = this.cboRol;
            this.cboRol.Size = new System.Drawing.Size(225, 36);
            this.cboRol.TabIndex = 39;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.BorderColor = System.Drawing.Color.Transparent;
            this.btnModify.BorderRadius = 10;
            this.btnModify.CheckedState.Parent = this.btnModify;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.CustomImages.Parent = this.btnModify;
            this.btnModify.FillColor = System.Drawing.Color.Transparent;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.HoverState.Parent = this.btnModify;
            this.btnModify.Image = global::LP2Soft.Properties.Resources.edit;
            this.btnModify.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModify.ImageSize = new System.Drawing.Size(28, 25);
            this.btnModify.Location = new System.Drawing.Point(836, 253);
            this.btnModify.Name = "btnModify";
            this.btnModify.PressedColor = System.Drawing.Color.Red;
            this.btnModify.ShadowDecoration.Parent = this.btnModify;
            this.btnModify.Size = new System.Drawing.Size(149, 45);
            this.btnModify.TabIndex = 38;
            this.btnModify.Text = "Modificar";
            this.btnModify.TextOffset = new System.Drawing.Point(10, 0);
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderRadius = 10;
            this.btnNuevo.CheckedState.Parent = this.btnNuevo;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.CustomImages.Parent = this.btnNuevo;
            this.btnNuevo.FillColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.HoverState.Parent = this.btnNuevo;
            this.btnNuevo.Image = global::LP2Soft.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNuevo.ImageSize = new System.Drawing.Size(28, 25);
            this.btnNuevo.Location = new System.Drawing.Point(836, 202);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.PressedColor = System.Drawing.Color.Red;
            this.btnNuevo.ShadowDecoration.Parent = this.btnNuevo;
            this.btnNuevo.Size = new System.Drawing.Size(149, 45);
            this.btnNuevo.TabIndex = 37;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextOffset = new System.Drawing.Point(10, 0);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::LP2Soft.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.ImageSize = new System.Drawing.Size(28, 25);
            this.btnEliminar.Location = new System.Drawing.Point(836, 304);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedColor = System.Drawing.Color.Red;
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(149, 45);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextOffset = new System.Drawing.Point(10, 0);
            this.btnEliminar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxBuscar.BorderRadius = 10;
            this.txtBoxBuscar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtBoxBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxBuscar.DefaultText = "Ingrese nombre";
            this.txtBoxBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxBuscar.DisabledState.Parent = this.txtBoxBuscar;
            this.txtBoxBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxBuscar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxBuscar.FocusedState.Parent = this.txtBoxBuscar;
            this.txtBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBoxBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxBuscar.HoverState.Parent = this.txtBoxBuscar;
            this.txtBoxBuscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxBuscar.Location = new System.Drawing.Point(30, 114);
            this.txtBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.PasswordChar = '\0';
            this.txtBoxBuscar.PlaceholderText = "";
            this.txtBoxBuscar.SelectedText = "";
            this.txtBoxBuscar.SelectionStart = 14;
            this.txtBoxBuscar.ShadowDecoration.Parent = this.txtBoxBuscar;
            this.txtBoxBuscar.Size = new System.Drawing.Size(375, 35);
            this.txtBoxBuscar.TabIndex = 32;
            this.txtBoxBuscar.TextOffset = new System.Drawing.Point(0, -2);
            this.txtBoxBuscar.IconRightClick += new System.EventHandler(this.txtBoxBuscar_IconRightClick);
            this.txtBoxBuscar.DoubleClick += new System.EventHandler(this.txtBoxBuscar_DoubleClick);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(1, -1);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(1009, 585);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 34;
            this.guna2PictureBox3.TabStop = false;
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
            this.btnBuscaCliente.Location = new System.Drawing.Point(703, 114);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.PressedColor = System.Drawing.Color.Red;
            this.btnBuscaCliente.ShadowDecoration.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Size = new System.Drawing.Size(115, 39);
            this.btnBuscaCliente.TabIndex = 156;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.Click += new System.EventHandler(this.txtBoxBuscar_IconRightClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 160;
            this.label3.Text = "Lista de usuarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 159;
            this.label4.Text = "Búsqueda de usuarios";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(412, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 161;
            this.label2.Text = "Rol:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Gestion_Usuario_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvListarUsuarios);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Gestion_Usuario_Listar";
            this.Text = "Lista de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApPaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApMaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxBuscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListarUsuarios;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private System.Windows.Forms.ErrorProvider epRol;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApPaterno;
        private System.Windows.Forms.ErrorProvider epApMaterno;
        private System.Windows.Forms.ErrorProvider epTelefono;
        private System.Windows.Forms.ErrorProvider epSueldo;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2ComboBox cboRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private Guna.UI2.WinForms.Guna2Button btnBuscaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}