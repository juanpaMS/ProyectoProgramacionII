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

            if (ListaLibroYNotaTreeView.SelectedNode == null)
            {
                MessageBox.Show("seleccione un libro", "Mantenga seleccionado el libro antes de presionar el boton", MessageBoxButtons.OK);
                
            }
            if (ListaLibroYNotaTreeView.SelectedNode != null)
            {
                ListaLibroYNotaTreeView.SelectedNode.Nodes.Add(nota[ixN].titulo);
                NotaDataGridView.Rows.Add(nota[ixN].titulo, nota[ixN].categoria, nota[ixN].color, nota[ixN].privacidad, "hoy");
            }
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
                ErrorProvider.SetError(ListaLibroYNotaTreeView, "No hay informacion para crear el archivo");
            }
        }

        

        private bool HayInformacionEnLaLista()
        {
           return ListaLibroYNotaTreeView.Nodes.Count >= 1;
        }

        private CuadernoDigital RellenarCuaderno()
        {
            return new CuadernoDigital
            {
                nombre = LibroNombreTextBox.Text,
                color = LibroColorComboBox.Text,
                categoria = LibroCategoriaComboBox.Text,
            };
        }

        private bool InformacionEsValida()
        {
            LimpiarErrorProviders();

            bool esValida = true;

            if(NotaNombreTextBox.Text.Length < 3)
            {
                esValida = false;
                ErrorProvider.SetError(NotaNombreTextBox, "Debe ingresar un nombre de más de 3 caracteres");
            }
            if(NotaColorComboBox.Text.Length < 2)
            {
                esValida = false;
                ErrorProvider.SetError(NotaColorComboBox, "Debe ingresar un dato valido");
            }
            if(NotaCategoriaComboBox.Text.Length < 2)
            {
                esValida = false;
                ErrorProvider.SetError(NotaCategoriaComboBox, "Debe ingresar un dato valido");
            }
            if (ListaLibroYNotaTreeView.SelectedNode != null)
            {
                esValida = false;
                MessageBox.Show("Elija un libro en el treeview", "Porfavor elija uno y presione Crear Nota", MessageBoxButtons.OK);
            }
            return esValida;
           
           
        }

        private void LimpiarErrorProviders()
        {
            ErrorProvider.SetError(NotaNombreTextBox, "");
            ErrorProvider.SetError(NotaColorComboBox, "");
            ErrorProvider.SetError(NotaCategoriaComboBox, "");
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            NotaNombreTextBox.Text = "";
            NotaColorComboBox.Text = "";
            NotaCategoriaComboBox.Text = "";
            NotaPrivacidadComboBox.Text = "";
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            if (LibroEsValido())
            {
                CuadernoDigital aux = RellenarCuaderno();
                cuadernoDigital[ixL] = aux;
                ListaLibroYNotaTreeView.Nodes.Add(cuadernoDigital[ixL].nombre);
                LibroDataGridView.Rows.Add(cuadernoDigital[ixL].nombre, cuadernoDigital[ixL].categoria, cuadernoDigital[ixL].color);
                ixL = ixL + 1; 
            }
        }

        private Nota RellenarNota()
        {
            return new Nota
            {
                titulo = NotaNombreTextBox.Text,
                categoria = NotaCategoriaComboBox.Text,
                color = NotaColorComboBox.Text,
                privacidad = NotaPrivacidadComboBox.Text,
                indice = ixN,
                //  fechaDeCreacion = DateTime.Today,
            };
        }

        private bool LibroEsValido()
        {
            bool esValido = true;
            if(LibroNombreTextBox.Text.Length < 2)
            {
                esValido = false;
                ErrorProvider.SetError(LibroNombreTextBox, "El nombre debe ser mayor de dos digitos");
            }
            if(LibroColorComboBox.Text == "Elija un color")
            {
                esValido = false;
                ErrorProvider.SetError(LibroColorComboBox, "Debe elegir un color para continuar");
            }
            if (LibroCategoriaComboBox.Text == "Elija una categoría")
            {
                esValido = false;
                ErrorProvider.SetError(LibroCategoriaComboBox, "Debe elegir una categoria para continuar");
            }
            
            return esValido;
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
                
                if(nota[i].titulo == ListaLibroYNotaTreeView.SelectedNode.Text)
                {
                    EditarNotaForm notaFrm = new EditarNotaForm();
                    notaFrm.setData(nota[i]);
                    notaFrm.ShowDialog();

                        nota[i] = notaFrm.getNota();
                    
                    
                }
                else
                {
                    ErrorProvider.SetError(NotaEditarButton, "No fue posible mostrar la ventana, reinicia la aplicacion");
                }
            }
        }
    }
}
