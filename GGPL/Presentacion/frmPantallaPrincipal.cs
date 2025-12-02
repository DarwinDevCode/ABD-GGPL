using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Presentacion
{
    public partial class frmPantallaPrincipal : Form
    {
        static bool Animales = false, Produccion = false, Transaccion = false, Gestion = false, Reportes = false, Usuarios = false;
        private Dictionary<Control, Point> posicionesOriginales = new Dictionary<Control, Point>();
        private Dictionary<string, Button> botonesListBox = new Dictionary<string, Button>();
        static private frmPantallaPrincipal instancia = null;

        public int IDUsuario; 
        public string Usuario;

        public frmPantallaPrincipal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public static frmPantallaPrincipal Formulario()
        {
            if (instancia == null) { instancia = new frmPantallaPrincipal(); }
            return instancia;
        }

        private void ManejarListBox(Button boton, PictureBox pictureBox, ListBox listBox, ref bool estado)
        {
            this.SuspendLayout();
            CerrarOtrosListboxes(boton);
            RegresarControlesPosicionOriginal();

            if (!estado)
            {
                pictureBox.BackgroundImage = ListaFlecha.Images[0];
                listBox.Visible = true;
                listBox.Location = new Point(15, boton.Location.Y + boton.Height + 10);
                estado = true;

                MoverControlesAjustados(listBox.Height, boton);
            }
            else
            {
                pictureBox.BackgroundImage = ListaFlecha.Images[1];
                listBox.Visible = false;
                estado = false;
                listBox.SelectedIndex = -1;
            }
            this.ResumeLayout(false);
        }

        private void MoverControlesAjustados(int alturaListBox, Button botonClickeado)
        {
            int espacioAdicional = 10;

            List<Button> botonesOrdenados = new List<Button> { btnAnimales, btnProduccion, btnTransaccion, btnGestion, btnUsuarios };
            int indiceBotonClickeado = botonesOrdenados.IndexOf(botonClickeado);

            if (indiceBotonClickeado == -1) return;

            Dictionary<Button, PictureBox> mapaBtnPtbx = new Dictionary<Button, PictureBox>
            {
                { btnAnimales, ptbxAnimales },
                { btnProduccion, ptbxProduccion },
                { btnTransaccion, ptbxTransaccion },
                { btnGestion, ptbxGestion },
                { btnUsuarios, ptbxUsuarios }
            };

            int desplazamientoTotal = alturaListBox + espacioAdicional;

            for (int i = indiceBotonClickeado + 1; i < botonesOrdenados.Count; i++)
            {
                Button btn = botonesOrdenados[i];

                int posOriginalY = posicionesOriginales[btn].Y;
                int nuevaPosY = posOriginalY + desplazamientoTotal;
                btn.Location = new Point(btn.Location.X, nuevaPosY);

                if (mapaBtnPtbx.ContainsKey(btn))
                {
                    PictureBox ptbx = mapaBtnPtbx[btn];
                    int centroBotonY = nuevaPosY + (btn.Height / 2);
                    ptbx.Location = new Point(ptbx.Location.X, centroBotonY - (ptbx.Height / 2));
                }
            }
        }

        private void CerrarOtrosListboxes(Button botonActual)
        {
            if (Produccion && botonesListBox["btnProduccion"] != botonActual)
            {
                contenedorProduccion.Visible = false;
                ptbxProduccion.BackgroundImage = ListaFlecha.Images[1];
                Produccion = false;
            }
            if (Transaccion && botonesListBox["btnTransaccion"] != botonActual)
            {
                contenedorTransacciones.Visible = false;
                ptbxTransaccion.BackgroundImage = ListaFlecha.Images[1];
                Transaccion = false;
            }
            if (Gestion && botonesListBox["btnGestion"] != botonActual)
            {
                contenedorGestion.Visible = false;
                ptbxGestion.BackgroundImage = ListaFlecha.Images[1];
                Gestion = false;
            }
            if (Animales && botonesListBox["btnAnimales"] != botonActual)
            {
                contenedorAnimales.Visible = false;
                ptbxAnimales.BackgroundImage = ListaFlecha.Images[1];
                Animales = false;
            }
            if (Usuarios && botonesListBox["btnUsuarios"] != botonActual)
            {
                contenedorUsuarios.Visible = false;
                ptbxUsuarios.BackgroundImage = ListaFlecha.Images[1];
                Usuarios = false;
            }
        }

        private void RegresarControlesPosicionOriginal()
        {
            foreach (var control in posicionesOriginales)
                control.Key.Location = control.Value;
        }
       
        public void DeshabilitarBotones(string rol)
        {
            btnAnimales.Enabled = false;
            btnProduccion.Enabled = false;
            btnTransaccion.Enabled = false;
            btnGestion.Enabled = false;
            btnUsuarios.Enabled = false;
            switch(rol)
            {
                case "Veterinario":
                    btnAnimales.Enabled = true;
                    break;
                case "Encargado de Produccion":
                    btnProduccion.Enabled = true;
                    break;
                case "Encargado de Transaccion":
                    btnTransaccion.Enabled = true;
                    break;
                case "Administrador":
                    btnAnimales.Enabled = true;
                    btnProduccion.Enabled = true;
                    btnTransaccion.Enabled = true;
                    btnGestion.Enabled = true;
                    btnUsuarios.Enabled = true;
                    break;
            }
        }

        public void LlamarFormulario(Form formulario)
        {
            pnlPrincipal.Controls.Clear();
            formulario.TopLevel = false;
            pnlPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void ConfigurarControles()
        {
            ptbxAnimales.BackgroundImage = ListaFlecha.Images[1];
            ptbxProduccion.BackgroundImage = ListaFlecha.Images[1];
            ptbxGestion.BackgroundImage = ListaFlecha.Images[1];
            ptbxUsuarios.BackgroundImage = ListaFlecha.Images[1];
            ptbxTransaccion.BackgroundImage = ListaFlecha.Images[1];
            ptbxGestion.BackgroundImage = ListaFlecha.Images[1];

            int espacioEntreBotones = 60;
            int alturaBoton = 40;
            int alturaPictureBox = 16;

            int desplazamientoVertical = (alturaBoton - alturaPictureBox) / 2;

            posicionesOriginales.Add(btnAnimales, new Point(0, 96));
            posicionesOriginales.Add(ptbxAnimales, new Point(166, 96 + desplazamientoVertical));

            posicionesOriginales.Add(btnProduccion, new Point(0, 96 + espacioEntreBotones));
            posicionesOriginales.Add(ptbxProduccion, new Point(166, 96 + espacioEntreBotones + desplazamientoVertical));


            posicionesOriginales.Add(btnTransaccion, new Point(0, 96 + (espacioEntreBotones * 2)));
            posicionesOriginales.Add(ptbxTransaccion, new Point(166, 96 + (espacioEntreBotones * 2) + desplazamientoVertical));

            posicionesOriginales.Add(btnGestion, new Point(0, 96 + (espacioEntreBotones * 3)));
            posicionesOriginales.Add(ptbxGestion, new Point(166, 96 + (espacioEntreBotones * 3) + desplazamientoVertical));

            posicionesOriginales.Add(btnUsuarios, new Point(0, 96 + (espacioEntreBotones * 4)));
            posicionesOriginales.Add(ptbxUsuarios, new Point(166, 96 + (espacioEntreBotones * 4) + desplazamientoVertical));

            botonesListBox.Add("btnProduccion", btnProduccion);
            botonesListBox.Add("btnTransaccion", btnTransaccion);
            botonesListBox.Add("btnGestion", btnGestion);
            botonesListBox.Add("btnAnimales", btnAnimales);
            botonesListBox.Add("btnUsuarios", btnUsuarios);
        }


        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
        }

        private void contenedorGestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contenedorGestion.SelectedIndex)
            {
                case 0:
                    frmTiposAnimalesEspeciesRazas frm05 = frmTiposAnimalesEspeciesRazas.Formulario();
                    LlamarFormulario(frm05);
                    frm05.MostrarTipos();
                    frm05.CargarCombobox();
                    break;
                case 1:

                    frmHectareas frm01 = frmHectareas.Formulario();
                    LlamarFormulario(frm01);
                    frm01.MostrarHectareas();
                    break;
                case 2:
                    frmLotesAnimalesInsumos frm02 = frmLotesAnimalesInsumos.Formulario();
                    LlamarFormulario(frm02);
                    frm02.MostrarLotesAnimales();
                    break;
            }
        }

        private void contenedorProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contenedorProduccion.SelectedIndex)
            {
                case 0:
                    frmProduccionLechera frm = frmProduccionLechera.Formulario();
                    frm.MostrarProduccionLechera();
                    LlamarFormulario(frm);
                    break;
            }
        }

        private void contenedorTransacciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contenedorTransacciones.SelectedIndex)
            {
                case 0:
                    frmCompra frm01 = frmCompra.Formulario();
                    frm01.CargarTabla();
                    LlamarFormulario(frm01);
                    break;
                case 1:
                    frmVenta frm02 = frmVenta.Formulario();
                    frm02.CargarTabla();
                    LlamarFormulario(frm02);
                    break;
            }
        }

        private void contenedorUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contenedorUsuarios.SelectedIndex)
            {
                case 0:
                    frmUsuario frm = frmUsuario.Formulario();
                    LlamarFormulario(frm);
                    frm.MostrarUsuarios();
                    break;
            }
        }

        private void contenedorAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contenedorAnimales.SelectedIndex)
            {
                case 0:
                    frmAnimales formulario = frmAnimales.Formulario();
                    LlamarFormulario(formulario);
                    formulario.MostrarAnimales();
                    break;
                case 1:
                    frmEnfermedad formulario02 = frmEnfermedad.Formulario();
                    LlamarFormulario(formulario02);
                    formulario02.MostrarAnimales();
                    formulario02.CargarCombobox();
                    break;
                case 2:
                    frmSaludAnimal frm03 = frmSaludAnimal.Formulario();
                    LlamarFormulario(frm03);
                    frm03.MostrarSaludGeneral();
                    break;

            }
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            ManejarListBox(btnProduccion, ptbxProduccion, contenedorProduccion, ref Produccion);
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            ManejarListBox(btnTransaccion, ptbxTransaccion, contenedorTransacciones, ref Transaccion);
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            frmResumen formulario = frmResumen.Formulario();
            LlamarFormulario(formulario);
            formulario.CargarGrafico();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            ManejarListBox(btnAnimales, ptbxAnimales, contenedorAnimales, ref Animales);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            ManejarListBox(btnGestion, ptbxGestion, contenedorGestion, ref Gestion);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin formulario = frmLogin.Formulario();
            formulario.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ManejarListBox(btnUsuarios, ptbxUsuarios, contenedorUsuarios, ref Usuarios);

        }
    }
}
