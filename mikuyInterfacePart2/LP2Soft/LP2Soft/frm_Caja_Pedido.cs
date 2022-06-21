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
        public frm_Caja_Pedido(CajaWS.pedido pedido)
        {
            InitializeComponent();
            _pedido = pedido;
            _cliente = new UserWS.persona();
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.DataSource = _pedido.list_lineaPedido;
        }

        

        private void dgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CajaWS.lineaPedido line = (CajaWS.lineaPedido)dgvPedidos.Rows[e.RowIndex].DataBoundItem;
            if (line != null)
            {
                dgvPedidos.Rows[e.RowIndex].Cells[0].Value = line.item.nombre;
                dgvPedidos.Rows[e.RowIndex].Cells[2].Value = line.item.precio;
                dgvPedidos.Rows[e.RowIndex].Cells[1].Value = line.unidades;
                dgvPedidos.Rows[e.RowIndex].Cells[3].Value = line.unidades*line.item.precio;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmBoleta formBol = new frmBoleta(_pedido.idPedido);
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
            frmBoleta formBol = new frmBoleta(_pedido.idPedido);
            formBol.Show();
        }
    }
}
