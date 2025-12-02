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
    public partial class frmGestionProduccionLeche : Form
    {
        static csModuloProduccionLechera clase_modulo_produccion_lechera = new csModuloProduccionLechera();
        static frmGestionProduccionLeche instancia = null;
        static csGeneral clase_general = new csGeneral();
        public bool bandera = false; public int id_produccion = -1;
        static frmPantallaPrincipal aux = frmPantallaPrincipal.Formulario();
        static frmProduccionLechera formulario = frmProduccionLechera.Formulario();

        public static frmGestionProduccionLeche Formulario()
        {
            if (instancia == null) { instancia = new frmGestionProduccionLeche(); }
            return instancia;
        }

        public frmGestionProduccionLeche()
        {
            InitializeComponent();
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cbxAnimales, clase_modulo_produccion_lechera.ListaAnimalesHembras());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!bandera)
            {
                bool resultado = clase_modulo_produccion_lechera.RegistrarProduccionLechera(aux.IDUsuario, (int)cbxAnimales.SelectedValue, Convert.ToDecimal(tbxLecheProducida.Text), Convert.ToChar(cbxTipoOrdeño.Text), DateTime.Now);
                if (resultado)
                    MessageBox.Show("REGISTRO DE PRODUCCION AGREGADO CORRECTAMENTE.");
                else
                    MessageBox.Show("ERROR AL REGISTRAR LA PRODUCCIÓN.");
            }
            else
            {
                bool resultado = clase_modulo_produccion_lechera.ModificarProduccionLechera(id_produccion, aux.IDUsuario, (int)cbxAnimales.SelectedValue, Convert.ToDecimal(tbxLecheProducida.Text), Convert.ToChar(cbxTipoOrdeño.Text), DateTime.Now);
                if (resultado)
                    MessageBox.Show("REGISTRO DE PRODUCCION MODIFICADO CORRECTAMENTE.");
                else
                    MessageBox.Show("ERROR AL MODIFICAR LA PRODUCCIÓN.");

                bandera = false;
            }
            formulario.MostrarProduccionLechera();
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            cbxAnimales.SelectedIndex = -1;
            cbxTipoOrdeño.SelectedIndex = -1;
            tbxLecheProducida.Clear();
        }
    }
}
