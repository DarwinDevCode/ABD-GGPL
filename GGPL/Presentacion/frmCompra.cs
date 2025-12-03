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
            frm.bandera = 0;
            frm.CargarCombobox();
            frm.ShowDialog();
        }

        private void dgvCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = (int)e.RowIndex;
            if (f>=0)
            {
                frmDetalleCompra frm = frmDetalleCompra.Formulario();
                frm.id_transaccion = (int)dgvCompras[0, f].Value;
                frm.txtTipoPago.Text = dgvCompras[2, f].Value.ToString();
                frm.txtUsuario.Text = dgvCompras[1, f].Value.ToString();
                frm.txtValorTotal.Text = dgvCompras[4, f].Value.ToString();

                frm.CargarDatos();
                frm.ShowDialog();
            }
        }
    }
}
