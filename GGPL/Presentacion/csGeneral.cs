using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal class csGeneral
    {
        public void SeleccionarItem(ComboBox lista, string dato)
        {
            foreach (object item in lista.Items)
            {
                if ((item as DataRowView)[1].ToString() == dato)
                {
                    lista.SelectedItem = item;
                    break;
                }
            }

        }

        public void RellenarLista(ComboBox lista, DataTable datos)
        {
            lista.DataSource = datos;
            lista.ValueMember = datos.Columns[0].ColumnName;
            lista.DisplayMember = datos.Columns[1].ColumnName;
            lista.SelectedIndex = -1;
        }

        public void AjustarTabla(DataGridView tabla, DataTable datos, bool bandera = false)
        {
            tabla.DataSource = datos;

            if (bandera)
            {
                foreach (DataGridViewColumn col in tabla.Columns)
                    col.ReadOnly = true;
                tabla.Columns["Precio"].ReadOnly = false;
            }

            int anchodgv = tabla.ClientSize.Width - 21;
            int anchocolumn = anchodgv / tabla.Columns.Count;

            for (int i = 0; i < tabla.ColumnCount - 1; i++)
                tabla.Columns[i].Width = anchocolumn;
            tabla.Columns[tabla.Columns.Count - 1].Width = anchodgv - (anchocolumn * (tabla.Columns.Count - 1));
        }
    }
}
