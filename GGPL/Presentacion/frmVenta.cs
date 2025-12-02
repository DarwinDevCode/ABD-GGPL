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
    public partial class frmVenta : Form
    {
        static csModuloTransacccion clase_produccion_lechera = new csModuloTransacccion();
        static csGeneral clase_general = new csGeneral();
        static private frmVenta instancia = null;
        public void CargarTabla()
        {
            clase_general.AjustarTabla(dgvVentas, clase_produccion_lechera.CargarDatosTablaVenta());
        }

        public static frmVenta Formulario()
        {
            if (instancia == null) { instancia = new frmVenta(); }
            return instancia;
        }

        public frmVenta()
        {
            InitializeComponent();
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            frmGestionVenta frm = new frmGestionVenta();
            this.AddOwnedForm(frm);
            frm.CargarCombobox();
            frm.ShowDialog();
        }

       
    }
}
