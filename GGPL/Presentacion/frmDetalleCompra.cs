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
    public partial class frmDetalleCompra : Form
    {
        csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        csGeneral clase_general = new csGeneral();
        public int id_transaccion = 0;

        static private frmDetalleCompra instancia = null;
        public static frmDetalleCompra Formulario()
        {
            if (instancia == null) { instancia = new frmDetalleCompra(); }
            return instancia;
        }

        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            clase_general.AjustarTabla(dgvDetalleCompra, clase_modulo_animal.ListaAnimalCompra(id_transaccion));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
