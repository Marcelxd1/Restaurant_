namespace LP2Soft
{
    partial class frm_Cajero_Pedidos_Mesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cajero_Pedidos_Mesa));
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnPagar = new Guna.UI2.WinForms.Guna2Button();
            this.lblMesa = new System.Windows.Forms.Label();
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.Color.White;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(12, 42);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(66, 20);
            this.lblPedido.TabIndex = 86;
            this.lblPedido.Text = "Estado";
            // 
            // btnPagar
            // 
            this.btnPagar.Animated = true;
            this.btnPagar.BorderRadius = 10;
            this.btnPagar.CheckedState.Parent = this.btnPagar;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.CustomImages.Parent = this.btnPagar;
            this.btnPagar.FillColor = System.Drawing.Color.Black;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.HoverState.Parent = this.btnPagar;
            this.btnPagar.Location = new System.Drawing.Point(74, 361);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.ShadowDecoration.Parent = this.btnPagar;
            this.btnPagar.Size = new System.Drawing.Size(88, 28);
            this.btnPagar.TabIndex = 84;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.White;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(69, 18);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(93, 20);
            this.lblMesa.TabIndex = 83;
            this.lblMesa.Text = "Para llevar";
            // 
            // panelPedidos
            // 
            this.panelPedidos.AutoScroll = true;
            this.panelPedidos.BackColor = System.Drawing.Color.White;
            this.panelPedidos.Location = new System.Drawing.Point(12, 65);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(211, 290);
            this.panelPedidos.TabIndex = 82;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(3, 1);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(230, 416);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 87;
            this.guna2PictureBox3.TabStop = false;
            // 
            // frm_Cajero_Pedidos_Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(235, 417);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.panelPedidos);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cajero_Pedidos_Mesa";
            this.Text = "frm_Cajero_Pedidos_Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPedido;
        private Guna.UI2.WinForms.Guna2Button btnPagar;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Panel panelPedidos;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}