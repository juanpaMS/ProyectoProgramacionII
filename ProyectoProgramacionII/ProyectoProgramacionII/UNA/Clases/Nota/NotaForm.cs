using Biblioteca.Biblioteca.Clases;
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
                NotaErrorProvider.SetError(NotaNombreTextBox, "Debe ingresar un nombre de más de 3 caracteres");
            }
            if (NotaColorComboBox.Text == "Elija un color")
            {
                esValida = false;
                NotaErrorProvider.SetError(NotaColorComboBox, "Debe ingresar un dato válido");
            }
            if (NotaCategoriaComboBox.Text == "Elija una categoría")
            {
                esValida = false;
                NotaErrorProvider.SetError(NotaCategoriaComboBox, "Debe ingresar un dato válido");
            }
            
            if (NotaPrivacidadComboBox.Text == "Elija tipo de privacidad")
            {
                esValida = false;
                NotaErrorProvider.SetError(NotaPrivacidadComboBox, "Debe ingresar un dato válido");
            }
            return esValida;
        }

        private void LimpiarErrorProviders()
        {
            NotaErrorProvider.SetError(NotaNombreTextBox, "");
            NotaErrorProvider.SetError(NotaColorComboBox, "");
            NotaErrorProvider.SetError(NotaPrioridadLabel, "");
            NotaErrorProvider.SetError(NotaCategoriaComboBox, "");
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
                //falta
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
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            NotaDataGridView.DataSource = mySQL.MostrarDatosNota();

            mySQL.CloseConnection();
        }

        private void NotaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = NotaDataGridView.Rows[e.RowIndex];
            NotaNombreTextBox.Text = Convert.ToString(fila.Cells[0]);
            NotaColorComboBox.Text = Convert.ToString(fila.Cells[1]);
            NotaCategoriaComboBox.Text = Convert.ToString(fila.Cells[2]);
        }

        private void NotaCrearButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            if (mySQL.InsertarLibro(NotaNombreTextBox.Text, NotaColorComboBox.Text, NotaCategoriaComboBox.Text))
            {
                MessageBox.Show("Datos Insertados Correctamente");
                NotaDataGridView.DataSource = mySQL.MostrarDatosNota();
            }
            else MessageBox.Show("Los datos NO han sido ingresados");


            mySQL.CloseConnection();
        }

        private void BuscarNotaTextBox_TextChanged(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
            mySQL.OpenConnection();

            if (BuscarNotaTextBox.Text != "") NotaDataGridView.DataSource = mySQL.BuscarNota(BuscarNotaTextBox.Text);
            else NotaDataGridView.DataSource = mySQL.MostrarDatosNota();

            mySQL.CloseConnection();
        }

        private void NotaEliminarButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            if (mySQL.Eliminar(BuscarNotaTextBox.Text))
            {
                MessageBox.Show("Datos Eliminados Correctamente");
                NotaDataGridView.DataSource = mySQL.MostrarDatosLibros();
            }
            else MessageBox.Show("Los datos NO han sido Eliminados");


            mySQL.CloseConnection();
        }
    }
}
