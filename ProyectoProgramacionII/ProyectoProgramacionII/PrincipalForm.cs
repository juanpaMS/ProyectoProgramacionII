using System;
using System.Windows.Forms;

namespace ProyectoProgramacionII
{
    public partial class PrincipalForm : Form
    {
       // private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            IniciarSesionForm loginfrm = new IniciarSesionForm();
            loginfrm.ShowDialog();
            //UsuarioStatusStrip.Text = "Usuario Actual: @" + loginfrm.ObtenerUsuario().nombre;
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            if (InformacionEsValida())
            {
                Nota nota = RellenarNota();
                AdminTreeView.SelectedNode.Nodes.Add(nota.titulo, nota.color, nota.categoria);
                NotasDataGridView.Rows.Add(nota.titulo, nota.color, nota.categoria, nota.privacidad, "hoy");
            }
            if (HayInformacionEnLaLista())
            {
                //LimpiarErrorProviders();

              //  ArchivoManager archivoManager = new ArchivoManager();

               //CargarInformacion(archivoManager);

               // ConstruirElArchivo(archivoManager);

            }
            else
            {
                errorProvider1.SetError(AdminTreeView, "No hay informacion para crear el archivo");
            }
        }

        private bool HayInformacionEnLaLista()
        {
           return AdminTreeView.Nodes.Count >= 1;
        }

        private CuadernoDigital RellenarCuaderno()
        {
            return new CuadernoDigital
            {
                nombre = nombreTextBox.Text,
                color = ColorComboBox.Text,
                categoria = CategoriaComboBox.Text,
            };
        }

        private bool InformacionEsValida()
        {
            LimpiarErrorProviders();

            bool esValida = false;

            if(nombreTextBox.Text.Length < 3)
            {
                esValida = false;
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un nombre de más de 3 caracteres");
            }
            if(ColorComboBox.Text.Length < 2)
            {
                esValida = false;
                errorProvider1.SetError(ColorComboBox, "Debe ingresar un dato valido");
            }
            if(CategoriaComboBox.Text.Length < 2)
            {
                esValida = false;
                errorProvider1.SetError(CategoriaComboBox, "Debe ingresar un dato valido");
            }
            return esValida;
           
           
        }

        private void LimpiarErrorProviders()
        {
            errorProvider1.SetError(nombreTextBox, "");
            errorProvider1.SetError(ColorComboBox, "");
            errorProvider1.SetError(CategoriaComboBox, "");
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            nombreTextBox.Text = "";
            ColorComboBox.Text = "";
            CategoriaComboBox.Text = "";
            PrivacidadComboBox.Text = "";
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            if (CategoriaEsValida())
            {
                CuadernoDigital cuadernoDigital = RellenarCuaderno();
                CategoriaComboBox.Items.Add(CrearLibroTextBox.Text);
                AdminTreeView.Nodes.Add(CrearLibroTextBox.Text);
                LibrosDataGridView.Rows.Add(CrearLibroTextBox.Text,"estandar","Verde");
            }
        }

        private Nota RellenarNota()
        {
            return new Nota
            {
                titulo = CrearLibroTextBox.Text,
                categoria = CategoriaComboBox.Text,
                color = ColorComboBox.Text,
                privacidad = PrivacidadComboBox.Text,
            };
        }

        private bool CategoriaEsValida()
        {
            bool esValida = true;
            if(CrearLibroTextBox.Text.Length < 2)
            {
                esValida = false;
                errorProvider1.SetError(CrearLibroTextBox, "El nombre debe ser mayor de dos digitos");
            }
            return esValida;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myDataGridView.Rows.Add()
        }
    }
}
