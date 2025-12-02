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
    public partial class frmTipoVacuna : Form
    {
        static private frmTipoVacuna instancia = null;

        public static frmTipoVacuna Formulario()
        {
            if (instancia == null) { instancia = new frmTipoVacuna(); }
            return instancia;
        }
        public frmTipoVacuna()
        {
            InitializeComponent();
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
