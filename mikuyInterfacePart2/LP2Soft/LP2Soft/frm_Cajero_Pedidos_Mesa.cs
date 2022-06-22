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
    public partial class frm_Cajero_Pedidos_Mesa : Form
    {

        private CajaWS.CajaWSClient daoCaja;
        private int idPedidoActualizado;
        private CajaWS.pedido _pedido;
        private UserWS.persona cajero;
        public frm_Cajero_Pedidos_Mesa(CajaWS.pedido pedido, UserWS.persona _cajero)
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();
            cajero = _cajero;
            _pedido = pedido;
            CajaWS.lineaPedido[] lineas = daoCaja.listarLineaPedidoMesa(pedido.idPedido);
            _pedido.list_lineaPedido = lineas;
            if (pedido.mesa.idMesa == 3)
            {
                lblMesa.Text = "Para llevar";
                this.lblMesa.Location = new System.Drawing.Point(69, 18);
            }
            else
            {
                lblMesa.Text = "Mesa " + pedido.mesa.idMesa;
                this.lblMesa.Location = new System.Drawing.Point(82, 18);
            }
            if (pedido.tipoPedido == 'C')//para comer
            {
                lblPedido.Text = "Para mesa";
            }
            else
            {
                lblPedido.Text = "Para llevar";
            }
            if (lineas != null)
            {
                BindingList<CajaWS.lineaPedido> lineaBL = new BindingList<CajaWS.lineaPedido>(lineas);
                foreach (CajaWS.lineaPedido linea in lineaBL)
                {
                    frm_Cajero_LineaPedidos formCajeroLineaPedidos = new frm_Cajero_LineaPedidos(linea);
                    formCajeroLineaPedidos.Dock = DockStyle.Top;
                    formCajeroLineaPedidos.TopLevel = false;
                    panelPedidos.Controls.Add(formCajeroLineaPedidos);
                    formCajeroLineaPedidos.Visible = true;

                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frm_Caja_Pedido formCajaPedido = new frm_Caja_Pedido(_pedido,cajero);
            formCajaPedido.Show();
        }
    }
}
