using System;
using System.Windows.Forms;

namespace ProyectoProgramacionII
{
    public partial class PrincipalForm : Form
    {
        // private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;
        CuadernoDigital[] cuadernoDigital = new CuadernoDigital[5];
        Nota[] nota = new Nota[10];
        int ixL = 0;
        int ixN = 0;


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

    /*    private EditarNotaForm RellenarNotaFrm()
        {
            return EditarNotaForm{
                
            }
        }*/

        private void CrearButton_Click(object sender, EventArgs e)
        {
           // if (InformacionEsValida())
          //  {
                Nota aux = RellenarNota();
                nota[ixN] = aux;
                AdminTreeView.SelectedNode.Nodes.Add(nota[ixN].titulo);
                NotasDataGridView.Rows.Add(nota[ixN].titulo, nota[ixN].categoria, nota[ixN].color, nota[ixN].privacidad, "hoy");
                
          //  }
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
                nombre = CrearLibroTextBox.Text,
                color = ColorLibroComboBox.Text,
                categoria = CategoriaLibroComboBox.Text,
            };
        }

        private bool InformacionEsValida()
        {
            LimpiarErrorProviders();

            bool esValida = true;

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
                CuadernoDigital aux = RellenarCuaderno();
                cuadernoDigital[ixL] = aux;
                AdminTreeView.Nodes.Add(cuadernoDigital[ixL].nombre);
                LibrosDataGridView.Rows.Add(cuadernoDigital[ixL].nombre, cuadernoDigital[ixL].categoria, cuadernoDigital[ixL].color);
                ixL = ixL + 1; 
            }
        }

        private Nota RellenarNota()
        {
            return new Nota
            {
                titulo = nombreTextBox.Text,
                categoria = CategoriaComboBox.Text,
                color = ColorComboBox.Text,
                privacidad = PrivacidadComboBox.Text,
                indice = ixN,
                //  fechaDeCreacion = DateTime.Today,
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

        private void AdminTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            for(int i = 0; i <= ixN; i++)
            {
                
                if(nota[i].titulo == AdminTreeView.SelectedNode.Text)
                {
                    EditarNotaForm notaFrm = new EditarNotaForm();
                    notaFrm.setData(nota[i]);
                    notaFrm.ShowDialog();

                        nota[i] = notaFrm.getNota();
                    
                    
                }
                else
                {
                    errorProvider1.SetError(EditarNotaButton, "No fue posible mostrar la ventana, reinicia la aplicacion");
                }
            }
        }
    }
}
