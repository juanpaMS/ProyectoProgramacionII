using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ProyectoProgramacionII.UNA.Clases.Principal;

namespace ProyectoProgramacionII
{
    public partial class NotaForm : Form
    {
        Nota[] nota = new Nota[10];
        int indiceNotas = 0;

        public NotaForm()
        {
            InitializeComponent();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
           /* if (ListaLibroYNotaTreeView.SelectedNode == null)
            {
                MessageBox.Show("Seleccione un libro", "Mantenga seleccionado el libro antes de presionar el boton", MessageBoxButtons.OK);

            }
            if (ListaLibroYNotaTreeView.SelectedNode != null)
            {
                Nota aux = RellenarNota();
                nota[indiceNotas] = aux;
                ListaLibroYNotaTreeView.SelectedNode.Nodes.Add(nota[indiceNotas].titulo);
                NotaDataGridView.Rows.Add(nota[indiceNotas].titulo, nota[indiceNotas].categoria, nota[indiceNotas].color, nota[indiceNotas].privacidad, "hoy");

                LimpiarErrorProviders();
            }
            else
            {
                ErrorProvider.SetError(ListaLibroYNotaTreeView, "No hay informacion para crear el archivo");
            }   */
        }

        private bool InformacionEsValida()
        {
            LimpiarErrorProviders();

            bool esValida = true;

            if (NotaNombreTextBox.Text.Length < 3)
            {
                esValida = false;
                ErrorProvider.SetError(NotaNombreTextBox, "Debe ingresar un nombre de más de 3 caracteres");
            }
            if (NotaColorComboBox.Text == "Elija un color")
            {
                esValida = false;
                ErrorProvider.SetError(NotaColorComboBox, "Debe ingresar un dato válido");
            }
            if (NotaCategoriaComboBox.Text == "Elija una categoría")
            {
                esValida = false;
                ErrorProvider.SetError(NotaCategoriaComboBox, "Debe ingresar un dato válido");
            }
            
            if (NotaPrivacidadComboBox.Text == "Elija tipo de privacidad")
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
        }

        private Nota RellenarNota()
        {
            return new Nota
            {
                titulo = NotaNombreTextBox.Text,
                categoria = NotaCategoriaComboBox.Text,
                color = NotaColorComboBox.Text,
                privacidad = NotaPrivacidadComboBox.Text,
                indice = indiceNotas,
            };
        }

        private void NotaEditarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= indiceNotas; i++)
            {

               
            }
        }

        private void LimpiarInterfazNota()
        {
            NotaNombreTextBox.Text = "";
            NotaColorComboBox.Text = "";
            NotaCategoriaComboBox.Text = "";
            NotaPrivacidadComboBox.Text = "";
        }

        private void NotaLimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarInterfazNota();
        }

        private void NotaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
