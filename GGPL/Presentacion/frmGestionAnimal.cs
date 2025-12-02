using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negociacion;

namespace Presentacion
{
    public partial class frmGestionAnimal : Form
    {
        static csModuloAnimal clase_animales = new csModuloAnimal();
        static csGeneral clase_general = new csGeneral();
        static private frmGestionAnimal instancia = null;
        public int bandera, id_animal;
        static frmAnimales formulario = frmAnimales.Formulario();

        public static frmGestionAnimal Formulario()
        {
            if (instancia == null) { instancia = new frmGestionAnimal(); }
            return instancia;
        }

        public frmGestionAnimal()
        {
            InitializeComponent();
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cbxEstadoAnimal, clase_animales.ListaTipoEstadosCombobox());
            clase_general.RellenarLista(cbxLote, clase_animales.ListaLotesAnimalesCombobox());
            clase_general.RellenarLista(cbxRaza, clase_animales.ListaTiposRazasCombobox());
            cbxEstadoAnimal.SelectedIndex = -1;
            cbxLote.SelectedIndex = -1;
            cbxRaza.SelectedIndex = -1;
            cbxSexo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bandera == 1)
                {
                    if(cbxEstadoAnimal.SelectedIndex != -1 && cbxLote.SelectedIndex != -1 && cbxRaza.SelectedIndex != -1 && cbxSexo.SelectedIndex != -1)
                    {
                        bool r1;
                        int r2;
                        (r1, r2) = clase_animales.RegistrarAnimal(tbxCodigo.Text.Trim(), cbxLote.SelectedValue.ToString(), cbxRaza.SelectedValue.ToString(), cbxSexo.Text, dtpFechaNacimiento.Value.Date.ToString(), DateTime.Now.ToString(), cbxEstadoAnimal.SelectedValue.ToString());

                        if (r1)
                        {
                            MessageBox.Show($"Animal registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formulario.MostrarAnimales();
                            LimpiarControles();
                        }
                        else
                            MessageBox.Show("No se pudo registrar el animal (Animal ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (bandera == 2)
                {
                    if (cbxEstadoAnimal.SelectedIndex != -1 && cbxLote.SelectedIndex != -1 && cbxRaza.SelectedIndex != -1 && cbxSexo.SelectedIndex != -1)
                    {
                        bool result = clase_animales.ModificarAnimal(id_animal.ToString(), tbxCodigo.Text, cbxLote.SelectedValue.ToString(), cbxRaza.SelectedValue.ToString(), cbxSexo.SelectedItem.ToString(), dtpFechaNacimiento.Value.Date.ToString(), DateTime.Now.ToString(), cbxEstadoAnimal.SelectedValue.ToString());

                        if (result)
                        {
                            MessageBox.Show($"Animal modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            formulario.MostrarAnimales();
                            bandera = 1;
                            LimpiarControles();
                        }
                        else
                            MessageBox.Show("No se pudo modificar el animal (Animal ya existente o formatos incorrectos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (bandera == 3)
                {
                    string codigo = tbxCodigo.Text;
                    int id_lote = (int)cbxLote.SelectedValue;
                    int id_raza = (int)cbxRaza.SelectedValue;
                    char sexo = Convert.ToChar(cbxSexo.Text);
                    DateTime fecha_nacimiento = dtpFechaNacimiento.Value.Date;
                    DateTime fecha_hora_registro = DateTime.Now;
                    decimal precio = Convert.ToDecimal(tbxPrecio.Text);

                    frmGestionCompra formulario = Owner as frmGestionCompra;
                    formulario.animal.Add((codigo, id_lote, id_raza, sexo, fecha_nacimiento, fecha_hora_registro, precio));
                    formulario.rtbAnimales.Text += tbxCodigo.Text + "\t" + tbxPrecio.Text + Environment.NewLine;
                    formulario.total = formulario.total + Convert.ToDecimal(tbxPrecio.Text);
                    LimpiarControles();
                    this.Close();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarControles()
        {
            tbxCodigo.Text = String.Empty;
            tbxPrecio.Clear();
            cbxLote.SelectedIndex = -1;
            cbxRaza.SelectedIndex = -1;
            cbxSexo.SelectedIndex = -1;
            cbxEstadoAnimal.SelectedIndex = -1;
            dtpFechaNacimiento.Text = DateTime.Now.ToString();
        }
    }
}
