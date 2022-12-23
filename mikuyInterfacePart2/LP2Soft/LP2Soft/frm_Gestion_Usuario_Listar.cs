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
        public frm_Gestion_Usuario_Listar()
        {
            InitializeComponent();
            dgvListarUsuarios.AutoGenerateColumns = false;
            daoUser = new UserWS.UserWSClient();
            _usuario = new UserWS.usuario();
            cboRol.DataSource = daoUser.listarRolTodos();
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "id_rol";
            cboRol.SelectedIndex = -1;
            //cmbRol.Enabled = false;
        }
        public UserWS.usuario UsuarioSeleccionado { get => _usuarioSeleccionado; set => _usuarioSeleccionado = value; }
        public void abrirFormulario(Form formularioMostrar)
        {

        }

        private void txtBoxBuscar_MouseLeave(object sender, EventArgs e)
        {
            if(txtBoxBuscar.Text == "")
            {
                txtBoxBuscar.Text = "Buscar";
                txtBoxBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBoxBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBoxBuscar.Text == "Buscar")
            {
                txtBoxBuscar.Text = "";
                txtBoxBuscar.ForeColor = Color.Black;
            }
        }
        
        private void txtBoxBuscar_IconRightClick(object sender, EventArgs e)
        {
            String nombre = txtBoxBuscar.Text;
            if (nombre == "Buscar")
            {
                nombre = "";
            }
            dgvListarUsuarios.DataSource = daoUser.listarUsuariosXNombre(nombre);
        }

        private void dgvListarUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //UserWS.usuario user = new UserWS.usuario();
            UserWS.usuario user = (UserWS.usuario)dgvListarUsuarios.Rows[e.RowIndex].DataBoundItem;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[0].Value = user.id_usuario;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[1].Value = user.DNI ;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[2].Value = user.nombre + " " + user.apellido_paterno + " " + user.apellido_materno;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[3].Value = user.telefono;
            dgvListarUsuarios.Rows[e.RowIndex].Cells[4].Value = user.rol.descripcion;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _usuarioSeleccionado = (UserWS.usuario)dgvListarUsuarios.CurrentRow.DataBoundItem;
            txtNombre.Text = _usuarioSeleccionado.nombre;
            txtApellidoPaterno.Text = _usuarioSeleccionado.apellido_paterno;
            txtApellidoMaterno.Text = _usuarioSeleccionado.apellido_materno;
            txtTelefono.Text = _usuarioSeleccionado.telefono;
            txtSueldo.Text = _usuarioSeleccionado.salario.ToString();
            txtID.Text = _usuarioSeleccionado.id_usuario.ToString();
            txtTelefono.Enabled = true;
            txtSueldo.Enabled = true; 
            cboRol.SelectedValue = _usuarioSeleccionado.rol.id_rol;
        }

        private void cmbRol_Validating(object sender, CancelEventArgs e)
        {
            if (cboRol.SelectedIndex == -1)
            {
                epRol.SetError(cboRol, "Debe seleccionar el rol");
            }
            else
                epRol.SetError(cboRol, "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtSueldo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un sueldo para el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Double.Parse(txtSueldo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha ingresado correctamente el sueldo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un telefono para el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un rol para el usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _usuario = _usuarioSeleccionado; 
            _usuario.telefono = txtTelefono.Text;
            _usuario.rol = (UserWS.rol)cboRol.SelectedItem;
            _usuario.salario = Double.Parse(txtSueldo.Text);

            int resultado = daoUser.modificarDatosUsuario(_usuario);

            if (resultado >= 0)
            {
                MessageBox.Show("Se ha actualizado correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con la actualizacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epNombre.SetError(txtNombre, "Debe ingresar el nombre");
            }
            else
                epNombre.SetError(txtNombre, "");
        }

        private void txtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoPaterno.Text.Trim() == "")
            {
                epApPaterno.SetError(txtApellidoPaterno, "Debe ingresar el apellido paterno");
            }
            else
                epApPaterno.SetError(txtApellidoPaterno, "");
        }

        private void txtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            if (txtApellidoMaterno.Text.Trim() == "")
            {
                epApMaterno.SetError(txtApellidoMaterno, "Debe ingresar el apellido materno");
            }
            else
                epApMaterno.SetError(txtApellidoMaterno, "");
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                epTelefono.SetError(txtTelefono, "Debe ingresar el número telefónico");
            }
            else
                epTelefono.SetError(txtTelefono, "");
        }

        private void txtSueldo_Validating(object sender, CancelEventArgs e)
        {
            if (txtSueldo.Text.Trim() == "")
            {
                epSueldo.SetError(txtSueldo, "Debe ingresar el sueldo");
            }
            else
                epSueldo.SetError(txtSueldo, "");
        }
    }
}
