namespace LP2Soft
{
    partial class frm_Reporte_Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reporte_Asistencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIni = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.visorPDF = new AxAcroPDFLib.AxAcroPDF();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la fecha de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la fecha de fin:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpIni);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 437);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Reporte de asistencia";
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
            this.dtpIni.TabIndex = 55;
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
            this.dtpFin.TabIndex = 54;
            this.dtpFin.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.BorderColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BorderRadius = 10;
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.FillColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.Location = new System.Drawing.Point(117, 345);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.PressedColor = System.Drawing.Color.Red;
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(153, 38);
            this.btnImprimir.TabIndex = 42;
            this.btnImprimir.Text = "Generar reporte";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.visorPDF);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(311, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 437);
            this.panel2.TabIndex = 7;
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
            this.visorPDF.TabIndex = 0;
            // 
            // frm_Reporte_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Reporte_Asistencia";
            this.Text = "Reporte de Asistencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visorPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private AxAcroPDFLib.AxAcroPDF visorPDF;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIni;
        private System.Windows.Forms.Label label3;
    }
}