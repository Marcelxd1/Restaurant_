namespace LP2Soft
{
    partial class frmBusquedaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListarClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBuscaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionar = new Guna.UI2.WinForms.Guna2Button();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(-5, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(833, 340);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 125;
            this.guna2PictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 129;
            this.label2.Text = "Ingrese el cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.AllowUserToAddRows = false;
            this.dgvListarClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarClientes.ColumnHeadersHeight = 20;
            this.dgvListarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.DNIRUC,
            this.Username});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarClientes.EnableHeadersVisualStyles = false;
            this.dgvListarClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.Location = new System.Drawing.Point(21, 56);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.ReadOnly = true;
            this.dgvListarClientes.RowHeadersVisible = false;
            this.dgvListarClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarClientes.Size = new System.Drawing.Size(781, 231);
            this.dgvListarClientes.TabIndex = 131;
            this.dgvListarClientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListarClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListarClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListarClientes.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvListarClientes.ThemeStyle.ReadOnly = true;
            this.dgvListarClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListarClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListarClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListarClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListarClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListarClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvListarClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListarClientes_CellFormatting);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "Buscar";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.Parent = this.txtBuscar;
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedState.Parent = this.txtBuscar;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.HoverState.Parent = this.txtBuscar;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.Location = new System.Drawing.Point(176, 19);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionStart = 6;
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(460, 30);
            this.txtBuscar.TabIndex = 132;
            this.txtBuscar.IconRightClick += new System.EventHandler(this.txtBuscar_IconRightClick);
            this.txtBuscar.DoubleClick += new System.EventHandler(this.txtBuscar_DoubleClick);
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
            this.btnBuscaCliente.Location = new System.Drawing.Point(678, 19);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.PressedColor = System.Drawing.Color.Red;
            this.btnBuscaCliente.ShadowDecoration.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Size = new System.Drawing.Size(115, 32);
            this.btnBuscaCliente.TabIndex = 156;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.Click += new System.EventHandler(this.txtBuscar_IconRightClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.BackgroundImage")));
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.BorderRadius = 10;
            this.btnSeleccionar.CheckedState.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.CustomImages.Parent = this.btnSeleccionar;
            this.btnSeleccionar.FillColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.HoverState.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Image = global::LP2Soft.Properties.Resources.listo;
            this.btnSeleccionar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeleccionar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSeleccionar.Location = new System.Drawing.Point(669, 293);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.PressedColor = System.Drawing.Color.Red;
            this.btnSeleccionar.ShadowDecoration.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Size = new System.Drawing.Size(138, 33);
            this.btnSeleccionar.TabIndex = 157;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 84.7323F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // DNIRUC
            // 
            this.DNIRUC.FillWeight = 69.81967F;
            this.DNIRUC.HeaderText = "DNI/RUC";
            this.DNIRUC.Name = "DNIRUC";
            this.DNIRUC.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.FillWeight = 120.7118F;
            this.Username.HeaderText = "Nombre Completo";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 347);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvListarClientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBusquedaCliente";
            this.Text = "Busqueda de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListarClientes;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Button btnBuscaCliente;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}