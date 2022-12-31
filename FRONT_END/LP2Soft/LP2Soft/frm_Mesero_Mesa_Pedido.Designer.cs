namespace LP2Soft
{
    partial class frm_Mesero_Mesa_Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mesero_Mesa_Pedido));
            this.panelCategorias = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NombreT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPedido = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDNIRUC = new System.Windows.Forms.Label();
            this.txtDNIRUC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSumar = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.btnRestar = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscaCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedir = new Guna.UI2.WinForms.Guna2Button();
            this.pbCLiente = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEliminarProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeleccionar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLiente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCategorias
            // 
            this.panelCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.panelCategorias.Location = new System.Drawing.Point(11, 111);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.ShadowDecoration.Parent = this.panelCategorias;
            this.panelCategorias.Size = new System.Drawing.Size(99, 466);
            this.panelCategorias.TabIndex = 128;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderColor = System.Drawing.Color.DimGray;
            this.txtTotal.BorderRadius = 10;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(325, 503);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(134, 37);
            this.txtTotal.TabIndex = 136;
            this.txtTotal.IconRightClick += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(217, 512);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 25);
            this.lblTotal.TabIndex = 137;
            this.lblTotal.Text = "Total: S/";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItem.ColumnHeadersHeight = 26;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreT,
            this.PrecioT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItem.EnableHeadersVisualStyles = false;
            this.dgvItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItem.Location = new System.Drawing.Point(121, 87);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(385, 490);
            this.dgvItem.TabIndex = 139;
            this.dgvItem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvItem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvItem.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvItem.ThemeStyle.ReadOnly = false;
            this.dgvItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvItem.ThemeStyle.RowsStyle.Height = 22;
            this.dgvItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvItem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItem_CellFormatting);
            // 
            // NombreT
            // 
            this.NombreT.DataPropertyName = "Nombre";
            this.NombreT.FillWeight = 195.4495F;
            this.NombreT.HeaderText = "Nombre";
            this.NombreT.Name = "NombreT";
            this.NombreT.ReadOnly = true;
            // 
            // PrecioT
            // 
            this.PrecioT.DataPropertyName = "Precio";
            this.PrecioT.FillWeight = 66.47942F;
            this.PrecioT.HeaderText = "Precio";
            this.PrecioT.Name = "PrecioT";
            this.PrecioT.ReadOnly = true;
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.BackgroundColor = System.Drawing.Color.White;
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedido.ColumnHeadersHeight = 24;
            this.dgvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Cantidad});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPedido.EnableHeadersVisualStyles = false;
            this.dgvPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedido.Location = new System.Drawing.Point(11, 219);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(450, 277);
            this.dgvPedido.TabIndex = 140;
            this.dgvPedido.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPedido.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedido.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPedido.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPedido.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPedido.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPedido.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedido.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedido.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvPedido.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedido.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvPedido.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedido.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPedido.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvPedido.ThemeStyle.ReadOnly = true;
            this.dgvPedido.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedido.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedido.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPedido.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedido.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPedido.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedido.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPedido_CellFormatting);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.FillWeight = 192.9873F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.FillWeight = 67.61208F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 88.63924F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(48, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 142;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderRadius = 10;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.Parent = this.txtNombre;
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedState.Parent = this.txtNombre;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.HoverState.Parent = this.txtNombre;
            this.txtNombre.Location = new System.Drawing.Point(120, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.SelectedText = "";
            this.txtNombre.ShadowDecoration.Parent = this.txtNombre;
            this.txtNombre.Size = new System.Drawing.Size(218, 37);
            this.txtNombre.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 144;
            this.label2.Text = "Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDNIRUC
            // 
            this.lblDNIRUC.AutoSize = true;
            this.lblDNIRUC.BackColor = System.Drawing.Color.White;
            this.lblDNIRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIRUC.ForeColor = System.Drawing.Color.Black;
            this.lblDNIRUC.Location = new System.Drawing.Point(29, 126);
            this.lblDNIRUC.Name = "lblDNIRUC";
            this.lblDNIRUC.Size = new System.Drawing.Size(84, 20);
            this.lblDNIRUC.TabIndex = 146;
            this.lblDNIRUC.Text = "DNI / RUC";
            this.lblDNIRUC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDNIRUC
            // 
            this.txtDNIRUC.BackColor = System.Drawing.Color.White;
            this.txtDNIRUC.BorderColor = System.Drawing.Color.DimGray;
            this.txtDNIRUC.BorderRadius = 10;
            this.txtDNIRUC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNIRUC.DefaultText = "";
            this.txtDNIRUC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNIRUC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNIRUC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIRUC.DisabledState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIRUC.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDNIRUC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIRUC.FocusedState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIRUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDNIRUC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIRUC.HoverState.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Location = new System.Drawing.Point(120, 117);
            this.txtDNIRUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNIRUC.Multiline = true;
            this.txtDNIRUC.Name = "txtDNIRUC";
            this.txtDNIRUC.PasswordChar = '\0';
            this.txtDNIRUC.PlaceholderText = "";
            this.txtDNIRUC.ReadOnly = true;
            this.txtDNIRUC.SelectedText = "";
            this.txtDNIRUC.ShadowDecoration.Parent = this.txtDNIRUC;
            this.txtDNIRUC.Size = new System.Drawing.Size(218, 37);
            this.txtDNIRUC.TabIndex = 147;
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.Transparent;
            this.btnSumar.BorderColor = System.Drawing.Color.Transparent;
            this.btnSumar.CheckedState.Parent = this.btnSumar;
            this.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumar.CustomImages.Parent = this.btnSumar;
            this.btnSumar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(39)))), ((int)(((byte)(232)))));
            this.btnSumar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.ForeColor = System.Drawing.Color.White;
            this.btnSumar.HoverState.Parent = this.btnSumar;
            this.btnSumar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSumar.Location = new System.Drawing.Point(6, 170);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.PressedColor = System.Drawing.Color.MediumPurple;
            this.btnSumar.ShadowDecoration.BorderRadius = 15;
            this.btnSumar.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnSumar.ShadowDecoration.Enabled = true;
            this.btnSumar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSumar.ShadowDecoration.Parent = this.btnSumar;
            this.btnSumar.Size = new System.Drawing.Size(38, 38);
            this.btnSumar.TabIndex = 152;
            this.btnSumar.Text = "+";
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestar.BorderColor = System.Drawing.Color.Transparent;
            this.btnRestar.CheckedState.Parent = this.btnRestar;
            this.btnRestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestar.CustomImages.Parent = this.btnRestar;
            this.btnRestar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(39)))), ((int)(((byte)(232)))));
            this.btnRestar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(90)))), ((int)(((byte)(207)))));
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.ForeColor = System.Drawing.Color.White;
            this.btnRestar.HoverState.Parent = this.btnRestar;
            this.btnRestar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRestar.Location = new System.Drawing.Point(52, 170);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.PressedColor = System.Drawing.Color.MediumPurple;
            this.btnRestar.ShadowDecoration.BorderRadius = 15;
            this.btnRestar.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.btnRestar.ShadowDecoration.Enabled = true;
            this.btnRestar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRestar.ShadowDecoration.Parent = this.btnRestar;
            this.btnRestar.Size = new System.Drawing.Size(38, 38);
            this.btnRestar.TabIndex = 153;
            this.btnRestar.Text = "-";
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnBuscaCliente);
            this.groupBox3.Controls.Add(this.txtDNIRUC);
            this.groupBox3.Controls.Add(this.lblNombre);
            this.groupBox3.Controls.Add(this.btnSumar);
            this.groupBox3.Controls.Add(this.btnRestar);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnPedir);
            this.groupBox3.Controls.Add(this.dgvPedido);
            this.groupBox3.Controls.Add(this.pbCLiente);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.lblDNIRUC);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox3.Location = new System.Drawing.Point(606, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 604);
            this.groupBox3.TabIndex = 154;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedidos";
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
            this.btnBuscaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscaCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCliente.HoverState.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Image = global::LP2Soft.Properties.Resources.lupa1;
            this.btnBuscaCliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.ImageSize = new System.Drawing.Size(22, 22);
            this.btnBuscaCliente.Location = new System.Drawing.Point(349, 119);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.PressedColor = System.Drawing.Color.Red;
            this.btnBuscaCliente.ShadowDecoration.Parent = this.btnBuscaCliente;
            this.btnBuscaCliente.Size = new System.Drawing.Size(110, 35);
            this.btnBuscaCliente.TabIndex = 154;
            this.btnBuscaCliente.Text = "Buscar";
            this.btnBuscaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // btnPedir
            // 
            this.btnPedir.BackColor = System.Drawing.Color.Transparent;
            this.btnPedir.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnPedir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedir.BorderRadius = 10;
            this.btnPedir.CheckedState.Parent = this.btnPedir;
            this.btnPedir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedir.CustomImages.Parent = this.btnPedir;
            this.btnPedir.FillColor = System.Drawing.Color.Transparent;
            this.btnPedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPedir.ForeColor = System.Drawing.Color.White;
            this.btnPedir.HoverState.Parent = this.btnPedir;
            this.btnPedir.Image = global::LP2Soft.Properties.Resources.listo;
            this.btnPedir.Location = new System.Drawing.Point(321, 557);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.PressedColor = System.Drawing.Color.Red;
            this.btnPedir.ShadowDecoration.BorderRadius = 0;
            this.btnPedir.ShadowDecoration.Parent = this.btnPedir;
            this.btnPedir.Size = new System.Drawing.Size(140, 35);
            this.btnPedir.TabIndex = 150;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.TextOffset = new System.Drawing.Point(3, 0);
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // pbCLiente
            // 
            this.pbCLiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCLiente.Image = global::LP2Soft.Properties.Resources.agregar_usuario;
            this.pbCLiente.Location = new System.Drawing.Point(366, 41);
            this.pbCLiente.Name = "pbCLiente";
            this.pbCLiente.Size = new System.Drawing.Size(68, 72);
            this.pbCLiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCLiente.TabIndex = 145;
            this.pbCLiente.TabStop = false;
            this.pbCLiente.Click += new System.EventHandler(this.pbCLiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::LP2Soft.Properties.Resources.cancelar;
            this.btnCancelar.ImageSize = new System.Drawing.Size(17, 17);
            this.btnCancelar.Location = new System.Drawing.Point(164, 557);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PressedColor = System.Drawing.Color.Red;
            this.btnCancelar.ShadowDecoration.BorderRadius = 0;
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(140, 35);
            this.btnCancelar.TabIndex = 149;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextOffset = new System.Drawing.Point(3, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.dgvItem);
            this.groupBox1.Controls.Add(this.panelCategorias);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 604);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 155;
            this.label1.Text = "Categorías";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscar.BorderRadius = 10;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.Parent = this.txtBuscar;
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedState.Parent = this.txtBuscar;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.HoverState.Parent = this.txtBuscar;
            this.txtBuscar.IconRight = global::LP2Soft.Properties.Resources.Buscar;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.Location = new System.Drawing.Point(10, 37);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.ShadowDecoration.Parent = this.txtBuscar;
            this.txtBuscar.Size = new System.Drawing.Size(502, 33);
            this.txtBuscar.TabIndex = 126;
            this.txtBuscar.IconRightClick += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnEliminarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarProd.BorderRadius = 10;
            this.btnEliminarProd.CheckedState.Parent = this.btnEliminarProd;
            this.btnEliminarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProd.CustomImages.Parent = this.btnEliminarProd;
            this.btnEliminarProd.FillColor = System.Drawing.Color.Transparent;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProd.HoverState.Parent = this.btnEliminarProd;
            this.btnEliminarProd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnEliminarProd.Location = new System.Drawing.Point(550, 350);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.ShadowDecoration.Parent = this.btnEliminarProd;
            this.btnEliminarProd.Size = new System.Drawing.Size(49, 38);
            this.btnEliminarProd.TabIndex = 131;
            this.btnEliminarProd.Text = "<<";
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImage = global::LP2Soft.Properties.Resources.foni;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.BorderColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BorderRadius = 10;
            this.btnSeleccionar.CheckedState.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.CustomBorderThickness = new System.Windows.Forms.Padding(25);
            this.btnSeleccionar.CustomImages.Parent = this.btnSeleccionar;
            this.btnSeleccionar.FillColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.HoverState.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Location = new System.Drawing.Point(548, 290);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ShadowDecoration.Parent = this.btnSeleccionar;
            this.btnSeleccionar.Size = new System.Drawing.Size(49, 38);
            this.btnSeleccionar.TabIndex = 130;
            this.btnSeleccionar.Text = ">>";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(1109, 641);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 124;
            this.guna2PictureBox3.TabStop = false;
            // 
            // frm_Mesero_Mesa_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1105, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.guna2PictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_Mesero_Mesa_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos de mesa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLiente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private Guna.UI2.WinForms.Guna2Panel panelCategorias;
        private Guna.UI2.WinForms.Guna2Button btnSeleccionar;
        private Guna.UI2.WinForms.Guna2Button btnEliminarProd;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2DataGridView dgvItem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPedido;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCLiente;
        private System.Windows.Forms.Label lblDNIRUC;
        private Guna.UI2.WinForms.Guna2TextBox txtDNIRUC;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnPedir;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnSumar;
        private Guna.UI2.WinForms.Guna2GradientCircleButton btnRestar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnBuscaCliente;
        private System.Windows.Forms.Label label1;
    }
}
