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
            _estado = Estado.Nuevo;
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
            mesa = new NegocioWS.mesa();
            this._mesa = mesa;

            //pedidos
            //this._pedido = pedido;
            //lista_lineas = pedido.list_lineaPedido();
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
                button.FlatAppearance.BorderSize = 0; //FromArgb(16, 28, 67)
                button.BackColor = System.Drawing.Color.Black;
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
            NegocioWS.itemVendible prod = (NegocioWS.itemVendible)dgvItem.CurrentRow.DataBoundItem;
            line.item = new CajaWS.itemVendible();
            line.item.idItemVendible = prod.idItemVendible;
            line.item.precio = prod.precio;
            line.unidades = 1;
            line.subtotal = prod.precio;
            line.item.nombre = prod.nombre;
            suma = suma + prod.precio;
            txtTotal.Text = suma.ToString("N2");
            lista_lineas.Add(line);
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
            if (dgvPedido.CurrentRow != null)
            {
                int cant = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value);
                double precio = Convert.ToDouble(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[2].Value);
                CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedido.CurrentRow.DataBoundItem;
                suma = suma - cant * precio;
                dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                this.lista_lineas.Remove(line);
                txtTotal.Text = suma.ToString("N2");
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            _pedido = new CajaWS.pedido();
            _pedido.mesa = new CajaWS.mesa();
            _pedido.restaurante = new CajaWS.restaurante();
            _pedido.mesero = new CajaWS.usuario();
            _pedido.mesero.id_usuario = 4;
            _pedido.cajero = new CajaWS.usuario();
            _pedido.cajero.id_usuario = 5;
            _pedido.cliente = new CajaWS.persona();
            _pedido.cliente.id_persona = 2;
            _pedido.restaurante.id_restaurante = 1;
            _pedido.mesa.idMesa = 26;
            _pedido.mesa.disponible = false;
            _pedido.total = suma;
            _pedido.fecha = DateTime.Now;
            _pedido.fechaSpecified = true;
            _pedido.list_lineaPedido = this.lista_lineas.ToArray();
            _pedido.tipoComprobante = 'B';
            _pedido.tipoPago = 'E';
            _pedido.tipoPedido = 'C';
            _pedido.numeroComprobante = 23234234;
            _pedido.estado = 'E';
            _pedido.tipo = 'P';
            if (_estado == Estado.Nuevo)
            {
                int resultado = _daoCaja.insertarPedido(_pedido);
                if (resultado != 0)
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

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n;
            if(dgvPedido.CurrentRow != null)
            {
                n = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value);
                dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value = n + 1;

                suma += Convert.ToDouble(dgvPedido[2, dgvPedido.CurrentRow.Index].Value);
                txtTotal.Text = suma.ToString("N2");
                lista_lineas[dgvPedido.CurrentRow.Index].unidades = n;
                lista_lineas[dgvPedido.CurrentRow.Index].subtotal = suma;
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int n;
            if(dgvPedido.CurrentRow != null)
            {
                CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedido.CurrentRow.DataBoundItem;
                n = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value);
                
                dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value = n - 1;

                suma -= Convert.ToDouble(dgvPedido[2, dgvPedido.CurrentRow.Index].Value);
                txtTotal.Text = suma.ToString("N2");
                if (n-1 == 0)
                {
                    dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
                    this.lista_lineas.Remove(line);
                }

            }
            
        }
    }
}