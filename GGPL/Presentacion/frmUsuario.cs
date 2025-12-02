using System;
using System.Collections;
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
    public partial class frmUsuario : Form
    {
        static csModuloUsuario clase_usuario = new csModuloUsuario();
        static csGeneral clase_general = new csGeneral();
        static private frmUsuario instancia = null;
        static frmGestionUsuario formulario = frmGestionUsuario.Formulario();

        public frmUsuario()
        {
            InitializeComponent();
        }

        public static frmUsuario Formulario()
        {
            if (instancia == null) { instancia = new frmUsuario(); }
            return instancia;
        }

        public void MostrarUsuarios()
        {
            clase_general.AjustarTabla(dgvUsuarios, clase_usuario.ListaUsuarios());
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            frmGestionUsuario formulario = frmGestionUsuario.Formulario();
            formulario.RellenarComboBoxs();
            formulario.tbxUsuario.Visible = true;
            formulario.tbxContraseña.Visible = true;
            formulario.lbUsuario.Visible = true;
            formulario.lbContraseña.Visible = true;
            formulario.ShowDialog();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                formulario.RellenarComboBoxs();
                formulario.bandera = true;
                formulario.tbxUsuario.Visible = false;
                formulario.tbxContraseña.Visible = false;
                formulario.lbUsuario.Visible = false;
                formulario.lbContraseña.Visible = false;

                formulario.id_usuario = (int)dgvUsuarios[0, f].Value;
                clase_general.SeleccionarItem(formulario.cbxRol, dgvUsuarios[1, f].Value.ToString());
                formulario.tbxCedula.Text = dgvUsuarios[2, f].Value.ToString();                             
                formulario.tbxNombre.Text = dgvUsuarios[3, f].Value.ToString();
                formulario.tbxApellido.Text = dgvUsuarios[4, f].Value.ToString();
                formulario.cbxGenero.SelectedItem = dgvUsuarios[5, f].Value.ToString();
                formulario.dtpFecha.Text = dgvUsuarios[6, f].Value.ToString();
                formulario.tbxTelefono.Text = dgvUsuarios[7, f].Value.ToString();
                formulario.tbxCorreo.Text = dgvUsuarios[8, f].Value.ToString();
                formulario.ShowDialog();
            }
        }
    }
}
