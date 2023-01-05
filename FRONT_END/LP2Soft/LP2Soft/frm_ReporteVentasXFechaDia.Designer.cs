namespace LP2Soft
{
    partial class frm_ReporteVentasXFechaDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReporteVentasXFechaDia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneraReporte = new Guna.UI2.WinForms.Guna2Button();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGeneraReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 437);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 60);
            this.label3.TabIndex = 82;
            this.label3.Text = "Reporte de ventas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGeneraReporte
            // 
            this.btnGeneraReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneraReporte.BackgroundImage")));
            this.btnGeneraReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneraReporte.BorderColor = System.Drawing.Color.Transparent;
            this.btnGeneraReporte.BorderRadius = 10;
            this.btnGeneraReporte.CheckedState.Parent = this.btnGeneraReporte;
            this.btnGeneraReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneraReporte.CustomImages.Parent = this.btnGeneraReporte;
            this.btnGeneraReporte.FillColor = System.Drawing.Color.Transparent;
            this.btnGeneraReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeneraReporte.ForeColor = System.Drawing.Color.White;
            this.btnGeneraReporte.HoverState.Parent = this.btnGeneraReporte;
            this.btnGeneraReporte.Location = new System.Drawing.Point(117, 345);
            this.btnGeneraReporte.Name = "btnGeneraReporte";
            this.btnGeneraReporte.PressedColor = System.Drawing.Color.Red;
            this.btnGeneraReporte.ShadowDecoration.Parent = this.btnGeneraReporte;
            this.btnGeneraReporte.Size = new System.Drawing.Size(153, 38);
            this.btnGeneraReporte.TabIndex = 73;
            this.btnGeneraReporte.Tag = "Generar reporte";
            this.btnGeneraReporte.Text = "Generar reporte";
            this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
            // 
            // visorPDF
            // 
            this.visorPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(311, 0);
            this.visorPDF.Margin = new System.Windows.Forms.Padding(2);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(397, 437);
            this.visorPDF.TabIndex = 8;
            // 
            // frm_ReporteVentasXFechaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 437);
            this.Controls.Add(this.visorPDF);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_ReporteVentasXFechaDia";
            this.Text = "Reporte ventas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
        private Guna.UI2.WinForms.Guna2Button btnGeneraReporte;
        private System.Windows.Forms.Label label3;
    }
}