namespace LP2Soft
{
    partial class frm_Cajero_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cajero_Pedidos));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLlevar = new Guna.UI2.WinForms.Guna2Button();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.lblNotificacion);
            this.panelContenedor.Location = new System.Drawing.Point(38, 69);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(929, 498);
            this.panelContenedor.TabIndex = 114;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.AutoSize = true;
            this.lblNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacion.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNotificacion.Location = new System.Drawing.Point(34, 200);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(57, 20);
            this.lblNotificacion.TabIndex = 111;
            this.lblNotificacion.Text = "label1";
            this.lblNotificacion.Visible = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(1, 4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(1011, 582);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 117;
            this.guna2PictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(447, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 118;
            this.label2.Text = "Pedidos";
            // 
            // btnLlevar
            // 
            this.btnLlevar.BackColor = System.Drawing.Color.Transparent;
            this.btnLlevar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLlevar.BackgroundImage")));
            this.btnLlevar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLlevar.BorderRadius = 10;
            this.btnLlevar.CheckedState.Parent = this.btnLlevar;
            this.btnLlevar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlevar.CustomImages.Parent = this.btnLlevar;
            this.btnLlevar.FillColor = System.Drawing.Color.Transparent;
            this.btnLlevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlevar.ForeColor = System.Drawing.Color.White;
            this.btnLlevar.HoverState.Parent = this.btnLlevar;
            this.btnLlevar.Image = global::LP2Soft.Properties.Resources.pedir;
            this.btnLlevar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLlevar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnLlevar.Location = new System.Drawing.Point(833, 24);
            this.btnLlevar.Name = "btnLlevar";
            this.btnLlevar.PressedColor = System.Drawing.Color.Red;
            this.btnLlevar.ShadowDecoration.Parent = this.btnLlevar;
            this.btnLlevar.Size = new System.Drawing.Size(134, 39);
            this.btnLlevar.TabIndex = 156;
            this.btnLlevar.Text = "Para llevar";
            this.btnLlevar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLlevar.Click += new System.EventHandler(this.btnLlevar_Click);
            // 
            // frm_Cajero_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 579);
            this.Controls.Add(this.btnLlevar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cajero_Pedidos";
            this.Text = "frm_Cajero_Pedidos";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblNotificacion;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnLlevar;
    }
}