﻿namespace LP2Soft
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pctPersona = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblRolPersona = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnAsistencia = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCaja = new Guna.UI2.WinForms.Guna2Button();
            this.btnCocina = new Guna.UI2.WinForms.Guna2Button();
            this.btnGestion = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.panelContenedor = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPersona)).BeginInit();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.guna2PictureBox1);
            this.panelSuperior.Controls.Add(this.pctPersona);
            this.panelSuperior.Controls.Add(this.lblRolPersona);
            this.panelSuperior.Controls.Add(this.lblNombre);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1257, 168);
            this.panelSuperior.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = global::LP2Soft.Properties.Resources.logo_restaurant;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Location = new System.Drawing.Point(71, 51);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(123, 108);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pctPersona
            // 
            this.pctPersona.BackgroundImage = global::LP2Soft.Properties.Resources.User;
            this.pctPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctPersona.Location = new System.Drawing.Point(1146, 51);
            this.pctPersona.Name = "pctPersona";
            this.pctPersona.ShadowDecoration.Parent = this.pctPersona;
            this.pctPersona.Size = new System.Drawing.Size(91, 96);
            this.pctPersona.TabIndex = 4;
            this.pctPersona.TabStop = false;
            // 
            // lblRolPersona
            // 
            this.lblRolPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblRolPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolPersona.Location = new System.Drawing.Point(977, 94);
            this.lblRolPersona.Name = "lblRolPersona";
            this.lblRolPersona.Size = new System.Drawing.Size(75, 27);
            this.lblRolPersona.TabIndex = 3;
            this.lblRolPersona.Text = "Mesero";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(977, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 27);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Juan Carlos";
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(this.btnClientes);
            this.panelLateral.Controls.Add(this.btnAsistencia);
            this.panelLateral.Controls.Add(this.guna2PictureBox3);
            this.panelLateral.Controls.Add(this.guna2PictureBox2);
            this.panelLateral.Controls.Add(this.btnCaja);
            this.panelLateral.Controls.Add(this.btnCocina);
            this.panelLateral.Controls.Add(this.btnGestion);
            this.panelLateral.Controls.Add(this.btnPedidos);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 168);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(259, 579);
            this.panelLateral.TabIndex = 1;
            // 
            // btnClientes
            // 
            this.btnClientes.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnClientes.CheckedState.Parent = this.btnClientes;
            this.btnClientes.CustomImages.Parent = this.btnClientes;
            this.btnClientes.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClientes.HoverState.Parent = this.btnClientes;
            this.btnClientes.Image = global::LP2Soft.Properties.Resources.clientes1;
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.Location = new System.Drawing.Point(23, 346);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.PressedColor = System.Drawing.Color.Brown;
            this.btnClientes.ShadowDecoration.Parent = this.btnClientes;
            this.btnClientes.Size = new System.Drawing.Size(171, 45);
            this.btnClientes.TabIndex = 23;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnAsistencia.CheckedState.Parent = this.btnAsistencia;
            this.btnAsistencia.CustomImages.Parent = this.btnAsistencia;
            this.btnAsistencia.FillColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAsistencia.HoverState.Parent = this.btnAsistencia;
            this.btnAsistencia.Image = global::LP2Soft.Properties.Resources.icons8_marca_de_asistencia_50;
            this.btnAsistencia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAsistencia.Location = new System.Drawing.Point(23, 295);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.PressedColor = System.Drawing.Color.Brown;
            this.btnAsistencia.ShadowDecoration.Parent = this.btnAsistencia;
            this.btnAsistencia.Size = new System.Drawing.Size(189, 45);
            this.btnAsistencia.TabIndex = 22;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackgroundImage = global::LP2Soft.Properties.Resources.Quinti_logo;
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox3.Location = new System.Drawing.Point(12, 431);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(200, 136);
            this.guna2PictureBox3.TabIndex = 21;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackgroundImage = global::LP2Soft.Properties.Resources.LA_CAMPIÑA;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox2.Location = new System.Drawing.Point(33, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(203, 30);
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnCaja
            // 
            this.btnCaja.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCaja.CheckedState.Parent = this.btnCaja;
            this.btnCaja.CustomImages.Parent = this.btnCaja;
            this.btnCaja.FillColor = System.Drawing.Color.Transparent;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCaja.HoverState.Parent = this.btnCaja;
            this.btnCaja.Image = global::LP2Soft.Properties.Resources.dolar;
            this.btnCaja.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaja.Location = new System.Drawing.Point(23, 244);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.PressedColor = System.Drawing.Color.Brown;
            this.btnCaja.ShadowDecoration.Parent = this.btnCaja;
            this.btnCaja.Size = new System.Drawing.Size(160, 45);
            this.btnCaja.TabIndex = 20;
            this.btnCaja.Text = "Caja";
            // 
            // btnCocina
            // 
            this.btnCocina.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCocina.CheckedState.Parent = this.btnCocina;
            this.btnCocina.CustomImages.Parent = this.btnCocina;
            this.btnCocina.FillColor = System.Drawing.Color.Transparent;
            this.btnCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocina.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCocina.HoverState.Parent = this.btnCocina;
            this.btnCocina.Image = ((System.Drawing.Image)(resources.GetObject("btnCocina.Image")));
            this.btnCocina.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCocina.Location = new System.Drawing.Point(23, 193);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.PressedColor = System.Drawing.Color.Brown;
            this.btnCocina.ShadowDecoration.Parent = this.btnCocina;
            this.btnCocina.Size = new System.Drawing.Size(171, 45);
            this.btnCocina.TabIndex = 19;
            this.btnCocina.Text = "Cocina";
            // 
            // btnGestion
            // 
            this.btnGestion.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGestion.CheckedState.Parent = this.btnGestion;
            this.btnGestion.CustomImages.Parent = this.btnGestion;
            this.btnGestion.FillColor = System.Drawing.Color.Transparent;
            this.btnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGestion.HoverState.Parent = this.btnGestion;
            this.btnGestion.Image = ((System.Drawing.Image)(resources.GetObject("btnGestion.Image")));
            this.btnGestion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGestion.Location = new System.Drawing.Point(23, 142);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.ShadowDecoration.Parent = this.btnGestion;
            this.btnGestion.Size = new System.Drawing.Size(180, 45);
            this.btnGestion.TabIndex = 18;
            this.btnGestion.Text = "Gestión";
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btnPedidos.CheckedState.Parent = this.btnPedidos;
            this.btnPedidos.CustomImages.Parent = this.btnPedidos;
            this.btnPedidos.FillColor = System.Drawing.Color.Transparent;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPedidos.HoverState.Parent = this.btnPedidos;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPedidos.Location = new System.Drawing.Point(23, 91);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.ShadowDecoration.Parent = this.btnPedidos;
            this.btnPedidos.Size = new System.Drawing.Size(180, 45);
            this.btnPedidos.TabIndex = 8;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Image = ((System.Drawing.Image)(resources.GetObject("panelContenedor.Image")));
            this.panelContenedor.Location = new System.Drawing.Point(372, 184);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.ShadowDecoration.Parent = this.panelContenedor;
            this.panelContenedor.Size = new System.Drawing.Size(753, 525);
            this.panelContenedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 747);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPersona)).EndInit();
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelLateral;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pctPersona;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRolPersona;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombre;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button btnCaja;
        private Guna.UI2.WinForms.Guna2Button btnCocina;
        private Guna.UI2.WinForms.Guna2Button btnGestion;
        private Guna.UI2.WinForms.Guna2Button btnPedidos;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox panelContenedor;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private Guna.UI2.WinForms.Guna2Button btnAsistencia;
    }
}