namespace LP2Soft
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCombos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new Guna.UI2.WinForms.Guna2Button();
            this.txtBuscarCombo = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCombos
            // 
            this.dgvCombos.AllowUserToAddRows = false;
            this.dgvCombos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCombos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCombos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCombos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCombos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCombos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCombos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCombos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCombos.ColumnHeadersHeight = 27;
            this.dgvCombos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Precio});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCombos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCombos.EnableHeadersVisualStyles = false;
            this.dgvCombos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCombos.Location = new System.Drawing.Point(36, 53);
            this.dgvCombos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCombos.Name = "dgvCombos";
            this.dgvCombos.ReadOnly = true;
            this.dgvCombos.RowHeadersVisible = false;
            this.dgvCombos.RowHeadersWidth = 51;
            this.dgvCombos.RowTemplate.Height = 24;
            this.dgvCombos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombos.Size = new System.Drawing.Size(530, 273);
            this.dgvCombos.TabIndex = 0;
            this.dgvCombos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCombos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCombos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCombos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCombos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCombos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCombos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
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
            // ID
            // 
            this.ID.DataPropertyName = "idItemVendible";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.CheckedState.Parent = this.btnSeleccionar;
            this.btnSeleccionar.CustomImages.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.HoverState.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Location = new System.Drawing.Point(430, 10);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ShadowDecoration.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Size = new System.Drawing.Size(135, 37);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscarCombo
            // 
            this.txtBuscarCombo.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscarCombo.BorderColor = System.Drawing.Color.Transparent;
            this.txtBuscarCombo.BorderRadius = 10;
            this.txtBuscarCombo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtBuscarCombo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCombo.DefaultText = "";
            this.txtBuscarCombo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCombo.DisabledState.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtBuscarCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCombo.FocusedState.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCombo.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCombo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCombo.HoverState.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.IconRight = global::LP2Soft.Properties.Resources.Buscar;
            this.txtBuscarCombo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarCombo.Location = new System.Drawing.Point(48, 10);
            this.txtBuscarCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarCombo.Name = "txtBuscarCombo";
            this.txtBuscarCombo.PasswordChar = '\0';
            this.txtBuscarCombo.PlaceholderText = "";
            this.txtBuscarCombo.SelectedText = "";
            this.txtBuscarCombo.ShadowDecoration.Parent = this.txtBuscarCombo;
            this.txtBuscarCombo.Size = new System.Drawing.Size(205, 32);
            this.txtBuscarCombo.TabIndex = 42;
            this.txtBuscarCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // frm_Gestion_Productos_BusquedaCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtBuscarCombo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvCombos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Gestion_Productos_BusquedaCombo";
            this.Text = "Busqueda de combos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCombos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCombo;
    }
}