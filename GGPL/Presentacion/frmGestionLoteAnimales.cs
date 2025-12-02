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
    public partial class frmGestionLoteAnimales : Form
    {
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static csGeneral clase_general = new csGeneral();
        static private frmGestionLoteAnimales instancia = null;
        static frmLotesAnimalesInsumos formulario = frmLotesAnimalesInsumos.Formulario();
        public bool bandera = false; public string id_lote_animal = "";
        public static frmGestionLoteAnimales Formulario()
        {
            if (instancia == null) { instancia = new frmGestionLoteAnimales(); }
            return instancia;
        }

        public frmGestionLoteAnimales()
        {
            InitializeComponent();
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cbxHectareas, clase_modulo_animal.ListaHectareasCombobox());
            clase_general.RellenarLista(cbxTipoLote, clase_modulo_animal.ListaTiposLotesAnimalesCombobox());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bandera)
                {
                    if(cbxHectareas.SelectedIndex != -1 && cbxTipoLote.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.RegistrarLoteAnimales(tbxCodigo.Text, cbxHectareas.SelectedValue.ToString(), cbxTipoLote.SelectedValue.ToString(), tbxCapacidad.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Lote de animales registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formulario.MostrarLotesAnimales();
                            LimpiarControles();
                        }
                        else
                            MessageBox.Show("No se pudo registrar el lote de animales (Lote ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }        
                }
                else
                {
                    if (cbxHectareas.SelectedIndex != -1 && cbxTipoLote.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.ModificarLoteAnimales
                        (id_lote_animal, tbxCodigo.Text, cbxHectareas.SelectedValue.ToString(),
                        cbxTipoLote.SelectedValue.ToString(), tbxCapacidad.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Lote de animales modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bandera = false;
                            formulario.MostrarLotesAnimales();
                            LimpiarControles();
                        }
                        else
                            MessageBox.Show("No se pudo modificar el lote de animales (Lote ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                      
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
            tbxCapacidad.Clear();
            tbxCodigo.Clear();
            cbxHectareas.SelectedIndex = -1;
            cbxTipoLote.SelectedIndex = -1;
        }
    }
}