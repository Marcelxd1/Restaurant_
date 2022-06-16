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
    public partial class frm_Caja : Form
    {
        private Estado _estado;
        private CajaWS.CajaWSClient daoCaja;
        private UserWS.UserWSClient daoUsuario;
        private UserWS.restaurante restaurante;
        private CajaWS.transaccion[] tran;
        private CajaWS.pedido[] pedidos;
        
        public frm_Caja()
        {
            InitializeComponent();
            daoCaja = new CajaWS.CajaWSClient();
            daoUsuario = new UserWS.UserWSClient();
            dgvTransaccion.AutoGenerateColumns = false;
            CajaWS.transaccion[] transaccions = daoCaja.listarTransacciones();
            restaurante = new UserWS.restaurante();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
            cargarTabla(transaccions);
            cargarDatos();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnModificar.Enabled = true;
                    txtEfectivo.Enabled = false;
                    txtGastos.Enabled = false; 
                    txtPedLLevar.Enabled = false;
                    txtPedMEsa.Enabled = false;
                    txtTarjeta.Enabled = false;
                    txtTotalCaja.Enabled = false;
                    txtTotalPago.Enabled = false;
                    txtTotPedi.Enabled = false;
                    break;
                case Estado.Modificar:
                    break;

            }


        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void cargarTabla(CajaWS.transaccion[] transaccions)
        {
            
            if (transaccions != null)
                dgvTransaccion.DataSource = new BindingList<CajaWS.transaccion>(transaccions);
            else
                MessageBox.Show("ERROR tabla nula", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvTransaccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CajaWS.transaccion tran = (CajaWS.transaccion)dgvTransaccion.Rows[e.RowIndex].DataBoundItem;
            
            if (tran.tipo == 'G')
            {
                dgvTransaccion.Rows[e.RowIndex].Cells[0].Value = "Egreso";
            }
            else
            {
                dgvTransaccion.Rows[e.RowIndex].Cells[0].Value = "Ingreso";
            }
            dgvTransaccion.Rows[e.RowIndex].Cells[1].Value = tran.fecha.Date;
            dgvTransaccion.Rows[e.RowIndex].Cells[2].Value = tran.total.ToString("N2");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtpIni != null && dtpFin != null)
            {
                CajaWS.transaccion[] transaccions = 
                    daoCaja.listarTransaccionesXFecha(dtpIni.Value,dtpFin.Value);
                cargarTabla(transaccions);
            }
            else
            {
                CajaWS.transaccion[] transaccions = daoCaja.listarTransacciones();
                cargarTabla(transaccions);
            }
        }

        private void cargarDatos()
        {
            restaurante = daoUsuario.BuscaRestaurante(1);
            txtTotalCaja.Text = restaurante.dineroActual.ToString("N2");
            tran = daoCaja.listarTransacciones();
            double totalGasto = 0, totalPedido = 0,totMesa=0,totLLeva =0,totTarj=0,totEfec=0,totModo;
            foreach(CajaWS.transaccion t in tran)
            {
                if(t.tipo == 'G')//Gastos
                {
                    totalGasto += t.total;
                }
                else
                {
                    totalPedido += t.total;
                }

            }
            txtGastos.Text = totalGasto.ToString("N2");
            txtTotPedi.Text = totalPedido.ToString("N2");
            txtTotalPago.Text = totalPedido.ToString("N2");
            pedidos = daoCaja.ListarPedidosTransaccion();
            foreach (CajaWS.pedido p in pedidos)
            {
                if (p.tipoPedido == 'C')//Para mesa
                    totMesa += p.total;
                else
                    totLLeva += p.total;//Para llebar

                if (p.tipoComprobante == 'E')//Efectivo
                    totEfec += p.total;
                else
                    totTarj += p.total;//Tarjeta
            }
            txtPedLLevar.Text = totLLeva.ToString("N2");
            txtPedMEsa.Text = totMesa.ToString("N2");
            txtTarjeta.Text = totTarj.ToString("N2");
            txtEfectivo.Text = totEfec.ToString("N2");
        }
    }
}
