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
    public partial class frmResumen : Form
    {
        static frmResumen instancia = null;
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();

        public static frmResumen Formulario()
        {
            if(instancia == null) { instancia = new frmResumen(); }
            return instancia;
        }

        public frmResumen()
        {
            InitializeComponent();
        }

        public void CargarGrafico()
        {
            chGraficoHLA.Series[0].Points.Clear();
            chProduccionPorRaza.Series[0].Points.Clear();
            DataTable tabla_auxiliar = clase_modulo_animal.VistaGeneralHectareasLotesAnimales();
            DataTable tabla_auxiliar01 = clase_modulo_animal.ProduccionPorRazaAnimal();
            for (int i = 0; i < tabla_auxiliar.Columns.Count; i++)
            {
                chGraficoHLA.Series[0].Points.AddXY(tabla_auxiliar.Columns[i].ColumnName, tabla_auxiliar.Rows[0][i].ToString());
            }
            for (int f = 0; f < tabla_auxiliar01.Rows.Count; f++)
            {
                chProduccionPorRaza.Series[0].Points.AddXY(tabla_auxiliar01.Rows[f][0].ToString(), Convert.ToDecimal(tabla_auxiliar01.Rows[f][1]));
            }
        }
    }
}
