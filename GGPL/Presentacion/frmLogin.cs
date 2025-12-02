using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negociacion;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        static csModuloUsuario clase_usuario = new csModuloUsuario();
        public int id_usuario;
        public string rol_usuario;
        static bool bandera = false;
        static frmLogin instancia = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        public static frmLogin Formulario()
        {
            if (instancia == null) { instancia = new frmLogin(); }
            return instancia;
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            object id_usuario, rol_usuario;
            bool resultado;

            (id_usuario, rol_usuario, resultado) = clase_usuario.VerificarCredenciales(tbxUsuario.Text, tbxContraseña.Text);

            if (resultado)
            {
                this.id_usuario = (int)id_usuario;
                this.rol_usuario = (string)rol_usuario;  
                frmPantallaPrincipal frmPrincipal = frmPantallaPrincipal.Formulario();
                frmResumen frmResumen = frmResumen.Formulario();
                frmPrincipal.pnlPrincipal.Controls.Clear();
                frmPrincipal.Show();
                frmPrincipal.DeshabilitarBotones(this.rol_usuario);
                frmPrincipal.IDUsuario = this.id_usuario;
                frmPrincipal.LlamarFormulario(frmResumen);
                frmResumen.CargarGrafico();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR AL INICAR SESION.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (!bandera)
            {
                tbxContraseña.UseSystemPasswordChar = false;
                bandera = true;
            }
            else
            {
                tbxContraseña.UseSystemPasswordChar = true;
                bandera = false;
            }
        }

        private void tbxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                tbxContraseña.Focus();
        }

        private void tbxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnIniciarSesion.PerformClick();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
