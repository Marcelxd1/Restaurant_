using LP2Soft.NegocioWS;
using LP2Soft.UserWS;
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
        private UserWS.persona _mesero;
        private UserWS.persona _cajero;
        private UserWS.persona _cliente;
        private bool hecho=false;


        private BindingList<NegocioWS.categoria> _listaCat;
        private BindingList<Button> lista_botones;
        private double suma = 0;
        private CajaWS.pedido _pedido;
        private BindingList<CajaWS.lineaPedido> lista_lineas;
        private BindingList<CajaWS.lineaPedido> lista_lineas_antigua;
        private NegocioWS.NegocioWSClient _daoNegocio;
        private CajaWS.CajaWSClient _daoCaja;
        private UserWS.UserWSClient _userWSClient;

        private BindingList<NegocioWS.producto> _lista_prod;

        public mesa Mesa { get => _mesa; set => _mesa = value; }
        public persona Mesero { get => _mesero; set => _mesero = value; }
        public bool Hecho { get => hecho; set => hecho = value; }
        public persona Cajero { get => _cajero; set => _cajero = value; }

        public frm_Mesero_Mesa_Pedido(Estado estado, int idMesa)
        {
            InitializeComponent();
            _pedido = new CajaWS.pedido();
            //_estado = Estado.Inicial;
            _daoNegocio = new NegocioWS.NegocioWSClient();
            _userWSClient = new UserWS.UserWSClient();
            _lista_prod = new BindingList<NegocioWS.producto>();
            lista_lineas = new BindingList<CajaWS.lineaPedido>();
            lista_lineas_antigua = new BindingList<CajaWS.lineaPedido>();
            _daoCaja = new CajaWS.CajaWSClient();
            _estado = estado;
            dgvItem.AutoGenerateColumns = false;
            dgvPedido.AutoGenerateColumns = false;
            dgvItem.DataSource = _daoNegocio.listarTodosItemsXNombre("");
            panelCategorias.AutoScroll = true;
            txtTotal.Enabled = false;
            txtTotal.Text = "0.00";
            cargarCategorias();
            establecerEstadoComponentes(idMesa);
            //seModifica();
        }

        public void establecerEstadoComponentes(int idMesa)
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnPedir.Text = "Pedir";
                    break;
                case Estado.Modificar:
                    btnPedir.Text = "Modificar";
                    cargarComponentes(idMesa);
                    break;
                case Estado.Nuevo:
                    break;

            }
        }

        void cargarComponentes(int idMesa)
        {

            _pedido = _daoCaja.BuscarPedidoXMesa(idMesa);
            //dgvPedido.DataSource = _daoCaja.listarLineaPXPedido(_pedido.idPedido);
            CajaWS.lineaPedido[] lineas = _daoCaja.listarLineaPXPedido(_pedido.idPedido);
            foreach(CajaWS.lineaPedido l in lineas)
            {
                lista_lineas.Add(l);
                suma += l.subtotal;
            }
            lista_lineas_antigua = lista_lineas;
            dgvPedido.DataSource = lista_lineas;
            dgvPedido.Refresh();
            if (_pedido.cliente != null)
            {
                _cliente = _userWSClient.buscarPersonaPorIdUsuario(_pedido.cliente.id_persona);
                txtNombre.Text = _cliente.nombre;
                if (_cliente.tipo == 'N')
                    txtDNIRUC.Text = _cliente.DNI;
                else
                    txtDNIRUC.Text = _cliente.ruc;
            }
            txtTotal.Text = suma.ToString("N2");
        }


        public void seModifica()
        {
            
            if(this._mesa.disponible == false)
            {
                _estado = Estado.Modificar;
                _pedido = _daoCaja.BuscarPedidoXMesa(_mesa.idMesa);
                //dgvPedido.DataSource = _pedido.list_lineaPedido;
            }
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
                button.Cursor = System.Windows.Forms.Cursors.Hand;
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
            NegocioWS.itemVendible prod = (NegocioWS.itemVendible)dgvItem.CurrentRow.DataBoundItem;
            int i = 0,n=0;
            if (lista_lineas != null)
            {
                foreach (CajaWS.lineaPedido linea in lista_lineas)
                {
                    if (linea.item.idItemVendible == prod.idItemVendible)
                    {
                        n = Convert.ToInt32(dgvPedido.Rows[i].Cells[3].Value);
                        dgvPedido.Rows[i].Cells[3].Value = n + 1;
                        linea.unidades = linea.unidades + 1;
                        linea.subtotal = linea.unidades * linea.item.precio;
                        suma += linea.item.precio;
                        txtTotal.Text =  suma.ToString("N2");
                        i++;
                        return;
                    }
                }
            }
            CajaWS.lineaPedido line = new CajaWS.lineaPedido();
            line.item = new CajaWS.itemVendible();
            line.item.idItemVendible = prod.idItemVendible;
            line.item.precio = prod.precio;
            line.unidades = 1;
            line.subtotal = prod.precio;
            line.item.nombre = prod.nombre;
            suma = suma + prod.precio;
            txtTotal.Text = suma.ToString("N2");
            lista_lineas.Add(line);
            dgvPedido.DataSource = lista_lineas;
            dgvPedido.Refresh();
        }

        private void dgvPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) 
        {
            try { 
                CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedido.Rows[e.RowIndex].DataBoundItem;
                if (line != null)
                {
                    dgvPedido.Rows[e.RowIndex].Cells[0].Value = line.item.idItemVendible;
                    dgvPedido.Rows[e.RowIndex].Cells[1].Value = line.item.nombre;
                    dgvPedido.Rows[e.RowIndex].Cells[2].Value = line.item.precio;
                    dgvPedido.Rows[e.RowIndex].Cells[3].Value = line.unidades;
                }
            }
            catch(Exception ex)
            {
                string error = ex.Message ;
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
                if(_estado == Estado.Inicial) { 
                    this.lista_lineas.Remove(line);
                }
                txtTotal.Text = suma.ToString("N2");
                //if(_estado == Estado.Modificar)
                //{
                //    int j = 0;
                //    int i = this.lista_lineas_antigua.IndexOf(line);
                //    foreach(CajaWS.lineaPedido l in this.lista_lineas)// Busco si linea esta en mi pedido anterior
                //    {
                //        if(line == l) //es un pedido anterior
                //        {
                //            this.lista_lineas[i].activo = false;
                //            j = 1;
                //            break;
                //        }
                //    }
                //    if(j==0)//producto nuevo
                //        this.lista_lineas.Remove(line);
                //}
            }
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            
            _pedido.restaurante = new CajaWS.restaurante();
            _pedido.restaurante.id_restaurante = 1;
            _pedido.list_lineaPedido = this.lista_lineas.ToArray();

            if (_mesero != null) {
                _pedido.mesero = new CajaWS.usuario();
                _pedido.mesero.id_usuario = _mesero.id_persona;

                _pedido.mesa = new CajaWS.mesa();
                _pedido.mesa.idMesa = _mesa.idMesa;
                _pedido.mesa.disponible = false;
            }

            if (_cajero != null)
            {
                _pedido.cajero = new CajaWS.usuario();
                _pedido.cajero.id_usuario = _cajero.id_persona;
            }

            if (_cliente != null)
            {
                _pedido.cliente = new CajaWS.persona();
                _pedido.cliente.id_persona = _cliente.id_persona;
            }
            _pedido.total = suma;
            _pedido.fecha = DateTime.Now;
            _pedido.fechaSpecified = true;
            
            
            
            if (_estado == Estado.Inicial)
            {
                int resultado = _daoCaja.insertarPedido(_pedido);
                if (resultado != 0)
                {
                    this._pedido.idPedido = resultado;
                    this._estado = Estado.Guardar;
                    this.hecho = true;
                    MessageBox.Show("Se ha registrado con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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
                    this.hecho=true;
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
                lista_lineas[dgvPedido.CurrentRow.Index].unidades = n+1;
                lista_lineas[dgvPedido.CurrentRow.Index].subtotal = 
                    (n+1)*lista_lineas[dgvPedido.CurrentRow.Index].subtotal/n ;
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
                    
                    this.lista_lineas.Remove(line);
                    if (_estado == Estado.Modificar)
                    {
                        int i = this.lista_lineas.IndexOf(line);
                        this.lista_lineas[i].activo = false;
                    }
                }

            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.hecho = false;
            this.Close();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente formBusquedaCliente = new frmBusquedaCliente();
            if(formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {
                _cliente = new UserWS.persona();
                string doc;
                _cliente.id_persona = formBusquedaCliente.ClienteSeleccionado.id_persona;
                _cliente.nombre = formBusquedaCliente.ClienteSeleccionado.nombre;
                if (formBusquedaCliente.ClienteSeleccionado.tipo == 'N')
                    doc = formBusquedaCliente.ClienteSeleccionado.DNI;
                else
                    doc = formBusquedaCliente.ClienteSeleccionado.ruc;
                txtNombre.Text = _cliente.nombre;
                txtDNIRUC.Text = doc;
            }

        }

        private void pbCLiente_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar formClienteRegistro = new frm_Clientes_Registrar();
            formClienteRegistro.Dato = 1;
            if (formClienteRegistro.ShowDialog() == DialogResult.OK)
            {
                string doc;
                _cliente.id_persona = formClienteRegistro.ClienteSeleccionado.id_persona;
                _cliente.nombre = formClienteRegistro.ClienteSeleccionado.nombre;
                if (formClienteRegistro.ClienteSeleccionado.tipo == 'N')
                    doc = formClienteRegistro.ClienteSeleccionado.DNI;
                else
                    doc = formClienteRegistro.ClienteSeleccionado.ruc;
                txtNombre.Text = _cliente.nombre;
                txtDNIRUC.Text = doc;
            }
        }
    }
}