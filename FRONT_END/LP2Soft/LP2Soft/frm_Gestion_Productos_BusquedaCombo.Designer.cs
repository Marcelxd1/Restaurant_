﻿namespace LP2Soft
{
    partial class frm_Gestion_Productos_BusquedaCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Gestion_Productos_BusquedaCombo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarCombo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dgvCombos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.lblCombos = new System.Windows.Forms.Label();
            this.btnBuscaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCombo
            // 
            this.txtBuscarCombo.BackColor = System.Drawing.Color.White;
            this.txtBuscarCombo.BorderRadius = 10;
            this.txtBuscarCombo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtBuscarCombo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCombo.DefaultText = "Inserte nombre";
            this.txtBuscarCombo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCombo.DisabledState.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCombo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscarCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCombo.FocusedState.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCombo.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCombo.HoverState.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarCombo.Location = new System.Drawing.Point(22, 95);
            this.txtBuscarCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarCombo.Name = "txtBuscarCombo";
            this.txtBuscarCombo.PasswordChar = '\0';
            this.txtBuscarCombo.PlaceholderText = "";
            this.txtBuscarCombo.SelectedText = "";
            this.txtBuscarCombo.SelectionStart = 14;
            this.txtBuscarCombo.ShadowDecoration.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.Size = new System.Drawing.Size(411, 32);
            this.txtBuscarCombo.TabIndex = 42;
            this.txtBuscarCombo.IconRightClick += new System.EventHandler(this.txtBuscarCombo_IconRightClick);
            this.txtBuscarCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(-6, -3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(902, 580);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 44;
            this.guna2PictureBox3.TabStop = false;
            // 
            // dgvCombos
            // 
            this.dgvCombos.AllowUserToAddRows = false;
            this.dgvCombos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvCombos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCombos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCombos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCombos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCombos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCombos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCombos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCombos.ColumnHeadersHeight = 27;
            this.dgvCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Descripcion});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCombos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCombos.EnableHeadersVisualStyles = false;
            this.dgvCombos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCombos.Location = new System.Drawing.Point(22, 181);
            this.dgvCombos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCombos.Name = "dgvCombos";
            this.dgvCombos.ReadOnly = true;
            this.dgvCombos.RowHeadersVisible = false;
            this.dgvCombos.RowHeadersWidth = 51;
            this.dgvCombos.RowTemplate.Height = 24;
            this.dgvCombos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombos.Size = new System.Drawing.Size(694, 367);
            this.dgvCombos.TabIndex = 0;
            this.dgvCombos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCombos.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCombos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCombos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvCombos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCombos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvCombos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCombos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCombos.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvCombos.ThemeStyle.ReadOnly = true;
            this.dgvCombos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCombos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCombos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCombos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCombos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCombos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCombos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.FillWeight = 113.0288F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 200;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.DataPropertyName = "precio";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle7;
            this.Precio.FillWeight = 113.0288F;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 90;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 90;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.FillWeight = 113.0288F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.BorderColor = System.Drawing.Color.Transparent;
            this.btnModify.BorderRadius = 10;
            this.btnModify.CheckedState.Parent = this.btnModify;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.CustomImages.Parent = this.btnModify;
            this.btnModify.FillColor = System.Drawing.Color.Transparent;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.HoverState.Parent = this.btnModify;
            this.btnModify.Image = global::LP2Soft.Properties.Resources.edit;
            this.btnModify.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModify.ImageSize = new System.Drawing.Size(28, 25);
            this.btnModify.Location = new System.Drawing.Point(721, 232);
            this.btnModify.Name = "btnModify";
            this.btnModify.PressedColor = System.Drawing.Color.Red;
            this.btnModify.ShadowDecoration.Parent = this.btnModify;
            this.btnModify.Size = new System.Drawing.Size(149, 45);
            this.btnModify.TabIndex = 47;
            this.btnModify.Text = "Modificar";
            this.btnModify.TextOffset = new System.Drawing.Point(10, 0);
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BorderRadius = 10;
            this.btnNuevo.CheckedState.Parent = this.btnNuevo;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.CustomImages.Parent = this.btnNuevo;
            this.btnNuevo.FillColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.HoverState.Parent = this.btnNuevo;
            this.btnNuevo.Image = global::LP2Soft.Properties.Resources._new;
            this.btnNuevo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNuevo.ImageSize = new System.Drawing.Size(28, 25);
            this.btnNuevo.Location = new System.Drawing.Point(721, 181);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.PressedColor = System.Drawing.Color.Red;
            this.btnNuevo.ShadowDecoration.Parent = this.btnNuevo;
            this.btnNuevo.Size = new System.Drawing.Size(149, 45);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextOffset = new System.Drawing.Point(10, 0);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderRadius = 10;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::LP2Soft.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEliminar.ImageSize = new System.Drawing.Size(28, 25);
            this.btnEliminar.Location = new System.Drawing.Point(721, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedColor = System.Drawing.Color.Red;
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(149, 45);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextOffset = new System.Drawing.Point(10, 0);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCombos
            // 
            this.lblCombos.AutoSize = true;
            this.lblCombos.BackColor = System.Drawing.Color.White;
            this.lblCombos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombos.Location = new System.Drawing.Point(16, 16);
            this.lblCombos.Name = "lblCombos";
            this.lblCombos.Size = new System.Drawing.Size(264, 31);
            this.lblCombos.TabIndex = 48;
            this.lblCombos.Text = "Listado de Combos";
            this.lblCombos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscaCliente.BackgroundImage")));
            this.btnBuscaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaCliente.BorderRadius = 10;
            this.btnBuscaCliente.CheckedState.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaCliente.CustomImages.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.FillColor = System.Drawing.Color.Transparent;
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCliente.HoverState.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Image = global::LP2Soft.Properties.Resources.lupa1;
            this.btnBuscaCliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.ImageSize = new System.Drawing.Size(22, 22);
            this.btnBuscaCliente.Location = new System.Drawing.Point(481, 95);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.PressedColor = System.Drawing.Color.Red;
            this.btnBuscaCliente.ShadowDecoration.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Size = new System.Drawing.Size(115, 37);
            this.btnBuscaCliente.TabIndex = 156;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.Click += new System.EventHandler(this.txtBuscarCombo_IconRightClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 160;
            this.label3.Text = "Lista de combos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 159;
            this.label4.Text = "Búsqueda de combos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Gestion_Productos_BusquedaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.lblCombos);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvCombos);
            this.Controls.Add(this.txtBuscarCombo);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Gestion_Productos_BusquedaCombo";
            this.Text = "Busqueda de combos";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCombo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCombos;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private System.Windows.Forms.Label lblCombos;
        private Guna.UI2.WinForms.Guna2Button btnBuscaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}