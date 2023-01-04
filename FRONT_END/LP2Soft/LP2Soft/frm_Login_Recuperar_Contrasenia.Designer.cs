namespace LP2Soft
{
    partial class frm_Login_Recuperar_Contrasenia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMsjError = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSiguiente = new Guna.UI2.WinForms.Guna2Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtContrasenia2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMsjError2 = new System.Windows.Forms.Label();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.epInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.epContrasenia2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContrasenia2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(349, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cambio de contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtInput
            // 
            this.txtInput.BorderColor = System.Drawing.Color.Gray;
            this.txtInput.BorderRadius = 10;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DefaultText = "";
            this.txtInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.DisabledState.Parent = this.txtInput;
            this.txtInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.FocusedState.Parent = this.txtInput;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.HoverState.Parent = this.txtInput;
            this.txtInput.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtInput.Location = new System.Drawing.Point(376, 120);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.PlaceholderText = "";
            this.txtInput.SelectedText = "";
            this.txtInput.ShadowDecoration.Parent = this.txtInput;
            this.txtInput.Size = new System.Drawing.Size(327, 36);
            this.txtInput.TabIndex = 9;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtInput.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(376, 67);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.MaximumSize = new System.Drawing.Size(339, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(327, 51);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Ingrese su dirección de correo electrónico";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMsjError
            // 
            this.lblMsjError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjError.ForeColor = System.Drawing.Color.Red;
            this.lblMsjError.Location = new System.Drawing.Point(386, 160);
            this.lblMsjError.Name = "lblMsjError";
            this.lblMsjError.Size = new System.Drawing.Size(300, 47);
            this.lblMsjError.TabIndex = 15;
            this.lblMsjError.Text = "No pudimos encontrar tu cuenta de Quinti";
            this.lblMsjError.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Image = global::LP2Soft.Properties.Resources.login_logo;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-32, -49);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(381, 469);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.BorderRadius = 20;
            this.btnSiguiente.CheckedState.Parent = this.btnSiguiente;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.CustomImages.Parent = this.btnSiguiente;
            this.btnSiguiente.FillColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.HoverState.Parent = this.btnSiguiente;
            this.btnSiguiente.Location = new System.Drawing.Point(533, 326);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.ShadowDecoration.Parent = this.btnSiguiente;
            this.btnSiguiente.Size = new System.Drawing.Size(170, 37);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtContrasenia2
            // 
            this.txtContrasenia2.BorderColor = System.Drawing.Color.Gray;
            this.txtContrasenia2.BorderRadius = 10;
            this.txtContrasenia2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasenia2.DefaultText = "";
            this.txtContrasenia2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasenia2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasenia2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia2.DisabledState.Parent = this.txtContrasenia2;
            this.txtContrasenia2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasenia2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtContrasenia2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenia2.FocusedState.Parent = this.txtContrasenia2;
            this.txtContrasenia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia2.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenia2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasenia2.HoverState.Parent = this.txtContrasenia2;
            this.txtContrasenia2.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtContrasenia2.Location = new System.Drawing.Point(376, 232);
            this.txtContrasenia2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtContrasenia2.Name = "txtContrasenia2";
            this.txtContrasenia2.PasswordChar = '\0';
            this.txtContrasenia2.PlaceholderText = "";
            this.txtContrasenia2.SelectedText = "";
            this.txtContrasenia2.ShadowDecoration.Parent = this.txtContrasenia2;
            this.txtContrasenia2.Size = new System.Drawing.Size(327, 36);
            this.txtContrasenia2.TabIndex = 19;
            // 
            // lblMsjError2
            // 
            this.lblMsjError2.AutoSize = true;
            this.lblMsjError2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjError2.ForeColor = System.Drawing.Color.Red;
            this.lblMsjError2.Location = new System.Drawing.Point(386, 271);
            this.lblMsjError2.Name = "lblMsjError2";
            this.lblMsjError2.Size = new System.Drawing.Size(198, 15);
            this.lblMsjError2.TabIndex = 20;
            this.lblMsjError2.Text = "Las contraseñas no coinciden";
            this.lblMsjError2.Visible = false;
            // 
            // lblTipo2
            // 
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.ForeColor = System.Drawing.Color.Black;
            this.lblTipo2.Location = new System.Drawing.Point(376, 199);
            this.lblTipo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo2.MaximumSize = new System.Drawing.Size(339, 28);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(339, 28);
            this.lblTipo2.TabIndex = 21;
            this.lblTipo2.Text = "Confirme la nueva contraseña";
            this.lblTipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epInput
            // 
            this.epInput.ContainerControl = this;
            // 
            // epContrasenia2
            // 
            this.epContrasenia2.ContainerControl = this;
            // 
            // frm_Login_Recuperar_Contrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 383);
            this.Controls.Add(this.lblTipo2);
            this.Controls.Add(this.lblMsjError2);
            this.Controls.Add(this.txtContrasenia2);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblMsjError);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Login_Recuperar_Contrasenia";
            this.Text = "Restablecer Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epContrasenia2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtInput;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMsjError;
        private Guna.UI2.WinForms.Guna2Button btnSiguiente;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasenia2;
        private System.Windows.Forms.Label lblMsjError2;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.ErrorProvider epInput;
        private System.Windows.Forms.ErrorProvider epContrasenia2;
    }
}