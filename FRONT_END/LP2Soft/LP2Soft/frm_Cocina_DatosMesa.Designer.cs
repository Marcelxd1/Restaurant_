namespace LP2Soft
{
    partial class frm_Cocina_DatosMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cocina_DatosMesa));
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.lblMesa = new System.Windows.Forms.Label();
            this.btnListo = new Guna.UI2.WinForms.Guna2Button();
            this.btnProceso = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.pcbEstado = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPedidos
            // 
            this.panelPedidos.AutoScroll = true;
            this.panelPedidos.Location = new System.Drawing.Point(12, 60);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(196, 292);
            this.panelPedidos.TabIndex = 1;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(81, 17);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(69, 20);
            this.lblMesa.TabIndex = 4;
            this.lblMesa.Text = "Mesa X";
            // 
            // btnListo
            // 
            this.btnListo.BorderRadius = 10;
            this.btnListo.CheckedState.Parent = this.btnListo;
            this.btnListo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListo.CustomImages.Parent = this.btnListo;
            this.btnListo.FillColor = System.Drawing.Color.Black;
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.HoverState.Parent = this.btnListo;
            this.btnListo.Location = new System.Drawing.Point(26, 367);
            this.btnListo.Name = "btnListo";
            this.btnListo.PressedColor = System.Drawing.Color.Lime;
            this.btnListo.ShadowDecoration.Parent = this.btnListo;
            this.btnListo.Size = new System.Drawing.Size(88, 28);
            this.btnListo.TabIndex = 76;
            this.btnListo.Text = "Listo";
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // btnProceso
            // 
            this.btnProceso.BorderRadius = 10;
            this.btnProceso.CheckedState.Parent = this.btnProceso;
            this.btnProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceso.CustomImages.Parent = this.btnProceso;
            this.btnProceso.FillColor = System.Drawing.Color.Black;
            this.btnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceso.ForeColor = System.Drawing.Color.White;
            this.btnProceso.HoverState.Parent = this.btnProceso;
            this.btnProceso.Location = new System.Drawing.Point(120, 367);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.PressedColor = System.Drawing.Color.Yellow;
            this.btnProceso.ShadowDecoration.Parent = this.btnProceso;
            this.btnProceso.Size = new System.Drawing.Size(88, 28);
            this.btnProceso.TabIndex = 77;
            this.btnProceso.Text = "En proceso";
            this.btnProceso.Click += new System.EventHandler(this.btnPreparado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Estado";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(168, 31);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(35, 13);
            this.lblIdPedido.TabIndex = 81;
            this.lblIdPedido.Text = "label2";
            this.lblIdPedido.Visible = false;
            // 
            // pcbEstado
            // 
            this.pcbEstado.Image = global::LP2Soft.Properties.Resources.PRIORIDAD;
            this.pcbEstado.Location = new System.Drawing.Point(96, 40);
            this.pcbEstado.Name = "pcbEstado";
            this.pcbEstado.Size = new System.Drawing.Size(18, 17);
            this.pcbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEstado.TabIndex = 80;
            this.pcbEstado.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(8, 7);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(210, 404);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 79;
            this.guna2PictureBox3.TabStop = false;
            // 
            // frm_Cocina_DatosMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 416);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.pcbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.panelPedidos);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cocina_DatosMesa";
            this.Text = "frm_Cocina_DatosMesa";
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPedidos;
        private System.Windows.Forms.Label lblMesa;
        private Guna.UI2.WinForms.Guna2Button btnListo;
        private Guna.UI2.WinForms.Guna2Button btnProceso;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.PictureBox pcbEstado;
        private System.Windows.Forms.Label lblIdPedido;
    }
}