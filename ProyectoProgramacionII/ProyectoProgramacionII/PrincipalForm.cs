using System;
using System.Windows.Forms;

namespace ProyectoProgramacionII
{
    public partial class PrincipalForm : Form
    {
       
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

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

      

        private void CrearButton_Click(object sender, EventArgs e)
        {
    
            if (ListaLibroYNotaTreeView.SelectedNode == null)
            {
                MessageBox.Show("seleccione un libro", "Mantenga seleccionado el libro antes de presionar el boton", MessageBoxButtons.OK);
                
            }
            if (ListaLibroYNotaTreeView.SelectedNode != null)
            {
                Nota aux = RellenarNota();
                nota[ixN] = aux;
                ListaLibroYNotaTreeView.SelectedNode.Nodes.Add(nota[ixN].titulo);
                NotaDataGridView.Rows.Add(nota[ixN].titulo, nota[ixN].categoria, nota[ixN].color, nota[ixN].privacidad, "hoy");
                
                LimpiarErrorProviders();
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
            if(NotaColorComboBox.Text == "Elija un color")
            {
                esValida = false;
                ErrorProvider.SetError(NotaColorComboBox, "Debe ingresar un dato válido");
            }
            if(NotaCategoriaComboBox.Text == "Elija una categoría")
            {
                esValida = false;
                ErrorProvider.SetError(NotaCategoriaComboBox, "Debe ingresar un dato válido");
            }
            if (ListaLibroYNotaTreeView.SelectedNode != null)
            {
                esValida = false;
                MessageBox.Show("Elija un libro en la Lista", "Porfavor elija uno y presione Crear Nota", MessageBoxButtons.OK);
            }
            if(NotaPrivacidadComboBox.Text == "Elija tipo de privacidad")
            {
                esValida = false;
                ErrorProvider.SetError(NotaPrivacidadComboBox, "Debe ingresar un dato válido");
            }
            return esValida;
        }

        private void LimpiarErrorProviders()
        {
            ErrorProvider.SetError(NotaNombreTextBox, "");
            ErrorProvider.SetError(NotaColorComboBox, "");
            ErrorProvider.SetError(NotaPrioridadLabel, "");
            ErrorProvider.SetError(NotaCategoriaComboBox, "");
            ErrorProvider.SetError(LibroNombreTextBox, "");
            ErrorProvider.SetError(LibroColorComboBox, "");
            ErrorProvider.SetError(LibroCategoriaComboBox, "");
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            if (LibroEsValido())
            {
                CuadernoDigital aux = RellenarCuaderno();
                cuadernoDigital[ixL] = aux;
                ListaLibroYNotaTreeView.Nodes.Add(cuadernoDigital[ixL].nombre);
                LibroDataGridView.Rows.Add(cuadernoDigital[ixL].nombre, cuadernoDigital[ixL].categoria, cuadernoDigital[ixL].color);
                ixL += 1; 
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
            };
        }

        private bool LibroEsValido()
        {
            bool esValido = true;
            if(LibroNombreTextBox.Text.Length < 3)
            {
                esValido = false;
                ErrorProvider.SetError(LibroNombreTextBox, "El nombre debe ser mayor de 3 digitos");
            }
            if(LibroColorComboBox.Text == "Elija un color")
            {
                esValido = false;
                ErrorProvider.SetError(LibroColorComboBox, "Debe elegir un color para continuar");
            }
            if (LibroCategoriaComboBox.Text == "Elija una categoría")
            {
                esValido = false;
                ErrorProvider.SetError(LibroCategoriaComboBox, "Debe elegir una categoría para continuar");
            }
            return esValido;
        }

        private void AdminTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void NotaEditarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= ixN; i++)
            {

                if (nota[i].titulo == ListaLibroYNotaTreeView.SelectedNode.Text)
                {
                    EditarNotaForm notaFrm = new EditarNotaForm();
                    notaFrm.setData(nota[i]);
                    notaFrm.Show();

                    nota[i] = notaFrm.getNota();
                }
                else
                {
                    ErrorProvider.SetError(NotaEditarButton, "No fue posible mostrar la ventana, reinicia la aplicacion");
                }
            }
        }


        public override void Refresh()

        private void RefreshButton_Click(object sender, EventArgs e)

        {
            ListaLibroYNotaTreeView.SelectedNode.Nodes.Clear();
            for (int i = 0; i <= ixN; i++)
            {
                ListaLibroYNotaTreeView.SelectedNode.Nodes.Add(nota[i].titulo);
            }

            NotaDataGridView.Rows.Clear();
            for (int i = 0; i <= ixN; i++)
            {
                NotaDataGridView.Rows.Add(nota[i].titulo, nota[i].categoria, nota[i].color, nota[i].privacidad, "hoy");
            }

        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AvisoSalirSinGuardar())
            {
                e.Cancel = true;
            }
        }

        private bool AvisoSalirSinGuardar()
        {

            return MessageBox.Show("No se ha guardado la informacion", "¿Realmente desea cerrar sin guardar?", MessageBoxButtons.YesNo) == DialogResult.No;

            return MessageBox.Show("¿Realmente desea cerrar sin guardar?", "No se ha guardado la informacion",
                                   MessageBoxButtons.YesNo) == DialogResult.No;
        }
           
        private void LibroLimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarInterfazNota();
        }

        private void LimpiarInterfazNota()
        {
            NotaNombreTextBox.Text = "";
            NotaColorComboBox.Text = "";
            NotaCategoriaComboBox.Text = "";
            NotaPrivacidadComboBox.Text = "";
        }
    }
}
