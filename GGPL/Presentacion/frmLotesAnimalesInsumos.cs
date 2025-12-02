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
    public partial class frmLotesAnimalesInsumos : Form
    {
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static csGeneral clase_general = new csGeneral();
        static private frmLotesAnimalesInsumos instancia = null;
        static frmGestionLoteInsumos frm_lote_insumos = frmGestionLoteInsumos.Formulario();
        static frmGestionLoteAnimales frm_lote = frmGestionLoteAnimales.Formulario();

        public static frmLotesAnimalesInsumos Formulario()
        {
            if (instancia == null) { instancia = new frmLotesAnimalesInsumos(); }
            return instancia;
        }

        public frmLotesAnimalesInsumos()
        {
            InitializeComponent();
        }

        public void MostrarLotesAnimales()
        {
            clase_general.AjustarTabla(dgvLotesAnimales, clase_modulo_animal.ListaLotesAnimales());
            //clase_general.AjustarTabla(dgvLotesInsumos, clase_modulo_animal.ListaLotesInsumos());
        }

        private void lbAgregar01_Click(object sender, EventArgs e)
        {
            frm_lote.CargarCombobox();
            frm_lote.ShowDialog();
        }

        private void lbAgregar02_Click(object sender, EventArgs e)
        {
            //frm_lote_insumos.CargarCombobox();
            //frm_lote_insumos.ShowDialog();
        }

        private void dgvLotesInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                frm_lote_insumos.CargarCombobox();
                frm_lote_insumos.bandera = true;
                frm_lote_insumos.id_lote_insumo = dgvLotesInsumos[0, f].Value.ToString();
                frm_lote_insumos.tbxCodigo.Text = dgvLotesInsumos[1, f].Value.ToString();
                clase_general.SeleccionarItem(frm_lote_insumos.cbxTipoLote, dgvLotesInsumos[2, f].Value.ToString());
                frm_lote_insumos.tbxDistribuidor.Text = dgvLotesInsumos[3, f].Value.ToString();
                frm_lote_insumos.dtpFechaFabricacion.Value = (DateTime)dgvLotesInsumos[4, f].Value;
                frm_lote_insumos.dtpFechaCaducidad.Value = (DateTime)dgvLotesInsumos[5, f].Value;
                frm_lote_insumos.ShowDialog();

            }
        }

        private void dgvLotesAnimales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                frm_lote.CargarCombobox();
                frm_lote.bandera = true;
                frm_lote.id_lote_animal = dgvLotesAnimales[0, f].Value.ToString();
                frm_lote.tbxCodigo.Text = dgvLotesAnimales[1, f].Value.ToString();
                clase_general.SeleccionarItem(frm_lote.cbxTipoLote, dgvLotesAnimales[2, f].Value.ToString());
                clase_general.SeleccionarItem(frm_lote.cbxHectareas, dgvLotesAnimales[3, f].Value.ToString());
                frm_lote.tbxCapacidad.Text = dgvLotesAnimales[4, f].Value.ToString();
                frm_lote.ShowDialog();
            }
        }
    }
}
