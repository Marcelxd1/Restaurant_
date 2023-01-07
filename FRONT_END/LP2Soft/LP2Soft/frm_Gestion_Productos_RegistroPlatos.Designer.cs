namespace LP2Soft
{
    partial class frm_Gestion_Productos_RegistroPlatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Gestion_Productos_RegistroPlatos));
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPresentacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.epNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbPlato = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbBebida = new Guna.UI2.WinForms.Guna2RadioButton();
            this.epTipo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.ofdFotos = new System.Windows.Forms.OpenFileDialog();
            this.btnSubirFoto = new Guna.UI2.WinForms.Guna2Button();
            this.pbPlato = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCabecera = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderRadius = 10;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.Location = new System.Drawing.Point(437, 265);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(239, 90);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(423, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descripción";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderRadius = 10;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.Parent = this.txtPrecio;
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedState.Parent = this.txtPrecio;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.HoverState.Parent = this.txtPrecio;
            this.txtPrecio.Location = new System.Drawing.Point(27, 126);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(142, 30);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrecio_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Precio";
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
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(27, 53);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(323, 30);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Tipo";
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.BorderRadius = 10;
            this.txtPresentacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPresentacion.DefaultText = "";
            this.txtPresentacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPresentacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPresentacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPresentacion.DisabledState.Parent = this.txtPresentacion;
            this.txtPresentacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPresentacion.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPresentacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPresentacion.FocusedState.Parent = this.txtPresentacion;
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.ForeColor = System.Drawing.Color.Black;
            this.txtPresentacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPresentacion.HoverState.Parent = this.txtPresentacion;
            this.txtPresentacion.Location = new System.Drawing.Point(27, 325);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.PasswordChar = '\0';
            this.txtPresentacion.PlaceholderText = "";
            this.txtPresentacion.SelectedText = "";
            this.txtPresentacion.ShadowDecoration.Parent = this.txtPresentacion;
            this.txtPresentacion.Size = new System.Drawing.Size(142, 30);
            this.txtPresentacion.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Presentación";
            // 
            // epNombre
            // 
            this.epNombre.ContainerControl = this;
            // 
            // epPrecio
            // 
            this.epPrecio.ContainerControl = this;
            // 
            // epDescripcion
            // 
            this.epDescripcion.ContainerControl = this;
            // 
            // rbPlato
            // 
            this.rbPlato.AutoSize = true;
            this.rbPlato.CheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.rbPlato.CheckedState.BorderThickness = 0;
            this.rbPlato.CheckedState.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.rbPlato.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPlato.CheckedState.InnerOffset = -4;
            this.rbPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPlato.ForeColor = System.Drawing.Color.Black;
            this.rbPlato.Location = new System.Drawing.Point(61, 265);
            this.rbPlato.Name = "rbPlato";
            this.rbPlato.Size = new System.Drawing.Size(65, 24);
            this.rbPlato.TabIndex = 57;
            this.rbPlato.Text = "Plato";
            this.rbPlato.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPlato.UncheckedState.BorderThickness = 2;
            this.rbPlato.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPlato.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPlato.UseVisualStyleBackColor = true;
            // 
            // rbBebida
            // 
            this.rbBebida.AutoSize = true;
            this.rbBebida.CheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.rbBebida.CheckedState.BorderThickness = 0;
            this.rbBebida.CheckedState.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.rbBebida.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbBebida.CheckedState.InnerOffset = -4;
            this.rbBebida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBebida.ForeColor = System.Drawing.Color.Black;
            this.rbBebida.Location = new System.Drawing.Point(161, 265);
            this.rbBebida.Name = "rbBebida";
            this.rbBebida.Size = new System.Drawing.Size(79, 24);
            this.rbBebida.TabIndex = 58;
            this.rbBebida.Text = "Bebida";
            this.rbBebida.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbBebida.UncheckedState.BorderThickness = 2;
            this.rbBebida.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbBebida.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbBebida.UseVisualStyleBackColor = true;
            this.rbBebida.CheckedChanged += new System.EventHandler(this.rbBebida_CheckedChanged);
            // 
            // epTipo
            // 
            this.epTipo.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Categoría";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbCategoria.BorderRadius = 10;
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategoria.FocusedState.Parent = this.cbCategoria;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategoria.HoverState.Parent = this.cbCategoria;
            this.cbCategoria.ItemHeight = 30;
            this.cbCategoria.ItemsAppearance.Parent = this.cbCategoria;
            this.cbCategoria.Location = new System.Drawing.Point(27, 198);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.ShadowDecoration.Parent = this.cbCategoria;
            this.cbCategoria.Size = new System.Drawing.Size(266, 36);
            this.cbCategoria.TabIndex = 3;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.SystemColors.Window;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.Black;
            this.lblFoto.Location = new System.Drawing.Point(412, 25);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(73, 24);
            this.lblFoto.TabIndex = 62;
            this.lblFoto.Text = "Imagen";
            // 
            // ofdFotos
            // 
            this.ofdFotos.FileName = "openFileDialog1";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirFoto.BackgroundImage = global::LP2Soft.Properties.Resources.upload;
            this.btnSubirFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubirFoto.CheckedState.Parent = this.btnSubirFoto;
            this.btnSubirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFoto.CustomImages.Parent = this.btnSubirFoto;
            this.btnSubirFoto.FillColor = System.Drawing.Color.Transparent;
            this.btnSubirFoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubirFoto.ForeColor = System.Drawing.Color.White;
            this.btnSubirFoto.HoverState.Parent = this.btnSubirFoto;
            this.btnSubirFoto.ImageSize = new System.Drawing.Size(40, 35);
            this.btnSubirFoto.Location = new System.Drawing.Point(636, 194);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.ShadowDecoration.Parent = this.btnSubirFoto;
            this.btnSubirFoto.Size = new System.Drawing.Size(40, 40);
            this.btnSubirFoto.TabIndex = 63;
            this.btnSubirFoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbPlato
            // 
            this.pbPlato.BackColor = System.Drawing.Color.White;
            this.pbPlato.Location = new System.Drawing.Point(455, 53);
            this.pbPlato.Name = "pbPlato";
            this.pbPlato.ShadowDecoration.Parent = this.pbPlato;
            this.pbPlato.Size = new System.Drawing.Size(221, 181);
            this.pbPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlato.TabIndex = 40;
            this.pbPlato.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(-5, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(770, 482);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 61;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
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
            this.btnCancelar.ImageSize = new System.Drawing.Size(18, 18);
            this.btnCancelar.Location = new System.Drawing.Point(213, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.Red;
            this.btnCancelar.ShadowDecoration.BorderRadius = 0;
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(149, 45);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextOffset = new System.Drawing.Point(3, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 10;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Image = global::LP2Soft.Properties.Resources.save;
            this.btnGuardar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnGuardar.Location = new System.Drawing.Point(428, 433);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PressedColor = System.Drawing.Color.Red;
            this.btnGuardar.ShadowDecoration.BorderRadius = 0;
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(149, 45);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.TextOffset = new System.Drawing.Point(3, 0);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = false;
            this.lblCabecera.BackColor = System.Drawing.Color.Transparent;
            this.lblCabecera.BackgroundImage = global::LP2Soft.Properties.Resources.fondo1;
            this.lblCabecera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblCabecera.ForeColor = System.Drawing.Color.White;
            this.lblCabecera.Location = new System.Drawing.Point(-5, -1);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(770, 47);
            this.lblCabecera.TabIndex = 77;
            this.lblCabecera.Text = "Gestión de Productos";
            this.lblCabecera.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.guna2Button1.Image = global::LP2Soft.Properties.Resources.productos;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(-1, -1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(55, 47);
            this.guna2Button1.TabIndex = 78;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubirFoto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbCategoria);
            this.groupBox2.Controls.Add(this.lblFoto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pbPlato);
            this.groupBox2.Controls.Add(this.rbBebida);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbPlato);
            this.groupBox2.Controls.Add(this.txtPresentacion);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 375);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Producto";
            // 
            // frm_Gestion_Productos_RegistroPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Gestion_Productos_RegistroPlatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Gestion_Productos_RegistroPlatos";
            ((System.ComponentModel.ISupportInitialize)(this.epNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox pbPlato;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPresentacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider epNombre;
        private System.Windows.Forms.ErrorProvider epPrecio;
        private System.Windows.Forms.ErrorProvider epDescripcion;
        private Guna.UI2.WinForms.Guna2RadioButton rbBebida;
        private Guna.UI2.WinForms.Guna2RadioButton rbPlato;
        private System.Windows.Forms.ErrorProvider epTipo;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategoria;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblFoto;
        private Guna.UI2.WinForms.Guna2Button btnSubirFoto;
        private System.Windows.Forms.OpenFileDialog ofdFotos;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCabecera;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}