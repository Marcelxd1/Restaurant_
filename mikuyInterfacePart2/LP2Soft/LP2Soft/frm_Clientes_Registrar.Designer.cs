namespace LP2Soft
{
    partial class frm_Clientes_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes_Registrar));
            this.txtRazon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistrarCliente = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rbPersona = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbEmpresa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApPaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRazon = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRUC = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApMaterno = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApPaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRUC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApMaterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRazon
            // 
            this.txtRazon.BorderColor = System.Drawing.Color.White;
            this.txtRazon.BorderRadius = 10;
            this.txtRazon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRazon.DefaultText = "";
            this.txtRazon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRazon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRazon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazon.DisabledState.Parent = this.txtRazon;
            this.txtRazon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRazon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtRazon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazon.FocusedState.Parent = this.txtRazon;
            this.txtRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazon.ForeColor = System.Drawing.Color.Black;
            this.txtRazon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRazon.HoverState.Parent = this.txtRazon;
            this.txtRazon.Location = new System.Drawing.Point(444, 176);
            this.txtRazon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.PasswordChar = '\0';
            this.txtRazon.PlaceholderText = "";
            this.txtRazon.SelectedText = "";
            this.txtRazon.ShadowDecoration.Parent = this.txtRazon;
            this.txtRazon.Size = new System.Drawing.Size(294, 30);
            this.txtRazon.TabIndex = 67;
            this.txtRazon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazon_KeyPress);
            this.txtRazon.Validating += new System.ComponentModel.CancelEventHandler(this.txtRazon_Validating);
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.BackColor = System.Drawing.SystemColors.Window;
            this.lblRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazon.Location = new System.Drawing.Point(440, 148);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(117, 24);
            this.lblRazon.TabIndex = 66;
            this.lblRazon.Text = "Razón social";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BorderColor = System.Drawing.Color.White;
            this.txtApellidoMaterno.BorderRadius = 10;
            this.txtApellidoMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoMaterno.DefaultText = "";
            this.txtApellidoMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.DisabledState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtApellidoMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.FocusedState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.HoverState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(54, 300);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.PasswordChar = '\0';
            this.txtApellidoMaterno.PlaceholderText = "";
            this.txtApellidoMaterno.SelectedText = "";
            this.txtApellidoMaterno.ShadowDecoration.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(294, 30);
            this.txtApellidoMaterno.TabIndex = 65;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoMaterno_KeyPress);
            this.txtApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoMaterno_Validating);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.Location = new System.Drawing.Point(50, 272);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(153, 24);
            this.lblApellidoMaterno.TabIndex = 64;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BorderColor = System.Drawing.Color.White;
            this.txtApellidoPaterno.BorderRadius = 10;
            this.txtApellidoPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPaterno.DefaultText = "";
            this.txtApellidoPaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoPaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoPaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.DisabledState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtApellidoPaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.FocusedState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoPaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.HoverState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(54, 238);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.PasswordChar = '\0';
            this.txtApellidoPaterno.PlaceholderText = "";
            this.txtApellidoPaterno.SelectedText = "";
            this.txtApellidoPaterno.ShadowDecoration.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(294, 30);
            this.txtApellidoPaterno.TabIndex = 63;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoPaterno_KeyPress);
            this.txtApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoPaterno_Validating);
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.Location = new System.Drawing.Point(50, 210);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(149, 24);
            this.lblApellidoPaterno.TabIndex = 62;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(54, 176);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(294, 30);
            this.txtNombre.TabIndex = 61;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtRuc
            // 
            this.txtRuc.BorderColor = System.Drawing.Color.White;
            this.txtRuc.BorderRadius = 10;
            this.txtRuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRuc.DefaultText = "";
            this.txtRuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRuc.DisabledState.Parent = this.txtRuc;
            this.txtRuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtRuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRuc.FocusedState.Parent = this.txtRuc;
            this.txtRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.ForeColor = System.Drawing.Color.Black;
            this.txtRuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRuc.HoverState.Parent = this.txtRuc;
            this.txtRuc.Location = new System.Drawing.Point(444, 238);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.PasswordChar = '\0';
            this.txtRuc.PlaceholderText = "";
            this.txtRuc.SelectedText = "";
            this.txtRuc.ShadowDecoration.Parent = this.txtRuc;
            this.txtRuc.Size = new System.Drawing.Size(178, 30);
            this.txtRuc.TabIndex = 60;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            this.txtRuc.Validating += new System.ComponentModel.CancelEventHandler(this.txtRuc_Validating);
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.BackColor = System.Drawing.SystemColors.Window;
            this.lblRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuc.Location = new System.Drawing.Point(440, 210);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(49, 24);
            this.lblRuc.TabIndex = 59;
            this.lblRuc.Text = "RUC";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(50, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 58;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRegistrarCliente
            // 
            this.lblRegistrarCliente.AutoSize = true;
            this.lblRegistrarCliente.BackColor = System.Drawing.Color.White;
            this.lblRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarCliente.Location = new System.Drawing.Point(301, 33);
            this.lblRegistrarCliente.Name = "lblRegistrarCliente";
            this.lblRegistrarCliente.Size = new System.Drawing.Size(210, 29);
            this.lblRegistrarCliente.TabIndex = 68;
            this.lblRegistrarCliente.Text = "Registrar Cliente";
            this.lblRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.Window;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(50, 88);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 24);
            this.lblTipo.TabIndex = 69;
            this.lblTipo.Text = "Tipo";
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.BackColor = System.Drawing.Color.White;
            this.rbPersona.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPersona.CheckedState.BorderThickness = 0;
            this.rbPersona.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPersona.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPersona.CheckedState.InnerOffset = -4;
            this.rbPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersona.Location = new System.Drawing.Point(139, 92);
            this.rbPersona.Name = "rbPersona";
            this.rbPersona.Size = new System.Drawing.Size(83, 20);
            this.rbPersona.TabIndex = 70;
            this.rbPersona.TabStop = true;
            this.rbPersona.Text = "Persona";
            this.rbPersona.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPersona.UncheckedState.BorderThickness = 2;
            this.rbPersona.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPersona.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPersona.UseVisualStyleBackColor = false;
            this.rbPersona.CheckedChanged += new System.EventHandler(this.rbPersona_CheckedChanged);
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.BackColor = System.Drawing.Color.White;
            this.rbEmpresa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbEmpresa.CheckedState.BorderThickness = 0;
            this.rbEmpresa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbEmpresa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbEmpresa.CheckedState.InnerOffset = -4;
            this.rbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.Location = new System.Drawing.Point(241, 92);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(87, 20);
            this.rbEmpresa.TabIndex = 71;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbEmpresa.UncheckedState.BorderThickness = 2;
            this.rbEmpresa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbEmpresa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbEmpresa.UseVisualStyleBackColor = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.SystemColors.Window;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(50, 334);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 24);
            this.lblDNI.TabIndex = 72;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderColor = System.Drawing.Color.White;
            this.txtDNI.BorderRadius = 10;
            this.txtDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNI.DefaultText = "";
            this.txtDNI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNI.DisabledState.Parent = this.txtDNI;
            this.txtDNI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNI.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtDNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNI.FocusedState.Parent = this.txtDNI;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.Black;
            this.txtDNI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNI.HoverState.Parent = this.txtDNI;
            this.txtDNI.Location = new System.Drawing.Point(54, 364);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PasswordChar = '\0';
            this.txtDNI.PlaceholderText = "";
            this.txtDNI.SelectedText = "";
            this.txtDNI.ShadowDecoration.Parent = this.txtDNI;
            this.txtDNI.Size = new System.Drawing.Size(178, 30);
            this.txtDNI.TabIndex = 73;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txtDNI_Validating);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderRadius = 10;
            this.btnRegistrar.CheckedState.Parent = this.btnRegistrar;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.CustomImages.Parent = this.btnRegistrar;
            this.btnRegistrar.FillColor = System.Drawing.Color.Black;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.HoverState.Parent = this.btnRegistrar;
            this.btnRegistrar.Location = new System.Drawing.Point(444, 364);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.ShadowDecoration.Parent = this.btnRegistrar;
            this.btnRegistrar.Size = new System.Drawing.Size(121, 28);
            this.btnRegistrar.TabIndex = 74;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(617, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(121, 28);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApPaterno
            // 
            this.epApPaterno.ContainerControl = this;
            // 
            // epRazon
            // 
            this.epRazon.ContainerControl = this;
            // 
            // epRUC
            // 
            this.epRUC.ContainerControl = this;
            // 
            // epApMaterno
            // 
            this.epApMaterno.ContainerControl = this;
            // 
            // epDNI
            // 
            this.epDNI.ContainerControl = this;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(776, 426);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 42;
            this.guna2PictureBox3.TabStop = false;
            // 
            // frm_Clientes_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.rbPersona);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblRegistrarCliente);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.lblRazon);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.lblApellidoMaterno);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.lblApellidoPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Clientes_Registrar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Registrar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApPaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRazon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRUC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApMaterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtRazon;
        private System.Windows.Forms.Label lblRazon;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtRuc;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistrarCliente;
        private System.Windows.Forms.Label lblTipo;
        private Guna.UI2.WinForms.Guna2RadioButton rbPersona;
        private Guna.UI2.WinForms.Guna2RadioButton rbEmpresa;
        private System.Windows.Forms.Label lblDNI;
        private Guna.UI2.WinForms.Guna2TextBox txtDNI;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApPaterno;
        private System.Windows.Forms.ErrorProvider epRazon;
        private System.Windows.Forms.ErrorProvider epRUC;
        private System.Windows.Forms.ErrorProvider epApMaterno;
        private System.Windows.Forms.ErrorProvider epDNI;
    }
}