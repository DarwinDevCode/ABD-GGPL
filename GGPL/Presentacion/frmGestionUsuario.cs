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
    public partial class frmGestionUsuario : Form
    {
        static csModuloUsuario clase_usuario = new csModuloUsuario();
        static csGeneral clase_general = new csGeneral();
        public bool bandera = false;
        public int id_usuario = -1;
        static private frmGestionUsuario instancia = null;
        static frmUsuario formulario = frmUsuario.Formulario();

        public frmGestionUsuario()
        {
            InitializeComponent();
        }

        public static frmGestionUsuario Formulario()
        {
            if (instancia == null) { instancia = new frmGestionUsuario(); }
            return instancia;
        }

        public void RellenarComboBoxs()
        {
            clase_general.RellenarLista(cbxRol, clase_usuario.ListaRoles());
        }

        public void LimpiarComponentes()
        {
            tbxCedula.Clear();
            tbxNombre.Clear();
            tbxApellido.Clear();
            tbxTelefono.Clear();
            tbxCorreo.Clear();
            tbxUsuario.Clear();
            tbxContraseña.Clear();
            cbxGenero.SelectedIndex = -1;
            cbxRol.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado1 = false;
            if (!bandera)
            {
                resultado1 = clase_usuario.RegistrarUsuario((int)cbxRol.SelectedValue, tbxCedula.Text.Trim(), tbxNombre.Text.Trim(), tbxApellido.Text.Trim(), Convert.ToChar(cbxGenero.Text), dtpFecha.Value.Date, tbxTelefono.Text.Trim(), tbxCorreo.Text.Trim(), tbxUsuario.Text.Trim(), tbxContraseña.Text.Trim());
                if (resultado1)
                    MessageBox.Show("USUARIO AGREGADO EXITOSAMENTE.");
                else
                    MessageBox.Show("ERROR AL REGISTRAR EL USUARIO.");
            }
            else
            {
                //POR COMPLETAR


                //resultado1 = clase_usuario.ModificarUsuario
                //    (id_usuario, 
                //    (int)cbxRol.SelectedValue, 
                //    tbxCedula.Text, 
                //    tbxNombre.Text, 
                //    tbxApellido.Text, 
                //    Convert.ToChar(cbxGenero.Text), 
                //    dtpFecha.Value.Date, 
                //    tbxTelefono.Text, 
                //    tbxCorreo.Text, 
                //    "", 
                //    "");              
                
                //if (resultado1)
                //    MessageBox.Show("USUARIO MODIFICADO EXITOSAMENTE.");
                bandera = false;
            }
            LimpiarComponentes();
            formulario.MostrarUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
            this.Close();
        }
    }
}
