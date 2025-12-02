using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negociacion;

namespace Presentacion
{
    public partial class frmGestionVenta : Form
    {
        static csGeneral clase_general = new csGeneral();
        static csModuloTransacccion clase_compra_venta = new csModuloTransacccion();  
        static frmPantallaPrincipal formulario = frmPantallaPrincipal.Formulario();
        public List<(int id_animal, string codigo_animal, decimal precio)> animales = new List<(int, string, decimal)>();
        private decimal valor_total = 0;

        public frmGestionVenta()
        {
            InitializeComponent();
        }

        private void btnSeleccionarAnimales_Click(object sender, EventArgs e)
        {
            frmSeleccionarAnimales frm = new frmSeleccionarAnimales();
            this.AddOwnedForm(frm);
            frm.CargarTabla();
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void CargarAnimalesSeleccionados()
        {
            string aux = "";
            valor_total = 0;
            foreach (var info in animales)
            {
                valor_total += info.precio;
                aux += info.codigo_animal + "\t" + info.precio + "\n";
            }
            txtPrecioTotal.Text = valor_total.ToString();
            rtbAnimales.Text = aux;
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cmbTipoPago, clase_compra_venta.ObtenerTipoPago());
            cmbTipoPago.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool r1 = false, r3 = false;
            int r2;
            (r1, r2) = clase_compra_venta.RegistrarTransaccion(formulario.IDUsuario, 'V', (int)cmbTipoPago.SelectedValue, animales.Count, valor_total, DateTime.Now);
            if (r1)
                foreach (var info in animales)
                    r3 = clase_compra_venta.RegistrarTransaccionVentaAnimal(r2, info.id_animal, info.precio);

            if (r1)
            {
                animales = new List<(int, string, decimal)>(animales);
                foreach (var info in animales)
                    clase_compra_venta.ActualizarEstadoAnimalVenta(info.id_animal);
            }

            if (r1 && r3)
            {
                MessageBox.Show("VENTA REALIZADA CON EXITO.");
                LimpiarControles();
                frmVenta frm = Owner as frmVenta;
                frm.CargarTabla();
            }
            else
                MessageBox.Show("ERROR AL REALIZAR LA VENTA.");


        }

        public void LimpiarControles()
        {
            cmbTipoPago.SelectedIndex = -1;
            txtPrecioTotal.Clear();
            rtbAnimales.Clear();
        }
    }
}
