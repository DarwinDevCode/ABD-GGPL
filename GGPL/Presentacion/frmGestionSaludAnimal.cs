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
    public partial class frmGestionSaludAnimal : Form
    {
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static csModuloProduccionLechera clase_modulo_produccion_animal = new csModuloProduccionLechera();
        static frmSaludAnimal formulario = frmSaludAnimal.Formulario();
        private static frmGestionSaludAnimal instancia = null;

        public static frmGestionSaludAnimal Formulario()
        {
            if (instancia == null) { instancia = new frmGestionSaludAnimal(); }
            return instancia;
        }

        public frmGestionSaludAnimal()
        {
            InitializeComponent();
        }

        public void CargarControles()
        {
            dtpFechaRevision.Format = DateTimePickerFormat.Custom;
            dtpFechaRevision.CustomFormat = "dd/MM/yyyy hh:mm";
            clase_general.RellenarLista(cbxAnimales, clase_modulo_produccion_animal.ObtenerAnimales());
            cbxAnimales.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                bool resultado1 = false;
                resultado1 = clase_modulo_animal.RegistrarSaludGeneral(
                    cbxAnimales.SelectedValue.ToString(),
                    tbxPesoAnimal.Text,
                    tbxCondicionCorporal.Text,
                    DateTime.Now.ToString(),
                    dtpFechaRevision.Value.ToString(),
                    tbxTemperatura.Text,
                    tbxFrecuenciaCardiaca.Text,
                    tbxFrecuenciaRespiratoria.Text,
                    tbxMucosas.Text
                    );

                if (resultado1)
                {
                    MessageBox.Show($"Salud del animal registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formulario.MostrarSaludGeneral();
                    LimpiarControles();
                }            
                else
                    MessageBox.Show("No se pudo registrar la salud del animal (Registro ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        public void LimpiarControles()
        {
            cbxAnimales.SelectedIndex = -1;
            tbxPesoAnimal.Clear();
            tbxCondicionCorporal.Clear();
            dtpFechaRevision.Value = DateTime.Now;

            if (tbxTemperatura.Text != string.Empty || tbxFrecuenciaCardiaca.Text != string.Empty || tbxFrecuenciaRespiratoria.Text != string.Empty || tbxMucosas.Text != string.Empty)
            {
                tbxTemperatura.Clear();
                tbxFrecuenciaCardiaca.Clear();
                tbxFrecuenciaRespiratoria.Clear();
                tbxMucosas.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
