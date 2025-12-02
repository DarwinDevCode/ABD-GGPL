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
using static System.Windows.Forms.MonthCalendar;

namespace Presentacion
{
    public partial class frmGestionHectareas : Form
    {
        static private frmGestionHectareas instancia = null;
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static frmHectareas formulario = frmHectareas.Formulario();

        public bool bandera = false; public string id_hectarea = "";
        public static frmGestionHectareas Formulario()
        {
            if (instancia == null) { instancia = new frmGestionHectareas(); }
            return instancia;
        }

        public frmGestionHectareas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bandera)
                {
                    bool resultado = clase_modulo_animal.RegistrarHectarea(tbxCodigo.Text, tbxArea.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Hectárea registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        formulario.MostrarHectareas();
                        LimpiarControles();
                    }
                    else
                        MessageBox.Show("No se pudo registrar la hectárea (Hectarea ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool resultado = clase_modulo_animal.ModificarHectarea(id_hectarea, tbxCodigo.Text, tbxArea.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Hectárea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bandera = false;
                        formulario.MostrarHectareas();
                        LimpiarControles();
                    }
                    else
                        MessageBox.Show("No se pudo actualizar la hectárea (Hectarea ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LimpiarControles()
        {
            tbxArea.Clear();
            tbxCodigo.Clear();
        }
    }
}
