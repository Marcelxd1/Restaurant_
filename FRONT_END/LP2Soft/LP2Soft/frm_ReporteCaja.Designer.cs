namespace LP2Soft
{
    partial class frm_ReporteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReporteCaja));
            this.panelContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIni = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGeneraReporte = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.panelContenedor.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.dtpIni);
            this.panelContenedor.Controls.Add(this.dtpFin);
            this.panelContenedor.Controls.Add(this.btnGeneraReporte);
            this.panelContenedor.Controls.Add(this.label4);
            this.panelContenedor.Controls.Add(this.label5);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.ShadowDecoration.Parent = this.panelContenedor;
            this.panelContenedor.Size = new System.Drawing.Size(311, 437);
            this.panelContenedor.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Reporte de caja";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpIni
            // 
            this.dtpIni.BorderColor = System.Drawing.Color.MediumPurple;
            this.dtpIni.BorderRadius = 5;
            this.dtpIni.BorderThickness = 1;
            this.dtpIni.CheckedState.Parent = this.dtpIni;
            this.dtpIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpIni.FillColor = System.Drawing.Color.Transparent;
            this.dtpIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.HoverState.Parent = this.dtpIni;
            this.dtpIni.Location = new System.Drawing.Point(40, 145);
            this.dtpIni.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIni.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.ShadowDecoration.Parent = this.dtpIni;
            this.dtpIni.Size = new System.Drawing.Size(190, 31);
            this.dtpIni.TabIndex = 74;
            this.dtpIni.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // dtpFin
            // 
            this.dtpFin.BorderColor = System.Drawing.Color.MediumPurple;
            this.dtpFin.BorderRadius = 5;
            this.dtpFin.BorderThickness = 1;
            this.dtpFin.CheckedState.Parent = this.dtpFin;
            this.dtpFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFin.FillColor = System.Drawing.Color.Transparent;
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.HoverState.Parent = this.dtpFin;
            this.dtpFin.Location = new System.Drawing.Point(40, 240);
            this.dtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShadowDecoration.Parent = this.dtpFin;
            this.dtpFin.Size = new System.Drawing.Size(190, 31);
            this.dtpFin.TabIndex = 73;
            this.dtpFin.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
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
            this.btnGeneraReporte.TabIndex = 72;
            this.btnGeneraReporte.Tag = "Generar reporte";
            this.btnGeneraReporte.Text = "Generar reporte";
            this.btnGeneraReporte.Click += new System.EventHandler(this.btnGeneraReporte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 22);
            this.label4.TabIndex = 70;
            this.label4.Text = "Ingrese la fecha de inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 22);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ingrese la fecha de fin:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.visorPDF);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(311, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(397, 437);
            this.guna2Panel1.TabIndex = 63;
            // 
            // visorPDF
            // 
            this.visorPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorPDF.Enabled = true;
            this.visorPDF.Location = new System.Drawing.Point(0, 0);
            this.visorPDF.Margin = new System.Windows.Forms.Padding(2);
            this.visorPDF.Name = "visorPDF";
            this.visorPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visorPDF.OcxState")));
            this.visorPDF.Size = new System.Drawing.Size(397, 437);
            this.visorPDF.TabIndex = 9;
            // 
            // frm_ReporteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(708, 437);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelContenedor);
            this.Name = "frm_ReporteCaja";
            this.Text = "frm_ReporteCaja";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelContenedor;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIni;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFin;
        private Guna.UI2.WinForms.Guna2Button btnGeneraReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}