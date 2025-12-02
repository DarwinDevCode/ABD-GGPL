using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmTipoMedicamento : Form
    {
        static private frmTipoMedicamento instancia = null;

        public static frmTipoMedicamento Formulario()
        {
            if (instancia == null) { instancia = new frmTipoMedicamento(); }
            return instancia;
        }
        public frmTipoMedicamento()
        {
            InitializeComponent();
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            //frmGestionTipoMedicamento frm = new frmGestionTipoMedicamento(); frm.ShowDialog();
        }
    }
}
