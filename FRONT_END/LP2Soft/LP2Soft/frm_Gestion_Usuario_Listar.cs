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
    public partial class frm_Gestion_Usuario_Listar : Form
    {
        private UserWS.UserWSClient daoUser;
        private UserWS.usuario _usuarioSeleccionado;
        private UserWS.usuario _usuario;
        private Form formularioActivo = null;
        private BindingList<UserWS.rol> rols;
        public frm_Gestion_Usuario_Listar()
        {
            InitializeComponent();
            dgvListarUsuarios.AutoGenerateColumns = false;
            daoUser = new UserWS.UserWSClient();
            _usuario = new UserWS.usuario();
            rols = new BindingList<UserWS.rol>();
            rols = new BindingList<UserWS.rol>(daoUser.listarRolTodos().ToList());
            UserWS.rol rol = new UserWS.rol();
            rol.id_rol = 0;
            rol.descripcion = "TODOS";
            rols.Insert(0,rol);
            cboRol.DataSource = rols;
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "id_rol";
            dgvListarUsuarios.DataSource = daoUser.listarUsuariosXNombre("",0);
            //cmbRol.Enabled = false;
        }
        public UserWS.usuario UsuarioSeleccionado { get => _usuarioSeleccionado; set => _usuarioSeleccionado = value; }
        public void abrirFormulario(Form formularioMostrar)
        {

        }

        

        private void txtBoxBuscar_IconRightClick(object sender, EventArgs e)
        {
            String nombre = txtBoxBuscar.Text;
            if (nombre == "Ingrese nombre...")
            {
                nombre = "";
            }

            dgvListarUsuarios.DataSource = daoUser.listarUsuariosXNombre(nombre,cboRol.SelectedIndex);
        }

        private void dgvListarUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //UserWS.usuario user = new UserWS.usuario();
            UserWS.usuario user = (UserWS.usuario)dgvListarUsuarios.Rows[e.RowIndex].DataBoundItem;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[0].Value = user.id_usuario;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[1].Value = user.DNI;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[2].Value = user.nombre + " " + user.apellido_paterno + " " + user.apellido_materno;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[4].Value = user.telefono;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[3].Value = user.rol.descripcion;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[5].Value = user.salario;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[6].Value = user.correo;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _usuarioSeleccionado = (UserWS.usuario)dgvListarUsuarios.CurrentRow.DataBoundItem;
            int resultado = daoUser.elminarUsuario(_usuarioSeleccionado.id_usuario);
            if (resultado >= 0)
            {
                MessageBox.Show("Se ha ELIMINADO correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con la ELIMINACION del usuario", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBoxBuscar.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_Gestion_Usuario frmGestionUsuario = new frm_Gestion_Usuario(Estado.Nuevo,null);
            if (frmGestionUsuario.ShowDialog() == DialogResult.OK)
            {
                dgvListarUsuarios.DataSource = daoUser.listarTodosUsuarios();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frm_Gestion_Usuario frmGestionUsuario = new frm_Gestion_Usuario(Estado.Modificar, (UserWS.usuario)dgvListarUsuarios.CurrentRow.DataBoundItem);
            if (frmGestionUsuario.ShowDialog() == DialogResult.OK)
            {
                dgvListarUsuarios.DataSource = daoUser.listarTodosUsuarios();
            }
        }
    }
}
