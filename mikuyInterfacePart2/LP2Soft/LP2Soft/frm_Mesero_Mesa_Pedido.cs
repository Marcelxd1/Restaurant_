using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frm_Mesero_Mesa_Pedido : Form
    {
        private Estado _estado;
        private NegocioWS.mesa _mesa;
        private BindingList<NegocioWS.categoria> _listaCat;
        private BindingList<Button> lista_botones;
        private double suma = 0;
        private CajaWS.pedido _pedido;
        private BindingList<CajaWS.lineaPedido> lista_lineas;
        private NegocioWS.NegocioWSClient _daoNegocio;
        private CajaWS.CajaWSClient _daoCaja;

        private BindingList<NegocioWS.producto> _lista_prod;
        public frm_Mesero_Mesa_Pedido()
        {
            InitializeComponent();
            _mesa = new NegocioWS.mesa();
            _daoNegocio = new NegocioWS.NegocioWSClient();
            _lista_prod = new BindingList<NegocioWS.producto>();
            lista_lineas = new BindingList<CajaWS.lineaPedido>();
            _daoCaja = new CajaWS.CajaWSClient();

            dgvItem.AutoGenerateColumns = false;
            dgvPedido.AutoGenerateColumns = false;
            dgvItem.DataSource = _daoNegocio.listarTodosItemsXNombre("");
            panelCategorias.AutoScroll = true;
            txtTotal.Enabled = false;
            txtTotal.Text = "0.00";
            cargarCategorias();
        }

        public void obtenMesa(NegocioWS.mesa mesa)
        {
            _mesa = mesa;
        }

        private void cargarCategorias()
        {
            int top = 0;
            int left = 0;
            lista_botones = new BindingList<Button>();
            _listaCat = new BindingList<NegocioWS.categoria>();
            foreach (NegocioWS.categoria item in _daoNegocio.listarTodasCategorias())
            {
                _listaCat.Add(item);
                Button button = new Button();
                button.Size = new Size(145, 39);
                button.Left = left;
                button.Top = top;
                button.Text = item.nombre;
                button.Name = "btn_" + item.nombre;
                button.Font = new Font(btnBuscar.Font, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = System.Drawing.Color.FromArgb(16, 28, 67);
                button.Click += new System.EventHandler(hacerCLik);
                this.Controls.Add(button);
                left += button.Width + 4;
                if (left >= 413)
                {
                    left = 0;
                    top += button.Height + 4;
                }
                lista_botones.Add(button);
                panelCategorias.Controls.Add((Control)button);
            }

        }

        private void hacerCLik(object sender, EventArgs e)
        {
            char[] sep = new char[] { ' ' };
            string[] subs = sender.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            string name = subs[2];
            dgvItem.DataSource = _daoNegocio.listarProductoXCategoria(name);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = _daoNegocio.listarTodosItemsXNombre(txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            dgvPedido.Rows.Add(new string[] {
                Convert.ToString(dgvItem[0, dgvItem.CurrentRow.Index].Value),
                Convert.ToString(dgvItem[1, dgvItem.CurrentRow.Index].Value),
                Convert.ToString(dgvItem[2, dgvItem.CurrentRow.Index].Value),
                Convert.ToString(1)
            });
            CajaWS.lineaPedido line = new CajaWS.lineaPedido();
            NegocioWS.producto prod = (NegocioWS.producto)dgvItem.CurrentRow.DataBoundItem;
            line.item.nombre = prod.nombre;
            line.item.idItemVendible = prod.idItemVendible;
            line.item.precio = prod.precio;
            line.unidades = 1;
            line.subtotal = prod.precio;
            suma = suma + prod.precio;
            txtTotal.Text = suma.ToString();
        }

        private void dgvPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedido.Rows[e.RowIndex].DataBoundItem;
            if (line != null)
            {
                dgvPedido.Rows[e.RowIndex].Cells[0].Value = line.item.idItemVendible;
                dgvPedido.Rows[e.RowIndex].Cells[1].Value = line.item.nombre;
                dgvPedido.Rows[e.RowIndex].Cells[2].Value = line.item.precio;
                dgvPedido.Rows[e.RowIndex].Cells[3].Value = line.unidades;
            }
        }

        private void dgvItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            NegocioWS.itemVendible item = (NegocioWS.itemVendible)dgvItem.Rows[e.RowIndex].DataBoundItem;
            dgvItem.Rows[e.RowIndex].Cells[0].Value = item.idItemVendible;
            dgvItem.Rows[e.RowIndex].Cells[1].Value = item.nombre;
            dgvItem.Rows[e.RowIndex].Cells[2].Value = item.precio;
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if(dgvItem.CurrentRow != null)
            {
                CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedido.CurrentRow.DataBoundItem;
                suma = suma - line.unidades * line.item.precio;
                this.lista_lineas.Remove(line);
                txtTotal.Text = suma.ToString();
            }
        }

        private void calcularSub()
        {
            
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            _pedido = new CajaWS.pedido();
            
            _pedido.mesa.idMesa = this._mesa.idMesa;
            _pedido.mesa.disponible = false;
            _pedido.list_lineaPedido = this.lista_lineas.ToArray();
            if(_estado == Estado.Nuevo)
            {
                int resultado = _daoCaja.insertarPedido(_pedido);
                if(resultado != 0)
                {
                    this._pedido.idPedido = resultado;
                    this._estado = Estado.Guardar;
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                int resultado = _daoCaja.modificarPedido(_pedido);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado con exito", "Mensaje Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._estado = Estado.Guardar;
                }
                else MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




    }
}
