using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frmBoleta : Form
    {
        private byte[] arreglo;
        private ReporteWS.ReporteWSClient reporte;
        private CajaWS.pedido pedido;
        private string cajero;
        private string mesero;
        private string cliente;
        private string dniRuc;
        private int mesa;
        public frmBoleta(CajaWS.pedido _pedido,double pago, double vuelto)
        {
            InitializeComponent();
            pedido = _pedido;
            reporte = new ReporteWS.ReporteWSClient();
            if (pedido.cliente == null) //  no hay clientes
            {
                cliente = "";
                dniRuc = "";
            }
            else // si hay cliente
            {
                cliente = _pedido.cliente.nombre;
                if (_pedido.cliente.tipo == 'N')
                { //cliente natural
                    dniRuc = _pedido.cliente.DNI;
                    cliente += " " + _pedido.cliente.apellido_paterno;
                }
                else //cliente juridico
                    dniRuc = _pedido.cliente.ruc;
            }
            if (pedido.cajero == null)//cajeros
                cajero = "";
            else
            {
                cajero = _pedido.cajero.nombre;
                cajero += " " + _pedido.cajero.apellido_paterno;
            }
            if (pedido.mesero == null)//meseros
                mesero = "";
            else
            {
                mesero = _pedido.mesero.nombre;
                mesero += " "+ _pedido.mesero.apellido_paterno;
            }
            if (pedido.mesa != null)
                mesa = pedido.mesa.numMesa;
            else
                mesa = 0;

            if (pedido.tipoComprobante == 'B')
            {
                arreglo = reporte.generarBoletaVenta(_pedido.idPedido, cajero,
                    mesero, cliente, dniRuc,mesa,pago,vuelto);
            }
            else
            {
                arreglo = reporte.generarFacturaVenta(_pedido.idPedido, cajero,
                    mesero, cliente, dniRuc,mesa,pago,vuelto);
            }

            File.WriteAllBytes("temporal.pdf", arreglo);
            visorPDF.LoadFile("temporal.pdf");
        }
    }
}