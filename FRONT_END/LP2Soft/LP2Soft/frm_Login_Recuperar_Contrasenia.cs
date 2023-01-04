using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using LP2Soft.UserWS;

namespace LP2Soft
{
    public partial class frm_Login_Recuperar_Contrasenia : Form
    {
        private UserWS.UserWSClient daoUser;
        private Estado _estado;
        int id_persona;
        int codigo;
        public frm_Login_Recuperar_Contrasenia()
        {
            InitializeComponent();
            daoUser = new UserWS.UserWSClient();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:        //cuando se ingresa el correo
                    lblTipo.Visible = true;
                    btnSiguiente.Enabled = true;
                    btnSiguiente.Visible = true;
                    txtInput.Visible = true;
                    txtInput.Enabled = true;
                    txtInput.Text = "";
                    lblMsjError.Visible = false;

                    lblTipo2.Visible= false;
                    txtContrasenia2.Visible = false;
                    txtContrasenia2.Enabled = false;
                    lblMsjError2.Visible = false;
                    break;
                case Estado.Modificar:      //cuando se ingresa el código de verificacion
                    lblTipo.Visible = true;
                    lblTipo.Text = "Ingrese el código de verificación enviado a su correo electrónico";
                    btnSiguiente.Enabled = true;
                    btnSiguiente.Visible = true;
                    txtInput.Visible = true;
                    txtInput.Text = "";
                    txtInput.Enabled = true;
                    lblMsjError.Visible = false;
                    lblMsjError.Text = "El código de verificación no es correcto.";

                    lblTipo2.Visible = false;
                    txtContrasenia2.Visible = false;
                    txtContrasenia2.Enabled = false;
                    lblMsjError2.Visible = false;
                    break;
                case Estado.Nuevo:          //cuando se cambia de contraseña
                    lblTipo.Visible = true;
                    lblTipo.Text = "Ingrese la nueva contraseña de la cuenta";
                    btnSiguiente.Enabled = true;
                    btnSiguiente.Visible = true;
                    btnSiguiente.Text = "Cambiar contraseña";
                    txtInput.Visible = true;
                    txtInput.Enabled = true;
                    txtInput.Text = "";
                    lblMsjError.Visible = false;
                    lblMsjError.Text = "El código de verificación no es correcto.";

                    lblTipo2.Visible = true;
                    txtContrasenia2.Visible = true;
                    txtContrasenia2.Enabled = true;
                    lblMsjError2.Visible = false;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(txtInput.Text);
            string apellidoPaterno = txtInput.Text;

            id_persona = daoUser.verificarUsuario(dni, apellidoPaterno);
            if (id_persona > 0)
            {
                _estado = Estado.Modificar;
                establecerEstadoComponentes();
            }
            else
            {
                lblMsjError.Visible = true;
                lblMsjError.Text = "No pudimos encontrar tu cuenta de Quinti.";
                txtInput.Text = "";
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(_estado == Estado.Modificar)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {

        }

        private void generarCodigo()
        {
            int seed = Environment.TickCount;
            Random random = new Random(seed);
            codigo = random.Next(100000, 1000000);
        }

        private void enviarCorreo()
        {
            string correoDestino = txtInput.Text;
            MailMessage correo = new MailMessage();
            correo.From = new MailAddress("han0482san@gmail.com");//Correo de salida
            correo.To.Add(correoDestino); //Correo destino?
            correo.Subject = "Código de verificación de Quinti"; //Asunto
            correo.Body = "<h2>Estimado usuario de Quinti:</h2>" +
                "<p>Recibimos una solicitud de Quinti con tu dirección de correo electrónico para el cambio de contraseña. El código de verificación de Quinti es:</p>"
                + $"<h3>{codigo}</h3>" + "<p>Si no solicitaste este código, ignore este mensaje.</p>"
                + "<p>Atentamente.</p><p>El equipo de cuentas de Quinti.</p>"; //Mensaje del correo
            correo.IsBodyHtml = true;
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = false;
            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
            smtp.Port = 25; //Puerto de salida
            smtp.Credentials = new System.Net.NetworkCredential("han0482san@gmail.com", "sqkcuuiolafhatcc");//Cuenta de correo sqkcuuiolafhatcc
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
            try
            {
                smtp.Send(correo);
            }
            catch (Exception ex)
            {
                throw new Exception("No se ha podido enviar el email", ex.InnerException);
            }
            finally
            {
                smtp.Dispose();
            }
        }

        private void verificarUsuario()
        {
            string apellidoPaterno = txtInput.Text;
            if(apellidoPaterno == "")
            {
                lblMsjError.Visible = true;
                lblMsjError.Text = "Ingrese un correo electrónico.";
                return;
            }

            id_persona = daoUser.verificarUsuario(1, apellidoPaterno);
            if (id_persona > 0)
            {
                generarCodigo();
                enviarCorreo();
                MessageBox.Show($"Se envío al correo electrónico {apellidoPaterno} el código de verificación de 6 dígitos", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _estado = Estado.Modificar;
                establecerEstadoComponentes();
            }
            else
            {
                lblMsjError.Visible = true;
                lblMsjError.Text = "No pudimos encontrar tu cuenta de Quinti.";
                txtInput.Text = "";
            }
        }

        private void verificarCodigo()      //int dni = Int32.Parse(txtInput.Text);
        {
            if(txtInput.Text == "")
            {
                epInput.SetError(txtInput, "Debe ingresar el código de verificación de 6 dígitos");
                return;
            }
            string codigoInput = txtInput.Text;
            string code = codigo.ToString();
            if(codigoInput == code)
            {
                _estado = Estado.Nuevo;
                establecerEstadoComponentes();
            }
            else
            {
                lblMsjError.Visible = true;
                lblMsjError.Text = "El código no coincide con el enviado al correo electrónico.";
                txtInput.Text = "";
            }
        }

        private void cambioContrasenia()
        {
            string cont1 = txtInput.Text;
            string cont2 = txtContrasenia2.Text;
            if(cont1 == cont2)
            {
                int resultado = daoUser.cambiarContrasenia(id_persona, cont1);
                if (resultado != 0)
                {
                    MessageBox.Show("SE HA CAMBIADO LA CONTRASEÑA CORRECTAMENTE", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                lblMsjError2.Visible= true;
                txtContrasenia2.Text = "";
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(_estado == Estado.Inicial)
            {
                verificarUsuario();
            }
            else if (_estado == Estado.Modificar)
            {
                verificarCodigo();
            }
            else if(_estado == Estado.Nuevo)
            {
                cambioContrasenia();
            }

        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            if (_estado == Estado.Inicial)
            {
                if (txtInput.Text.Trim() == "")
                    epInput.SetError(txtInput, "Debe ingresar un correo electrónico");
                else
                    epInput.SetError(txtInput, "");
            }
            else if (_estado == Estado.Modificar)
            {
                if (txtInput.Text.Trim() == "")
                    epInput.SetError(txtInput, "Debe ingresar el código de verificación de 6 dígitos");
                else
                    epInput.SetError(txtInput, "");
            }
        }
    }
}
