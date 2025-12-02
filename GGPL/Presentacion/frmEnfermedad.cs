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
        int id_estado = 0, id_enfermedad;
        bool bandera = false, resultado;
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
            try
            {

                if (!bandera)
                {
                    resultado = clase_modulo_animal.RegistrarEnfermedad((int)cbxAnimales.SelectedValue, (int)cbxEnfermedades.SelectedValue, tbxObservaciones.Text, DateTime.Now);
                    CambiarEstado();


                    if (resultado)
                    {
                        MessageBox.Show($"Enfermedad registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarAnimales();
                        CargarCombobox();
                        tbxObservaciones.Clear();
                    }
                    else
                        MessageBox.Show("No se pudo registrar la enfermedad (Enfermedad ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = clase_modulo_animal.ModificarEnfermedad(id_enfermedad, (int)cbxAnimales.SelectedValue, (int)cbxEnfermedades.SelectedValue, tbxObservaciones.Text);
                    CambiarEstado();

                    if (resultado)
                    {
                        MessageBox.Show($"Enfermedad modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarAnimales();
                        CargarCombobox();
                        tbxObservaciones.Clear();
                    }
                    else
                        MessageBox.Show("No se pudo modificar la enfermedad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        public void CambiarEstado()
        {
            DataTable tabla_id_estado = clase_modulo_animal.ListaEstadoEnfermedadAnimal();
            if (tabla_id_estado != null && tabla_id_estado.Rows.Count != 0)
            {
                id_estado = Convert.ToInt32(tabla_id_estado.Rows[0]["IDTipoEstadoAnimal"]);
                clase_modulo_animal.ModificarEstadoAnimal((int)cbxAnimales.SelectedValue, id_estado);
            }
        }

        private void dgvEmfermedades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                bandera = true;
                id_enfermedad = (int)dgvEmfermedades[0, f].Value;
                clase_general.SeleccionarItem(cbxAnimales, dgvEmfermedades[1, f].Value.ToString());
                clase_general.SeleccionarItem(cbxEnfermedades, dgvEmfermedades[2, f].Value.ToString());
                tbxObservaciones.Text = dgvEmfermedades[3, f].Value.ToString();
            }
        }
    }
}
