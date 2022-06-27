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
    public partial class frm_Cajero_Pedidos : Form
    {
        private CajaWS.CajaWSClient daoCaja;
        private UserWS.persona _cajero;
        public frm_Cajero_Pedidos(UserWS.persona persona, UserWS.rol rol)
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();
            panelContenedor.Controls.Clear();
            CajaWS.pedido[] pedidos = daoCaja.listarPedidosNoPagados();
            _cajero = persona;
            if (pedidos != null)
            {
                BindingList<CajaWS.pedido> pedidosBL = new BindingList<CajaWS.pedido>(pedidos);
                lblNotificacion.Visible = false;
                foreach (CajaWS.pedido pedido in pedidosBL)
                {
                    frm_Cajero_Pedidos_Mesa formCajeroPedidos = new frm_Cajero_Pedidos_Mesa(pedido,_cajero);
                    formCajeroPedidos.Dock = DockStyle.Left;
                    formCajeroPedidos.TopLevel = false;
                    panelContenedor.Controls.Add(formCajeroPedidos);
                    formCajeroPedidos.Visible = true;
                }
            }
            else
            {
                lblNotificacion.Visible = true;
                lblNotificacion.Text = "TODOS LOS PEDIDOS HAN SIDO PAGADOS !";
                panelContenedor.Controls.Add(lblNotificacion);

            }
        }

        private void btnLlevar_Click(object sender, EventArgs e)
        {
            frm_Mesero_Mesa_Pedido forPedMes = new frm_Mesero_Mesa_Pedido(Estado.Inicial,0);
            forPedMes.Cajero = _cajero;
            forPedMes.ShowDialog();
        }
    }
}
