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
            this.panelPedidos = new System.Windows.Forms.Panel();
            this.btnPagar = new Guna.UI2.WinForms.Guna2Button();
            this.lblMesa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelPedidos
            // 
            this.panelPedidos.AutoScroll = true;
            this.panelPedidos.BackColor = System.Drawing.Color.White;
            this.panelPedidos.Location = new System.Drawing.Point(12, 56);
            this.panelPedidos.Name = "panelPedidos";
            this.panelPedidos.Size = new System.Drawing.Size(222, 389);
            this.panelPedidos.TabIndex = 82;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Transparent;
            this.btnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPagar.BackgroundImage")));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagar.BorderRadius = 10;
            this.btnPagar.CheckedState.Parent = this.btnPagar;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.CustomImages.Parent = this.btnPagar;
            this.btnPagar.FillColor = System.Drawing.Color.Transparent;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.HoverState.Parent = this.btnPagar;
            this.btnPagar.Image = global::LP2Soft.Properties.Resources.generalComida;
            this.btnPagar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagar.ImageSize = new System.Drawing.Size(15, 15);
            this.btnPagar.Location = new System.Drawing.Point(73, 451);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.PressedColor = System.Drawing.Color.Red;
            this.btnPagar.ShadowDecoration.Parent = this.btnPagar;
            this.btnPagar.Size = new System.Drawing.Size(105, 30);
            this.btnPagar.TabIndex = 159;
            this.btnPagar.Text = "Cobrar";
            this.btnPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMesa.Location = new System.Drawing.Point(80, 19);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(81, 24);
            this.lblMesa.TabIndex = 160;
            this.lblMesa.Text = "Mesa X";
            // 
            // frm_Cajero_Pedidos_Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LP2Soft.Properties.Resources.sombra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(246, 501);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.panelPedidos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cajero_Pedidos_Mesa";
            this.Text = "frm_Cajero_Pedidos_Mesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelPedidos;
        private Guna.UI2.WinForms.Guna2Button btnPagar;
        private System.Windows.Forms.Label lblMesa;
    }
}