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
    public partial class frmAnimales : Form
    {
        static private frmAnimales instancia = null;
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static frmGestionAnimal frm_gestion_animal = frmGestionAnimal.Formulario();
        public frmAnimales()
        {
            InitializeComponent();
        }

        public static frmAnimales Formulario()
        {
            if (instancia == null) { instancia = new frmAnimales(); }
            return instancia;
        }

        public void MostrarAnimales()
        {
            clase_general.AjustarTabla(dgvAnimales, clase_modulo_animal.ListaAnimales());
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            frmGestionAnimal formulario = frmGestionAnimal.Formulario();
            formulario.CargarCombobox();
            formulario.bandera = 1;
            formulario.lbPrecio.Visible = false;
            formulario.tbxPrecio.Visible = false;
            formulario.ShowDialog();
        }

        private void dgvAnimales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                frm_gestion_animal.CargarCombobox();
                frm_gestion_animal.bandera = 2;
                frm_gestion_animal.id_animal = (int)dgvAnimales[0, f].Value;
                frm_gestion_animal.tbxPrecio.Visible = false;
                frm_gestion_animal.lbPrecio.Visible = false;
                frm_gestion_animal.cbxEstadoAnimal.Visible = true;
                frm_gestion_animal.lbEstado.Visible = true;

                frm_gestion_animal.tbxCodigo.Text = dgvAnimales[1, f].Value.ToString();

                clase_general.SeleccionarItem(frm_gestion_animal.cbxLote, dgvAnimales[2, f].Value.ToString());
                clase_general.SeleccionarItem(frm_gestion_animal.cbxRaza, dgvAnimales[3, f].Value.ToString());
                frm_gestion_animal.cbxSexo.SelectedItem = dgvAnimales[4, f].Value.ToString();
                clase_general.SeleccionarItem(frm_gestion_animal.cbxEstadoAnimal, dgvAnimales[6, f].Value.ToString());

                frm_gestion_animal.dtpFechaNacimiento.Value = DateTime.Parse(dgvAnimales[5, f].Value.ToString());
                frm_gestion_animal.ShowDialog();
            }
        }
    }
}
