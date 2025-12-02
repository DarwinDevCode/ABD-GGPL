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
    public partial class frmGestionLoteInsumos : Form
    {
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static private frmGestionLoteInsumos instancia = null;
        public bool bandera = false; public string id_lote_insumo = "";
        static frmLotesAnimalesInsumos frm = frmLotesAnimalesInsumos.Formulario();

        public static frmGestionLoteInsumos Formulario()
        {
            if (instancia == null) { instancia = new frmGestionLoteInsumos(); }
            return instancia;
        }

        public frmGestionLoteInsumos()
        {
            InitializeComponent();
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cbxTipoLote, clase_modulo_animal.ListaTipoLoteInsumosCombobox());
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
                    if(cbxTipoLote.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.RegistrarLoteInsumo(tbxCodigo.Text, cbxTipoLote.SelectedValue.ToString(), tbxDistribuidor.Text, dtpFechaFabricacion.Value.Date.ToString(), dtpFechaCaducidad.Value.Date.ToString(), DateTime.Now.ToString());
                        if (resultado)
                        {
                            MessageBox.Show("Lote de insumo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm.MostrarLotesAnimales();
                            LimpiarControles();
                        }
                        else
                            MessageBox.Show("No se pudo registrar el lote de insumo (Lote ya registrado o formato incorrecto).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (cbxTipoLote.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.ModificarLoteInsumo(id_lote_insumo, tbxCodigo.Text, cbxTipoLote.SelectedValue.ToString(), tbxDistribuidor.Text, dtpFechaFabricacion.Value.Date.ToString(), dtpFechaCaducidad.Value.Date.ToString(), DateTime.Now.ToString());
                        if (resultado)
                        {
                            MessageBox.Show("Lote de insumo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm.MostrarLotesAnimales();
                            LimpiarControles();
                            bandera = false;
                        }
                        else
                            MessageBox.Show("No se pudo modificar el lote de insumo (Lote ya registrado o formato incorrecto).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbxCodigo.Clear();
            tbxDistribuidor.Clear();
            cbxTipoLote.SelectedIndex = -1;
            dtpFechaCaducidad.Text = DateTime.Now.ToString();
            dtpFechaFabricacion.Text = DateTime.Now.ToString();
        }
    }
}
      