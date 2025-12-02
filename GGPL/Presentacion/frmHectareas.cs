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
    public partial class frmHectareas : Form
    {

        static private frmHectareas instancia = null;
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static frmGestionHectareas formulario = frmGestionHectareas.Formulario();

        public static frmHectareas Formulario()
        {
            if (instancia == null) { instancia = new frmHectareas(); }
            return instancia;
        }

        public frmHectareas()
        {
            InitializeComponent();
        }

        public void MostrarHectareas()
        {
            clase_general.AjustarTabla(dgvHectareas, clase_modulo_animal.ListaHectareas());
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            formulario.ShowDialog();
        }

        private void dgvHectareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = (int)e.RowIndex;
            if (f >= 0)
            {
                formulario.bandera = true;
                formulario.id_hectarea = dgvHectareas[0, f].Value.ToString();
                formulario.tbxCodigo.Text = dgvHectareas[1, f].Value.ToString();
                formulario.tbxArea.Text = dgvHectareas[2, f].Value.ToString();
                formulario.ShowDialog();
            }


        }
    }
}
