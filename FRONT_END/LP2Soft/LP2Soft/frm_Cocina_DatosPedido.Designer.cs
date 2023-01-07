namespace LP2Soft
{
    partial class frm_Cocina_DatosPedido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbNotificacion = new System.Windows.Forms.PictureBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ptbNotificacion);
            this.groupBox1.Controls.Add(this.lblPedido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ptbNotificacion
            // 
            this.ptbNotificacion.BackgroundImage = global::LP2Soft.Properties.Resources.notificacion;
            this.ptbNotificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbNotificacion.Location = new System.Drawing.Point(6, 20);
            this.ptbNotificacion.Name = "ptbNotificacion";
            this.ptbNotificacion.Size = new System.Drawing.Size(19, 21);
            this.ptbNotificacion.TabIndex = 1;
            this.ptbNotificacion.TabStop = false;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPedido.Location = new System.Drawing.Point(31, 25);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(44, 16);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "label1";
            // 
            // frm_Cocina_DatosPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(219, 78);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cocina_DatosPedido";
            this.Text = "frm_Cocina_DatosPedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNotificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox ptbNotificacion;
        private System.Windows.Forms.Label lblPedido;
    }
}