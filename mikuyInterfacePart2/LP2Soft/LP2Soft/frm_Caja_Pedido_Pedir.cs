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
    public partial class frm_Caja_Pedido_Pedir : Form
    {
        
        private NegocioWS.NegocioWSClient _daoNegocio;
        private BindingList<NegocioWS.producto> _productoList;
        private BindingList<CajaWS.lineaPedido> _lista_linea;
        private CajaWS.pedido _pedido;
        private double suma = 0;
        private BindingList<NegocioWS.categoria> _listaCat;
        private BindingList<Button> lista_botones;

        public frm_Caja_Pedido_Pedir()
        {
            InitializeComponent();
            _daoNegocio = new NegocioWS.NegocioWSClient();
            _lista_linea = new BindingList<CajaWS.lineaPedido>();
            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = _daoNegocio.listarTodosItemsXNombre("");
            panelCategorias.AutoScroll = true;
            txtTotal.Enabled = false;
            txtTotal.Text = "0.00";
            cargarCategorias();
        }

        public CajaWS.pedido PedidoRealizado {get => _pedido; set => _pedido = value;  }

        public void establecerEstadoComponentes()
        {
               
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
            char[] sep = new char[] {' '};
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
            CajaWS.lineaPedido lineaPe = new CajaWS.lineaPedido();
            //lineaPe.item = (NegocioWS.itemVendible)dgvItem.CurrentRow;
            //dgvPedido.Rows[e.CurrentRow.Index].Cells[2].Value = 1;
            _lista_linea.Add(lineaPe);
            suma += Convert.ToDouble(dgvItem[2, dgvItem.CurrentRow.Index].Value);
            txtTotal.Text = Convert.ToString(suma);
        }

        private void dgvPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgvPedido.Rows[e.RowIndex].Cells[2].Value = 1;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvPedido.CurrentRow != null)
            {

                _lista_linea.RemoveAt(dgvPedido.CurrentRow.Index);
                dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value);
            dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value = n + 1;

            suma += Convert.ToDouble(dgvPedido[3, dgvPedido.CurrentRow.Index].Value);
            txtTotal.Text = suma.ToString();
            _lista_linea[dgvPedido.CurrentRow.Index].unidades = n;
            _lista_linea[dgvPedido.CurrentRow.Index].subtotal = suma;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value);
            dgvPedido.Rows[dgvPedido.CurrentRow.Index].Cells[3].Value = n - 1;

            suma -= Convert.ToDouble(dgvPedido[3, dgvPedido.CurrentRow.Index].Value);
            txtTotal.Text = suma.ToString("N2");
            _lista_linea[dgvPedido.CurrentRow.Index].unidades = n;
            _lista_linea[dgvPedido.CurrentRow.Index].subtotal = suma;
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            _pedido = new CajaWS.pedido();
            foreach(CajaWS.lineaPedido lin in _lista_linea)
            {
                lin.pedido = _pedido;
            }
            _pedido.list_lineaPedido = _lista_linea.ToArray();
            this.DialogResult = DialogResult.OK;
        }
    }

}
