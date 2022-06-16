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
    public partial class frmBuscarProductoPed : Form
    {
        private NegocioWS.NegocioWSClient _daoNegocio;
        private BindingList<NegocioWS.categoria> _listaCat;
        private BindingList<Button> lista_botones;

        public frmBuscarProductoPed()
        {
            InitializeComponent();
            dgvItem.AutoGenerateColumns = false;
            dgvItem.DataSource = _daoNegocio.listarTodosItemsXNombre("");
            panelCategorias.AutoScroll = true;
            cargarCategorias();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = _daoNegocio.listarTodosItemsXNombre(txtBuscar.Text);
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
            char[] sep = new char[] { ' ' };
            string[] subs = sender.ToString().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            string name = subs[2];
            dgvItem.DataSource = _daoNegocio.listarProductoXCategoria(name);
        }




    }


}
