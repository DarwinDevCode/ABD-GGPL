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
    public partial class frmProduccionLechera : Form
    {

        static csModuloProduccionLechera clase_modulo_produccion_lechera = new csModuloProduccionLechera();
        static private frmProduccionLechera instancia = null;
        static csGeneral clase_general = new csGeneral();
        static frmGestionProduccionLeche formulario = frmGestionProduccionLeche.Formulario();

        public static frmProduccionLechera Formulario()
        {
            if (instancia == null) { instancia = new frmProduccionLechera(); }
            return instancia;
        }

        public frmProduccionLechera()
        {
            InitializeComponent();
        }

        public void MostrarProduccionLechera()
        {
            clase_general.AjustarTabla(dgvProduccionLechera, clase_modulo_produccion_lechera.ListaProduccionLechera());
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            formulario.CargarCombobox();
            formulario.ShowDialog();
        }

        private void dgvProduccionLechera_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                formulario.CargarCombobox();
                formulario.bandera = true;
                formulario.id_produccion = (int)dgvProduccionLechera[0, f].Value;
                clase_general.SeleccionarItem(formulario.cbxAnimales, dgvProduccionLechera[2, f].Value.ToString());
                formulario.tbxLecheProducida.Text = dgvProduccionLechera[3, f].Value.ToString();
                formulario.cbxTipoOrdeño.SelectedItem = dgvProduccionLechera[4, f].Value.ToString();
                formulario.ShowDialog();
            }
        }
    }
}
