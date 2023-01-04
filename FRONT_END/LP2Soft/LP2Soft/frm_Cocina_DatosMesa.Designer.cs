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
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.pcbEstado = new System.Windows.Forms.PictureBox();
            this.btnListo = new Guna.UI2.WinForms.Guna2Button();
            this.btnProceso = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPedidos
            // 
            this.panelPedidos.AutoScroll = true;
            this.panelPedidos.Location = new System.Drawing.Point(12, 60);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(222, 380);
            this.panelPedidos.TabIndex = 1;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMesa.Location = new System.Drawing.Point(80, 10);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(81, 24);
            this.lblMesa.TabIndex = 4;
            this.lblMesa.Text = "Mesa X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 38);
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
            this.pcbEstado.Location = new System.Drawing.Point(86, 41);
            this.pcbEstado.Name = "pcbEstado";
            this.pcbEstado.Size = new System.Drawing.Size(18, 17);
            this.pcbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEstado.TabIndex = 80;
            this.pcbEstado.TabStop = false;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.Transparent;
            this.btnListo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListo.BackgroundImage")));
            this.btnListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListo.BorderRadius = 10;
            this.btnListo.CheckedState.Parent = this.btnListo;
            this.btnListo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListo.CustomImages.Parent = this.btnListo;
            this.btnListo.FillColor = System.Drawing.Color.Transparent;
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.White;
            this.btnListo.HoverState.Parent = this.btnListo;
            this.btnListo.Image = global::LP2Soft.Properties.Resources.listo;
            this.btnListo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListo.ImageSize = new System.Drawing.Size(15, 15);
            this.btnListo.Location = new System.Drawing.Point(12, 446);
            this.btnListo.Name = "btnListo";
            this.btnListo.PressedColor = System.Drawing.Color.Red;
            this.btnListo.ShadowDecoration.Parent = this.btnListo;
            this.btnListo.Size = new System.Drawing.Size(105, 30);
            this.btnListo.TabIndex = 157;
            this.btnListo.Text = "Listo";
            this.btnListo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // btnProceso
            // 
            this.btnProceso.BackColor = System.Drawing.Color.Transparent;
            this.btnProceso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProceso.BackgroundImage")));
            this.btnProceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProceso.BorderRadius = 10;
            this.btnProceso.CheckedState.Parent = this.btnProceso;
            this.btnProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceso.CustomImages.Parent = this.btnProceso;
            this.btnProceso.FillColor = System.Drawing.Color.Transparent;
            this.btnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProceso.ForeColor = System.Drawing.Color.White;
            this.btnProceso.HoverState.Parent = this.btnProceso;
            this.btnProceso.Image = global::LP2Soft.Properties.Resources.generalComida;
            this.btnProceso.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProceso.ImageSize = new System.Drawing.Size(15, 15);
            this.btnProceso.Location = new System.Drawing.Point(129, 446);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.PressedColor = System.Drawing.Color.Red;
            this.btnProceso.ShadowDecoration.Parent = this.btnProceso;
            this.btnProceso.Size = new System.Drawing.Size(105, 30);
            this.btnProceso.TabIndex = 158;
            this.btnProceso.Text = "Cocinar";
            this.btnProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProceso.Click += new System.EventHandler(this.btnPreparado_Click);
            // 
            // frm_Cocina_DatosMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LP2Soft.Properties.Resources.sombra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(246, 501);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.pcbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.panelPedidos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cocina_DatosMesa";
            this.Text = "frm_Cocina_DatosMesa";
            ((System.ComponentModel.ISupportInitialize)(this.pcbEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPedidos;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbEstado;
        private System.Windows.Forms.Label lblIdPedido;
        private Guna.UI2.WinForms.Guna2Button btnListo;
        private Guna.UI2.WinForms.Guna2Button btnProceso;
    }
}