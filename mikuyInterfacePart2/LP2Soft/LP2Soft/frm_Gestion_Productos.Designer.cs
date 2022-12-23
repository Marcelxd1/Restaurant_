namespace LP2Soft
{
    partial class frm_Gestion_Productos
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
            this.panelContenedorProductos = new System.Windows.Forms.Panel();
            this.btnCombo = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnCategoria = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnPlatos = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.SuspendLayout();
            // 
            // panelContenedorProductos
            // 
            this.panelContenedorProductos.Location = new System.Drawing.Point(118, 5);
            this.panelContenedorProductos.Name = "panelContenedorProductos";
            this.panelContenedorProductos.Size = new System.Drawing.Size(889, 570);
            this.panelContenedorProductos.TabIndex = 62;
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.Transparent;
            this.btnCombo.BorderColor = System.Drawing.Color.Transparent;
            this.btnCombo.CheckedState.Parent = this.btnCombo;
            this.btnCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombo.CustomImages.Parent = this.btnCombo;
            this.btnCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(39)))), ((int)(((byte)(232)))));
            this.btnCombo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.btnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCombo.ForeColor = System.Drawing.Color.White;
            this.btnCombo.HoverState.Parent = this.btnCombo;
            this.btnCombo.Image = global::LP2Soft.Properties.Resources.productos;
            this.btnCombo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCombo.Location = new System.Drawing.Point(12, 119);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.PressedColor = System.Drawing.Color.Red;
            this.btnCombo.ShadowDecoration.BorderRadius = 15;
            this.btnCombo.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnCombo.ShadowDecoration.Enabled = true;
            this.btnCombo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCombo.ShadowDecoration.Parent = this.btnCombo;
            this.btnCombo.Size = new System.Drawing.Size(100, 100);
            this.btnCombo.TabIndex = 69;
            this.btnCombo.Text = "COMBOS";
            this.btnCombo.Click += new System.EventHandler(this.lblRegistrarCombo_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.BorderColor = System.Drawing.Color.Transparent;
            this.btnCategoria.CheckedState.Parent = this.btnCategoria;
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.CustomImages.Parent = this.btnCategoria;
            this.btnCategoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(39)))), ((int)(((byte)(232)))));
            this.btnCategoria.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.HoverState.Parent = this.btnCategoria;
            this.btnCategoria.Image = global::LP2Soft.Properties.Resources.productos;
            this.btnCategoria.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCategoria.Location = new System.Drawing.Point(12, 13);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.PressedColor = System.Drawing.Color.Red;
            this.btnCategoria.ShadowDecoration.BorderRadius = 15;
            this.btnCategoria.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnCategoria.ShadowDecoration.Enabled = true;
            this.btnCategoria.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCategoria.ShadowDecoration.Parent = this.btnCategoria;
            this.btnCategoria.Size = new System.Drawing.Size(100, 100);
            this.btnCategoria.TabIndex = 71;
            this.btnCategoria.Text = "CATEGORÍAS";
            this.btnCategoria.Click += new System.EventHandler(this.lblRegistrarCategoria_Click);
            // 
            // btnPlatos
            // 
            this.btnPlatos.BackColor = System.Drawing.Color.Transparent;
            this.btnPlatos.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlatos.CheckedState.Parent = this.btnPlatos;
            this.btnPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlatos.CustomImages.Parent = this.btnPlatos;
            this.btnPlatos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(39)))), ((int)(((byte)(232)))));
            this.btnPlatos.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.btnPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlatos.ForeColor = System.Drawing.Color.White;
            this.btnPlatos.HoverState.Parent = this.btnPlatos;
            this.btnPlatos.Image = global::LP2Soft.Properties.Resources.productos;
            this.btnPlatos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlatos.Location = new System.Drawing.Point(12, 225);
            this.btnPlatos.Name = "btnPlatos";
            this.btnPlatos.PressedColor = System.Drawing.Color.Red;
            this.btnPlatos.ShadowDecoration.BorderRadius = 15;
            this.btnPlatos.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnPlatos.ShadowDecoration.Enabled = true;
            this.btnPlatos.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlatos.ShadowDecoration.Parent = this.btnPlatos;
            this.btnPlatos.Size = new System.Drawing.Size(100, 100);
            this.btnPlatos.TabIndex = 70;
            this.btnPlatos.Text = "PLATOS";
            this.btnPlatos.Click += new System.EventHandler(this.lblRegistrarPlato_Click);
            // 
            // frm_Gestion_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1010, 579);
            this.Controls.Add(this.btnPlatos);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.panelContenedorProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Gestion_Productos";
            this.Text = "Gestion de productos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedorProductos;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnCombo;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnCategoria;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnPlatos;
    }
}