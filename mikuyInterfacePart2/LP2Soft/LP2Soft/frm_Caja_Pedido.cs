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
        private UserWS.UserWSClient _userWSClient;

        private CajaWS.CajaWSClient _cajaDao;
        private double total = 0.0;
        public frm_Caja_Pedido(CajaWS.pedido pedido, UserWS.persona cajero)
        {
            InitializeComponent();
            _pedido = pedido;
            _cliente = new UserWS.persona();
            _mesero = new UserWS.persona();
            _cajero = new UserWS.persona();
            cajeroOld = cajero;
            _userWSClient = new UserWS.UserWSClient();
            _cajaDao = new CajaWS.CajaWSClient();
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
                }
                else
                {
                    txtDNIRUC.Text = _cliente.ruc;
                    _pedido.cliente.ruc = _cliente.ruc;
                }
                txtNombre.Text = _cliente.nombre;
                _pedido.cliente.nombre = _cliente.nombre;
            }
            if (_pedido.mesero != null)
            {
                _mesero = _userWSClient.buscarPersonaPorIdUsuario(_pedido.mesero.id_persona);
                _pedido.mesero.nombre = _mesero.nombre;
            }
            if (_pedido.cajero != null)
            {
                _cajero = _userWSClient.buscarPersonaPorIdUsuario(_pedido.cajero.id_usuario);
                _pedido.cajero.nombre = _cajero.nombre;
            }
            else
            {
                _cajero = cajeroOld;
                _pedido.cajero.nombre = cajeroOld.nombre;
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
                dgvPedidos.Rows[e.RowIndex].Cells[3].Value = line.unidades * line.item.precio;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmBoleta formBol = new frmBoleta(_pedido);
            formBol.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente formBusquedaCliente = new frmBusquedaCliente();
            if (formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {
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

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            frmBoleta formBol = new frmBoleta(_pedido);
            formBol.Show();
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            double impor = 0;
            if (txtImporte.Text == "")
            {
                impor = 0;
            }
            else
            {
                impor = Double.Parse(txtImporte.Text);
            }
            impor -= total;
            txtVuelto.Text = impor.ToString("N2");
        }
    }
}
