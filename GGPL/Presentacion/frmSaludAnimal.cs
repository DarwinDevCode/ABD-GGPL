using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negociacion;

namespace Presentacion
{
    public partial class frmSaludAnimal : Form
    {
        private static frmSaludAnimal instancia = null;
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static frmGestionSaludAnimal frm_gestion_salud_animal = frmGestionSaludAnimal.Formulario();
        public static frmSaludAnimal Formulario()
        {
            if (instancia == null) { instancia = new frmSaludAnimal(); }
            return instancia;
        }

        public frmSaludAnimal()
        {
            InitializeComponent();
        }

        public void MostrarSaludGeneral()
        {
            clase_general.AjustarTabla(dgvSaludAnimales, clase_modulo_animal.ListaSaludGeneral());
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            frm_gestion_salud_animal.CargarControles();
            frm_gestion_salud_animal.ShowDialog();
        }
    }
}
