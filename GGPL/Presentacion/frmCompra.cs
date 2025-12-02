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
    public partial class frmCompra : Form
    {
        static csModuloTransacccion clase_modulo_transaccion = new csModuloTransacccion();
        static csGeneral clase_general = new csGeneral();
        static private frmCompra instancia = null;
        public void CargarTabla()
        {
            clase_general.AjustarTabla(dgvCompras, clase_modulo_transaccion.CargarDatosTablaCompra());
        }
        public static frmCompra Formulario()
        {
            if (instancia == null) { instancia = new frmCompra(); }
            return instancia;
        }

        public frmCompra()
        {
            InitializeComponent();
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            frmGestionCompra frm = new frmGestionCompra();
            this.AddOwnedForm(frm);
            frm.CargarCombobox();
            frm.ShowDialog();
        }
    }
}
