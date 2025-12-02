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
    public partial class frmSeleccionarAnimales : Form
    {
        static csModuloTransacccion clase_compra_ventas = new csModuloTransacccion();

        static csGeneral clase_general = new csGeneral();
        static private frmSeleccionarAnimales instancia = null;
        
        public void CargarTabla()
        {
            clase_general.AjustarTabla(dgvAnimales, clase_compra_ventas.CargarDatosTablaVentaAnimales(), true);
        }

        public static frmSeleccionarAnimales Formulario()
        {
            if (instancia == null) { instancia = new frmSeleccionarAnimales(); }
            return instancia;
        }

        public frmSeleccionarAnimales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblVender_Click(object sender, EventArgs e)
        {
            frmGestionVenta frm = Owner as frmGestionVenta;
            foreach (DataGridViewRow fila in dgvAnimales.SelectedRows)
            {
                if (fila.Cells["Precio"] != null )
                {
                    try
                    {
                        var precioaux = fila.Cells["Precio"].Value;
                        if (decimal.TryParse(precioaux.ToString(), out decimal precio) && precio > 0)
                        {
                            int id_animal = (int)fila.Cells[0].Value;
                            string codigo_animal = fila.Cells[1].Value.ToString();
                            frm.animales.Add((id_animal, codigo_animal, precio));
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            frm.CargarAnimalesSeleccionados();
            this.Hide();
        }

        private void dgvAnimales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
