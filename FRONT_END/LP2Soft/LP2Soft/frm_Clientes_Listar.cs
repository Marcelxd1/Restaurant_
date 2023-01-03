using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    public partial class frm_Clientes_Listar : Form
    {
        private UserWS.persona _cliente;
        private UserWS.UserWSClient daoUser;
        private UserWS.actividad _act;
        private Estado _estado;
        private BindingList<UserWS.actividad> acts;
        private BindingList<UserWS.sector> sects;
        public frm_Clientes_Listar()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            dgvListarClientes.AutoGenerateColumns = false;
            
            rbPersona.Checked = true;
            UserWS.sector sector = new UserWS.sector();
            UserWS.actividad actividad = new UserWS.actividad();
            sects = new BindingList<UserWS.sector>();
            sects = new BindingList<UserWS.sector>(daoUser.listarSectores().ToList());
            sector.id_sector = 0;
            sector.descripcion = "TODOS";
            sects.Insert(0, sector);
            cbSector.DataSource = sects;
            cbSector.DisplayMember = "descripcion";
            cbSector.ValueMember = "id_sector";
            acts = new BindingList<UserWS.actividad>();
            acts = new BindingList<UserWS.actividad>(daoUser.listarActividadesXSector(0).ToList());
            actividad.id_actividad = 0;
            actividad.descripcion = "TODOS";
            acts.Insert(0, actividad);
            cbActividad.DataSource = acts;
            cbActividad.DisplayMember = "descripcion";
            cbActividad.ValueMember = "id_actividad";
            cbSector.SelectedIndex = 0;
            cbActividad.SelectedIndex = 0;
            establecerTabla();
        }

        private void establecerTabla()
        {
            if(rbPersona.Checked == true)
            {
                RUC.Visible = false;
                Sector.Visible = false;
                Actividad.Visible = false;
                Column4.Visible = true;
                DNIRUC.Visible = true;
                cbActividad.Enabled = false;
                cbSector.Enabled = false;
                Asociado.Visible = true ;
                VIP.Visible = true ;
                Razon.Visible = false;
            }
            else if(rbEmpresa.Checked == true)
            {
                RUC.Visible = true;
                Sector.Visible = true;
                Actividad.Visible = true;
                DNIRUC.Visible = false;
                Column4.Visible= true;
                cbActividad.Enabled = true;
                cbSector.Enabled=true;
                Asociado.Visible = true;
                VIP.Visible = true;
                Razon.Visible=true;
            }
            cargarTabla();
        }

        private void cargarTabla()
        {
            string indicador = "";
            if (txtBuscar.Text != "Ingrese nombre")
                indicador = txtBuscar.Text;
            if(rbPersona.Checked ==true)
                dgvListarClientes.DataSource = daoUser.listarPersona(indicador);
            else
            {
                _act = new UserWS.actividad();
                _act = (UserWS.actividad)cbActividad.SelectedItem;
                
                dgvListarClientes.DataSource = daoUser.listarClienteXNombre(indicador, cbSector.SelectedIndex, _act.id_actividad);
                
            }
            //if (personas != null)
            //    dgvListarClientes.DataSource = new BindingList<UserWS.persona>(personas);
            //else
            //    MessageBox.Show("errooooooor", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _cliente = (UserWS.persona)dgvListarClientes.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar esta categoría?",
                "Mensaje de Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                int resultado = daoUser.elminarPersona(_cliente.id_persona);
                if (resultado != 0)
                    MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error con la eliminación", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //*************

                cargarTabla();
            }
        }

        private void dgvListarClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            UserWS.persona cliente = (UserWS.persona)dgvListarClientes.Rows[e.RowIndex].DataBoundItem;
            dgvListarClientes.Rows[e.RowIndex].Cells[0].Value = cliente.id_persona;
            if(cliente.VIP==true)
                dgvListarClientes.Rows[e.RowIndex].Cells[4].Value = "SI";
            else
                dgvListarClientes.Rows[e.RowIndex].Cells[4].Value = "NO";
            if (cliente.asociado == true)
                dgvListarClientes.Rows[e.RowIndex].Cells[5].Value = "SI";
            else
                dgvListarClientes.Rows[e.RowIndex].Cells[5].Value = "NO";

            if (cliente.tipo == 'N')
            {
                dgvListarClientes.Rows[e.RowIndex].Cells[2].Value = cliente.DNI;
                dgvListarClientes.Rows[e.RowIndex].Cells[3].Value = cliente.nombre + " " + cliente.apellido_paterno + " " + cliente.apellido_materno;
            }
            else
            {
                dgvListarClientes.Rows[e.RowIndex].Cells[1].Value = cliente.ruc;
                dgvListarClientes.Rows[e.RowIndex].Cells[3].Value = cliente.nombre;
                dgvListarClientes.Rows[e.RowIndex].Cells[6].Value = cliente.actividad.sector.descripcion;
                dgvListarClientes.Rows[e.RowIndex].Cells[7].Value = cliente.actividad.descripcion;
                dgvListarClientes.Rows[e.RowIndex].Cells[8].Value = cliente.razon_social;

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar frmClientes = new frm_Clientes_Registrar(Estado.Modificar, (UserWS.persona)dgvListarClientes.CurrentRow.DataBoundItem);
            if (frmClientes.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private void btnNuvo_Click(object sender, EventArgs e)
        {
            frm_Clientes_Registrar frmClientes = new frm_Clientes_Registrar(Estado.Nuevo,null);
            if (frmClientes.ShowDialog() == DialogResult.OK)
            {
                cargarTabla();
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            establecerTabla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserWS.actividad actividad = new UserWS.actividad();
            acts = new BindingList<UserWS.actividad>();
            acts = new BindingList<UserWS.actividad>(daoUser.listarActividadesXSector(cbSector.SelectedIndex).ToList());
            actividad.id_actividad = 0;
            actividad.descripcion = "TODOS";
            acts.Insert(0, actividad);
            cbActividad.DataSource = acts;
            cbActividad.DisplayMember = "descripcion";
            cbActividad.ValueMember = "id_actividad";
            cbActividad.SelectedIndex = 0;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
