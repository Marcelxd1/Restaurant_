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
    public partial class frmBusquedaCliente : Form
    {
        private UserWS.UserWSClient daoCliente;
        private UserWS.persona _clienteSeleccionado;
        public frmBusquedaCliente()
        {
            InitializeComponent();
            daoCliente = new UserWS.UserWSClient();
            dgvListarClientes.AutoGenerateColumns = false;
            cargarTabla();
        }

        public persona ClienteSeleccionado { get => _clienteSeleccionado; set => _clienteSeleccionado = value; }

        private void cargarTabla()
        {
            string indicador = "";
            if (txtBuscar.Text != "Buscar")
                indicador = txtBuscar.Text;
            UserWS.persona[] personas = daoCliente.listarClienteXNombre(indicador,0,0);
            if (personas != null)
                dgvListarClientes.DataSource = new BindingList<UserWS.persona>(personas);
            else
                MessageBox.Show("errooooooor", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvListarClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UserWS.persona cliente = (UserWS.persona)dgvListarClientes.Rows[e.RowIndex].DataBoundItem;
            dgvListarClientes.Rows[e.RowIndex].Cells[0].Value = cliente.id_persona;
            if (cliente.tipo == 'N')
            {
                dgvListarClientes.Rows[e.RowIndex].Cells[1].Value = "Persona";
                dgvListarClientes.Rows[e.RowIndex].Cells[2].Value = cliente.DNI;
                dgvListarClientes.Rows[e.RowIndex].Cells[3].Value =
                    cliente.nombre + " " + cliente.apellido_paterno + " " + cliente.apellido_materno;
            }
            else
            {
                dgvListarClientes.Rows[e.RowIndex].Cells[1].Value = "Empresa";
                dgvListarClientes.Rows[e.RowIndex].Cells[2].Value = cliente.ruc;
                dgvListarClientes.Rows[e.RowIndex].Cells[3].Value =
                    cliente.nombre;
            }
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_IconRightClick(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvListarClientes.CurrentRow != null)
            {
                _clienteSeleccionado = (UserWS.persona)dgvListarClientes.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
