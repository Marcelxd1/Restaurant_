namespace LP2Soft
{
    partial class frm_Gestion_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Gestion_Usuario));
            this.cmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPasswordConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblConfirmarPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtApellidoMaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDNI = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtSueldo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCabecera = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApePater = new System.Windows.Forms.ErrorProvider(this.components);
            this.epApeMater = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSueldo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApePater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApeMater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.Transparent;
            this.cmbRol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbRol.BorderRadius = 10;
            this.cmbRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRol.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRol.FocusedState.Parent = this.cmbRol;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.ForeColor = System.Drawing.Color.Black;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRol.HoverState.Parent = this.cmbRol;
            this.cmbRol.ItemHeight = 30;
            this.cmbRol.ItemsAppearance.Parent = this.cmbRol;
            this.cmbRol.Location = new System.Drawing.Point(188, 268);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.ShadowDecoration.BorderRadius = 0;
            this.cmbRol.ShadowDecoration.Parent = this.cmbRol;
            this.cmbRol.Size = new System.Drawing.Size(203, 36);
            this.cmbRol.TabIndex = 7;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BorderRadius = 10;
            this.txtPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordConfirm.DefaultText = "";
            this.txtPasswordConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordConfirm.DisabledState.Parent = this.txtPasswordConfirm;
            this.txtPasswordConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordConfirm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPasswordConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordConfirm.FocusedState.Parent = this.txtPasswordConfirm;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordConfirm.HoverState.Parent = this.txtPasswordConfirm;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(642, 76);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '\0';
            this.txtPasswordConfirm.PlaceholderText = "";
            this.txtPasswordConfirm.SelectedText = "";
            this.txtPasswordConfirm.ShadowDecoration.Parent = this.txtPasswordConfirm;
            this.txtPasswordConfirm.Size = new System.Drawing.Size(203, 30);
            this.txtPasswordConfirm.TabIndex = 12;
            // 
            // lblConfirmarPassword
            // 
            this.lblConfirmarPassword.AutoSize = true;
            this.lblConfirmarPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lblConfirmarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarPassword.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmarPassword.Location = new System.Drawing.Point(443, 78);
            this.lblConfirmarPassword.Name = "lblConfirmarPassword";
            this.lblConfirmarPassword.Size = new System.Drawing.Size(192, 24);
            this.lblConfirmarPassword.TabIndex = 53;
            this.lblConfirmarPassword.Text = "Confirmar Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(188, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(203, 30);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.Window;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(72, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 24);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(81, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 50;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(188, 38);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(203, 30);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.TextOffset = new System.Drawing.Point(0, -1);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.BorderRadius = 10;
            this.txtApellidoMaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoMaterno.DefaultText = "";
            this.txtApellidoMaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoMaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoMaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.DisabledState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoMaterno.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoMaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.FocusedState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoMaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoMaterno.HoverState.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(188, 113);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.PasswordChar = '\0';
            this.txtApellidoMaterno.PlaceholderText = "";
            this.txtApellidoMaterno.SelectedText = "";
            this.txtApellidoMaterno.ShadowDecoration.Parent = this.txtApellidoMaterno;
            this.txtApellidoMaterno.Size = new System.Drawing.Size(324, 30);
            this.txtApellidoMaterno.TabIndex = 3;
            this.txtApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoMaterno_Validating);
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidoMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaterno.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(25, 116);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(153, 24);
            this.lblApellidoMaterno.TabIndex = 46;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.BorderRadius = 10;
            this.txtApellidoPaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPaterno.DefaultText = "";
            this.txtApellidoPaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoPaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoPaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.DisabledState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPaterno.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoPaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.FocusedState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoPaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPaterno.HoverState.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(188, 75);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.PasswordChar = '\0';
            this.txtApellidoPaterno.PlaceholderText = "";
            this.txtApellidoPaterno.SelectedText = "";
            this.txtApellidoPaterno.ShadowDecoration.Parent = this.txtApellidoPaterno;
            this.txtApellidoPaterno.Size = new System.Drawing.Size(324, 30);
            this.txtApellidoPaterno.TabIndex = 2;
            this.txtApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoPaterno_Validating);
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.BackColor = System.Drawing.SystemColors.Window;
            this.lblApellidoPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaterno.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(32, 78);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(149, 24);
            this.lblApellidoPaterno.TabIndex = 44;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.SystemColors.Window;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Black;
            this.lblRol.Location = new System.Drawing.Point(143, 274);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(38, 24);
            this.lblRol.TabIndex = 43;
            this.lblRol.Text = "Rol";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(188, 37);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(324, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtDNI
            // 
            this.txtDNI.BorderRadius = 10;
            this.txtDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNI.DefaultText = "";
            this.txtDNI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNI.DisabledState.Parent = this.txtDNI;
            this.txtDNI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNI.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNI.FocusedState.Parent = this.txtDNI;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.Black;
            this.txtDNI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNI.HoverState.Parent = this.txtDNI;
            this.txtDNI.Location = new System.Drawing.Point(188, 151);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PasswordChar = '\0';
            this.txtDNI.PlaceholderText = "";
            this.txtDNI.SelectedText = "";
            this.txtDNI.ShadowDecoration.Parent = this.txtDNI;
            this.txtDNI.Size = new System.Drawing.Size(245, 30);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txtDNI_Validating);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.SystemColors.Window;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Black;
            this.lblDNI.Location = new System.Drawing.Point(137, 154);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 24);
            this.lblDNI.TabIndex = 40;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(99, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderRadius = 10;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.Parent = this.txtTelefono;
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedState.Parent = this.txtTelefono;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.HoverState.Parent = this.txtTelefono;
            this.txtTelefono.Location = new System.Drawing.Point(188, 227);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(203, 30);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefono_Validating);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(93, 230);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(85, 24);
            this.lblTelefono.TabIndex = 58;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtSueldo
            // 
            this.txtSueldo.BorderRadius = 10;
            this.txtSueldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSueldo.DefaultText = "";
            this.txtSueldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSueldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSueldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSueldo.DisabledState.Parent = this.txtSueldo;
            this.txtSueldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSueldo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSueldo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSueldo.FocusedState.Parent = this.txtSueldo;
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.ForeColor = System.Drawing.Color.Black;
            this.txtSueldo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSueldo.HoverState.Parent = this.txtSueldo;
            this.txtSueldo.Location = new System.Drawing.Point(188, 189);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PasswordChar = '\0';
            this.txtSueldo.PlaceholderText = "";
            this.txtSueldo.SelectedText = "";
            this.txtSueldo.ShadowDecoration.Parent = this.txtSueldo;
            this.txtSueldo.Size = new System.Drawing.Size(120, 30);
            this.txtSueldo.TabIndex = 5;
            this.txtSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldo_KeyPress);
            this.txtSueldo.Validating += new System.ComponentModel.CancelEventHandler(this.txtSueldo_Validating);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.BackColor = System.Drawing.SystemColors.Window;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.ForeColor = System.Drawing.Color.Black;
            this.lblSueldo.Location = new System.Drawing.Point(108, 192);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(70, 24);
            this.lblSueldo.TabIndex = 60;
            this.lblSueldo.Text = "Sueldo";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(567, 40);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(68, 24);
            this.lblCorreo.TabIndex = 64;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderRadius = 10;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.Parent = this.txtCorreo;
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedState.Parent = this.txtCorreo;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.HoverState.Parent = this.txtCorreo;
            this.txtCorreo.Location = new System.Drawing.Point(642, 38);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(268, 30);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.TextOffset = new System.Drawing.Point(0, -3);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = false;
            this.lblCabecera.BackColor = System.Drawing.Color.Transparent;
            this.lblCabecera.BackgroundImage = global::LP2Soft.Properties.Resources.fondo1;
            this.lblCabecera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblCabecera.ForeColor = System.Drawing.Color.White;
            this.lblCabecera.Location = new System.Drawing.Point(-2, 0);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(961, 47);
            this.lblCabecera.TabIndex = 66;
            this.lblCabecera.Text = "Gestión de Empleados";
            this.lblCabecera.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubirFoto.BackgroundImage = global::LP2Soft.Properties.Resources.upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubirFoto.Location = new System.Drawing.Point(853, 258);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(45, 40);
            this.btnSubirFoto.TabIndex = 8;
            this.btnSubirFoto.UseVisualStyleBackColor = false;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(666, 43);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(232, 255);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 61;
            this.pbFoto.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderRadius = 10;
            this.btnRegistrar.CheckedState.Parent = this.btnRegistrar;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.CustomImages.Parent = this.btnRegistrar;
            this.btnRegistrar.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.HoverState.Parent = this.btnRegistrar;
            this.btnRegistrar.Image = global::LP2Soft.Properties.Resources.save;
            this.btnRegistrar.Location = new System.Drawing.Point(329, 494);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.PressedColor = System.Drawing.Color.Red;
            this.btnRegistrar.ShadowDecoration.BorderRadius = 0;
            this.btnRegistrar.ShadowDecoration.Parent = this.btnRegistrar;
            this.btnRegistrar.Size = new System.Drawing.Size(149, 45);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextOffset = new System.Drawing.Point(3, 0);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(-8, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.guna2PictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(967, 555);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 56;
            this.guna2PictureBox3.TabStop = false;
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDatosUsuario.Location = new System.Drawing.Point(141, 285);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(506, 29);
            this.lblDatosUsuario.TabIndex = 37;
            this.lblDatosUsuario.Text = "Datos Usuario";
            this.lblDatosUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImage = global::LP2Soft.Properties.Resources.fondo1;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::LP2Soft.Properties.Resources.icons8_pase_de_seguridad_100;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(-2, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(55, 47);
            this.guna2Button1.TabIndex = 68;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::LP2Soft.Properties.Resources.cancelar;
            this.btnCancelar.ImageSize = new System.Drawing.Size(17, 17);
            this.btnCancelar.Location = new System.Drawing.Point(520, 494);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.Red;
            this.btnCancelar.ShadowDecoration.BorderRadius = 0;
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(149, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextOffset = new System.Drawing.Point(3, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.SystemColors.Window;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.Black;
            this.lblImagen.Location = new System.Drawing.Point(587, 37);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(48, 24);
            this.lblImagen.TabIndex = 70;
            this.lblImagen.Text = "Foto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblImagen);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblApellidoPaterno);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtApellidoPaterno);
            this.groupBox1.Controls.Add(this.lblApellidoMaterno);
            this.groupBox1.Controls.Add(this.btnSubirFoto);
            this.groupBox1.Controls.Add(this.txtApellidoMaterno);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.cmbRol);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.lblSueldo);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 313);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblConfirmarPassword);
            this.groupBox2.Controls.Add(this.txtPasswordConfirm);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 123);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epApePater
            // 
            this.epApePater.ContainerControl = this;
            // 
            // epApeMater
            // 
            this.epApeMater.ContainerControl = this;
            // 
            // epDNI
            // 
            this.epDNI.ContainerControl = this;
            // 
            // epTelefono
            // 
            this.epTelefono.ContainerControl = this;
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epContraseña
            // 
            this.epContraseña.ContainerControl = this;
            // 
            // epCorreo
            // 
            this.epCorreo.ContainerControl = this;
            // 
            // epSueldo
            // 
            this.epSueldo.ContainerControl = this;
            // 
            // frm_Gestion_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 549);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.lblDatosUsuario);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Gestion_Usuario";
            this.Text = "frm_Gestion_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApePater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epApeMater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSueldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbRol;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblRol;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label lblCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCabecera;
        private System.Windows.Forms.Label lblDatosUsuario;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epApePater;
        private System.Windows.Forms.ErrorProvider epApeMater;
        private System.Windows.Forms.ErrorProvider epDNI;
        private System.Windows.Forms.ErrorProvider epTelefono;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epContraseña;
        private System.Windows.Forms.ErrorProvider epCorreo;
        private System.Windows.Forms.ErrorProvider epSueldo;
    }
}