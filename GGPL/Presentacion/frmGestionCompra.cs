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
    public partial class frmGestionCompra : Form
    {
        static csGeneral clase_general = new csGeneral();
        static csModuloTransacccion clase_compra_venta = new csModuloTransacccion();
        static csModuloAnimal clase_animales = new csModuloAnimal();
        static frmPantallaPrincipal frm = frmPantallaPrincipal.Formulario();
        public List<(string codigo, int lote, int raza, char sexo, DateTime fecha_nacimiento, DateTime fecha_hora_registro, decimal precio)> animal = new List<(string, int, int, char, DateTime, DateTime, decimal)>();
        static frmGestionCompra instancia = null;
        public decimal total = 0;
        public int bandera=0;

        public frmGestionCompra()
        {
            InitializeComponent();
        }

        public static frmGestionCompra Formulario()
        {
            if (instancia == null) { instancia = new frmGestionCompra(); }
            return instancia;
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cmbTipoPago, clase_compra_venta.ObtenerTipoPago());
            cmbTipoPago.SelectedIndex = -1;
        }

        private void btnSeleccionarAnimales_Click(object sender, EventArgs e)
        {
            frmGestionAnimal frm = frmGestionAnimal.Formulario();
            this.AddOwnedForm(frm);
            frm.CargarCombobox();
            frm.LimpiarControles();
            frm.bandera = 3;
            frm.lbPrecio.Visible = true;
            frm.tbxPrecio.Visible = true;
            frm.cbxEstadoAnimal.Visible = false;
            frm.lbEstado.Visible = false;
            frm.ShowDialog();
            txtPrecioTotal.Text = total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(bandera == 0)
                {
                    bool r1, r3;
                    int r2, r4;
                    (r1, r2) = clase_compra_venta.RegistrarTransaccion(frm.IDUsuario, 'C', (int)cmbTipoPago.SelectedValue, animal.Count, Convert.ToDecimal(txtPrecioTotal.Text), DateTime.Now);
                    if (r1)
                    {
                        foreach (var info in animal)
                        {
                            (r3, r4) = clase_animales.RegistrarAnimal(info.codigo.ToString(), info.lote.ToString(), info.raza.ToString(), info.sexo.ToString(), info.fecha_nacimiento.ToString(), info.fecha_hora_registro.ToString(), "7");
                            clase_compra_venta.RegistrarTransaccionVentaAnimal(r2, r4, info.precio);
                        }
                        frmCompra frm = frmCompra.Formulario();
                        frm.CargarTabla();
                        MessageBox.Show($"Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                    else
                        MessageBox.Show("No se pudo registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(bandera == 1)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        public void LimpiarControles()
        {
            cmbTipoPago.SelectedIndex = -1;
            rtbAnimales.Text = string.Empty;
            txtPrecioTotal.Text = string.Empty;
        }
    }
}
