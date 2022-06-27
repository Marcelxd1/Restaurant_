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
    public partial class frm_Caja_Pedido : Form
    {
        private CajaWS.pedido _pedido;
        private UserWS.persona _cliente;
        private UserWS.persona _mesero;
        private UserWS.persona _cajero;
        private UserWS.persona cajeroOld;
        private NegocioWS.mesa _mesa;
        private UserWS.UserWSClient _userWSClient;
        private NegocioWS.NegocioWSClient _negocioWSClient;
        private double impor = 0;
        private double vuelto = 0;
        private CajaWS.CajaWSClient _cajaDao;
        private double total = 0.0;
        public frm_Caja_Pedido(CajaWS.pedido pedido, UserWS.persona cajero)
        {
            InitializeComponent();
            _pedido = pedido;
            _cliente = new UserWS.persona();
            _mesero = new UserWS.persona();
            _cajero = new UserWS.persona();
            _mesa = new NegocioWS.mesa();
            cajeroOld = new UserWS.persona();
            cajeroOld = cajero;
            _userWSClient = new UserWS.UserWSClient();
            _cajaDao = new CajaWS.CajaWSClient();
            _negocioWSClient = new NegocioWS.NegocioWSClient();
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.DataSource = _pedido.list_lineaPedido;
            cargaComponentes();
        }

        private void cargaComponentes()
        {
            if (_pedido.cliente != null)
            {
                _cliente = _userWSClient.buscarPersonaPorIdUsuario(_pedido.cliente.id_persona);
                if (_cliente.tipo == 'N')
                {
                    txtDNIRUC.Text = _cliente.DNI;
                    _pedido.cliente.DNI = _cliente.DNI;
                    _pedido.cliente.apellido_paterno = _cliente.apellido_paterno;
                }
                else
                {
                    txtDNIRUC.Text = _cliente.ruc;
                    _pedido.cliente.ruc = _cliente.ruc;
                }
                txtNombre.Text = _cliente.nombre;
                _pedido.cliente.nombre = _cliente.nombre;
                _pedido.cliente.tipo = _cliente.tipo;
                
            }
            if (_pedido.mesero != null)
            {
                _mesero = _userWSClient.buscarPersonaPorIdUsuario(_pedido.mesero.id_usuario);
                _pedido.mesero.nombre = _mesero.nombre;
                _pedido.mesero.apellido_paterno= _mesero.apellido_paterno;
                _mesa = _negocioWSClient.buscaMesaXId(_pedido.mesa.idMesa);
            }
            if (cajeroOld != null)
            {
                _pedido.cajero = new CajaWS.usuario();
                _pedido.cajero.id_usuario = cajeroOld.id_persona;
                _pedido.cajero.nombre = cajeroOld.nombre;
                _pedido.cajero.apellido_paterno = cajeroOld.apellido_paterno;
                
            }
            
            foreach (CajaWS.lineaPedido line in _pedido.list_lineaPedido)
            {
                total += line.subtotal;
            }
            txtTotal.Text = total.ToString("N2");

        }

        private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedidos.Rows[e.RowIndex].DataBoundItem;
            if (line != null)
            {
                dgvPedidos.Rows[e.RowIndex].Cells[0].Value = line.item.nombre;
                dgvPedidos.Rows[e.RowIndex].Cells[2].Value = line.item.precio;
                dgvPedidos.Rows[e.RowIndex].Cells[1].Value = line.unidades;
                dgvPedidos.Rows[e.RowIndex].Cells[3].Value = line.subtotal;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rbnBoleta.Checked)
                _pedido.tipoComprobante = 'B';
            else
                _pedido.tipoComprobante = 'F';
            if (rbnEfectivo.Checked)
                _pedido.tipoPago = 'E';
            else
                _pedido.tipoPago = 'T';
            if (txtImporte.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el importe", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            frmBoleta formBol = new frmBoleta(_pedido,impor,vuelto);
            formBol.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente formBusquedaCliente = new frmBusquedaCliente();
            if (formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {
                string doc;
                _pedido.cliente = new CajaWS.persona();
                _pedido.cliente.id_persona = formBusquedaCliente.ClienteSeleccionado.id_persona;
                _pedido.cliente.nombre = formBusquedaCliente.ClienteSeleccionado.nombre;
                if (formBusquedaCliente.ClienteSeleccionado.tipo == 'N')
                {
                    doc = formBusquedaCliente.ClienteSeleccionado.DNI;
                    _pedido.cliente.DNI = doc;
                    _pedido.cliente.apellido_paterno = formBusquedaCliente.ClienteSeleccionado.apellido_paterno;
                }
                else { 
                    doc = formBusquedaCliente.ClienteSeleccionado.ruc;
                    _pedido.cliente.ruc = doc;
                }
                _pedido.cliente.tipo = formBusquedaCliente.ClienteSeleccionado.tipo;
                txtNombre.Text = _pedido.cliente.nombre;
                txtDNIRUC.Text = doc;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (rbnBoleta.Checked)
                _pedido.tipoComprobante = 'B';
            else
                _pedido.tipoComprobante = 'F';
            if (rbnEfectivo.Checked)
                _pedido.tipoPago = 'E';
            else
                _pedido.tipoPago = 'T';

            _mesa.disponible = true;
            _negocioWSClient.modificarMesa(_mesa);
            if (txtImporte.Text.Trim() == null)
            {
                MessageBox.Show("Debe ingresar un nombre", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int resultado = _cajaDao.RealizarPago(_pedido);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha realizado el pago con éxito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ha ocurrido un error", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pbCLiente_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar formClienteRegistro = new frm_Clientes_Registrar();
            formClienteRegistro.Dato = 1;
            if (formClienteRegistro.ShowDialog() == DialogResult.OK)
            {
                string doc;
                _pedido.cliente.id_persona = formClienteRegistro.ClienteSeleccionado.id_persona;
                _pedido.cliente.nombre = formClienteRegistro.ClienteSeleccionado.nombre;
                if (formClienteRegistro.ClienteSeleccionado.tipo == 'N')
                {
                    doc = formClienteRegistro.ClienteSeleccionado.DNI;
                    _pedido.cliente.DNI = doc;
                    _pedido.cliente.apellido_paterno = formClienteRegistro.ClienteSeleccionado.apellido_paterno;
                }
                else
                {
                    doc = formClienteRegistro.ClienteSeleccionado.ruc;
                    _pedido.cliente.ruc = doc;
                }
                _pedido.cliente.tipo = formClienteRegistro.ClienteSeleccionado.tipo;
                txtNombre.Text = _pedido.cliente.nombre;
                txtDNIRUC.Text = doc;
            }
            
        }

        
        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            
            if (txtImporte.Text == "")
            {
                impor = 0;
            }
            else
            {
                impor = Double.Parse(txtImporte.Text);
            }
            vuelto = impor - total;
            txtVuelto.Text = vuelto.ToString("N2");

        }

       
    }
}
