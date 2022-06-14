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
    public partial class frm_Gestion_Mesas : Form
    {
        private Estado _estado;
        private NegocioWS.NegocioWSClient daonegocio;
        private NegocioWS.mesa mesaSelecc;
        private BindingList<NegocioWS.mesa> lista_mesas; 
        private NegocioWS.mesa _mesa;
        

        public frm_Gestion_Mesas()
        {
            InitializeComponent();
            daonegocio = new NegocioWS.NegocioWSClient();
            _estado = Estado.Inicial;
            establecerComponentes();

            refreshComboBox(); 
            _mesa = new NegocioWS.mesa();
                

        }
        private void refreshComboBox()
        {
            lista_mesas = new BindingList<NegocioWS.mesa>(daonegocio.listarTodasMesa());
            if (lista_mesas != null)
            {
                cbMesas.DataSource = lista_mesas;
                cbMesas.DisplayMember = "idMesa";
                cbMesas.ValueMember = "idMesa";
                lista_mesas.AllowEdit = true;
                lista_mesas.AllowNew = true;
            }
        }
        public void establecerComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    txtID.Text = "";
                    txtCapacidad.Text = "";
                    txtID.Enabled = false;
                    txtCapacidad.Enabled = false;
                    txtCapacidad.ReadOnly = true;
                    txtID.Enabled = true;
                    txtCapacidad.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cbMesas.Enabled = false;
                    break;
                case Estado.Modificar:
                case Estado.Nuevo:
                    txtID.Enabled = true;
                    txtCapacidad.Enabled = true;
                    txtCapacidad.ReadOnly = false;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cbMesas.Enabled = false;
                    break;
                case Estado.Buscar:
                    txtID.Enabled = false;
                    txtCapacidad.Enabled= false;
                    txtCapacidad.ReadOnly = true;
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    cbMesas.Enabled = true;
                    break;
                
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            establecerComponentes();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _estado= Estado.Buscar;
            establecerComponentes();
            
        }

        private void cbMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_estado != Estado.Inicial && _estado!= Estado.Nuevo)
            {
                mesaSelecc = (NegocioWS.mesa)cbMesas.SelectedItem;
                txtID.Text = mesaSelecc.idMesa.ToString();
                txtCapacidad.Text = mesaSelecc.numero.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Modificar;
            establecerComponentes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado=0;
            if (_estado == Estado.Nuevo)
            {
                //_mesa.idMesa = 0;
                _mesa.numero = Int32.Parse(txtCapacidad.Text);
                resultado= daonegocio.insertarMesa(_mesa);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado la mesa correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerComponentes();
                    refreshComboBox();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_estado == Estado.Modificar)
            {
                _mesa = mesaSelecc;
               _mesa.numero = Int32.Parse(txtCapacidad.Text);
                
                resultado = daonegocio.modificarMesa(_mesa);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _estado = Estado.Inicial;
                    establecerComponentes();
                    refreshComboBox();
                }
                else
                    MessageBox.Show("Ha ocurrido un error con la modificación", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            _mesa = mesaSelecc;
            resultado= daonegocio.eliminarMesa(_mesa.idMesa);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha eliminado correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Inicial;
                establecerComponentes();
                refreshComboBox();
            }
            else
                MessageBox.Show("Ha ocurrido un error con la eliminacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            establecerComponentes();
        }

        
    }
}
