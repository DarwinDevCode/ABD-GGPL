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
    public partial class frmTiposAnimalesEspeciesRazas : Form
    {
        static csGeneral clase_general = new csGeneral();
        static csModuloAnimal clase_modulo_animal = new csModuloAnimal();
        static private frmTiposAnimalesEspeciesRazas instancia = null;
        static bool bandera_tipo_animal = false, bandera_tipo_raza = false, bandera_tipo_especie = false;
        static string id_tipo_animal = "", id_tipo_raza = "", id_tipo_especie = "";
        
        
        public static frmTiposAnimalesEspeciesRazas Formulario()
        {
            if (instancia == null) { instancia = new frmTiposAnimalesEspeciesRazas(); }
            return instancia;
        }

        public frmTiposAnimalesEspeciesRazas()
        {
            InitializeComponent();
        }

        public void MostrarTipos()
        {
            clase_general.AjustarTabla(dgvTipoAnimales, clase_modulo_animal.ListaTiposAnimales());
            clase_general.AjustarTabla(dgvTipoEspecies, clase_modulo_animal.ListaTiposEspecies());
            clase_general.AjustarTabla(dgvTipoRazas, clase_modulo_animal.ListaTiposRazas());
        }

        public void CargarCombobox()
        {
            clase_general.RellenarLista(cbxAnimal, clase_modulo_animal.ListaTiposAnimales());
            clase_general.RellenarLista(cbxEspecie, clase_modulo_animal.ListaTiposEspeciesCombobox());
        }

        private void btnGuardar01_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bandera_tipo_animal)
                {
                    bool resultado = clase_modulo_animal.RegistrarTipoAnimal(tbxTipoAnimal.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de animal registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTiposAnimal();
                        MostrarTipos();
                        CargarCombobox();
                    }
                    else
                        MessageBox.Show("No se pudo registrar el tipo de animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool resultado = clase_modulo_animal.ModificarTipoAnimal(id_tipo_animal, tbxTipoAnimal.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Tipo de animal modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTiposAnimal();
                        MostrarTipos();
                        bandera_tipo_animal = false;
                    }
                    else
                        MessageBox.Show("No se pudo modificar el tipo de animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LimpiarTiposAnimal()
        {
            tbxTipoAnimal.Clear();
        }

        private void btnGuardar02_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bandera_tipo_especie)
                {
                    if (cbxAnimal.SelectedIndex != -1) 
                    {
                        bool resultado = clase_modulo_animal.RegistrarTipoEspecieAnimal(cbxAnimal.SelectedValue.ToString(), tbxTipoEspecie.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Tipo de especie registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarTiposEspecies();
                            MostrarTipos();
                            CargarCombobox();
                        }
                        else
                            MessageBox.Show("No se pudo registrar el tipo de especie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
                }
                else
                {
                    if (cbxAnimal.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.ModificarTipoEspecieAnimal(id_tipo_especie, cbxAnimal.SelectedValue.ToString(), tbxTipoEspecie.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Tipo de especie modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarTiposEspecies();
                            MostrarTipos();
                            bandera_tipo_especie = false;
                        }
                        else
                            MessageBox.Show("No se pudo modificar el tipo de especie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
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

        public void LimpiarTiposEspecies()
        {
            tbxTipoEspecie.Clear();
            cbxAnimal.SelectedIndex = -1;
        }

        private void btnGuardar03_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bandera_tipo_raza)
                {
                    if (cbxEspecie.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.RegistrarTipoRazaAnimal(cbxEspecie.SelectedValue.ToString(), tbxTipoRaza.Text);
                        if (resultado)
                        {
                            MessageBox.Show("Tipo de raza registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarTiposRazas();
                            MostrarTipos();
                            CargarCombobox();
                        }
                        else
                            MessageBox.Show("No se pudo registrar el tipo de raza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                 
                }
                else
                {
                    if (cbxEspecie.SelectedIndex != -1)
                    {
                        bool resultado = clase_modulo_animal.ModificarTipoRazaAnimal(id_tipo_raza, tbxTipoRaza.Text, cbxEspecie.SelectedValue.ToString());
                        if (resultado)
                        {
                            MessageBox.Show("Tipo de raza modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarTiposRazas();
                            MostrarTipos();
                            bandera_tipo_raza = false;
                        }
                        else
                            MessageBox.Show("No se pudo modificar el tipo de raza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
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

        public void LimpiarTiposRazas()
        {
            tbxTipoRaza.Clear();
            cbxEspecie.SelectedIndex = -1;
        }

        private void dgvTipoAnimales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                bandera_tipo_animal = true;
                id_tipo_animal = dgvTipoAnimales[0, f].Value.ToString();
                tbxTipoAnimal.Text = dgvTipoAnimales[1, f].Value.ToString();
            }
        }

        private void dgvTipoEspecies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                bandera_tipo_especie = true;
                id_tipo_especie = dgvTipoEspecies[0, f].Value.ToString();
                clase_general.SeleccionarItem(cbxAnimal, dgvTipoEspecies[1, f].Value.ToString());
                tbxTipoEspecie.Text = dgvTipoEspecies[2, f].Value.ToString();
            }
        }

        private void dgvTipoRazas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f >= 0)
            {
                bandera_tipo_raza = true;
                id_tipo_raza = dgvTipoRazas[0, f].Value.ToString();
                clase_general.SeleccionarItem(cbxEspecie, dgvTipoRazas[1, f].Value.ToString());
                tbxTipoRaza.Text = dgvTipoRazas[2, f].Value.ToString();
            }
        }
    }
}
