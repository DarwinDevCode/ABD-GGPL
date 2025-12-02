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
    public partial class frmEnfermedad : Form
    {
        private static frmEnfermedad instancia = null;
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();

        public static frmEnfermedad Formulario()
        {
            if (instancia == null) { instancia = new frmEnfermedad(); }
            return instancia;
        }

        public frmEnfermedad()
        {
            InitializeComponent();
        }

        public void MostrarAnimales()
        {
            clase_general.AjustarTabla(dgvEmfermedades, clase_modulo_animal.ListaAnimalesEnfermedades());
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cbxAnimales, clase_modulo_animal.ListaAnimalesCombobox());
            clase_general.RellenarLista(cbxEnfermedades, clase_modulo_animal.ListaTipoEnfermedadesCombobox());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = clase_modulo_animal.RegistrarEnfermedad((int)cbxAnimales.SelectedValue, (int)cbxEnfermedades.SelectedValue, tbxObservaciones.Text, DateTime.Now);
            if (resultado)
            {
                MessageBox.Show("REGISTRO AGREGADO CORRECTAMENTE.");
                MostrarAnimales();
                CargarCombobox();
                tbxObservaciones.Clear();
            }
            else
                MessageBox.Show("ERROR AL AGREGAR EL REGISTRO.");
        }
    }
}
