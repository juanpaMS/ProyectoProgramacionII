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
            try
            {

                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                mySQL.OpenConnection();

                NotaDataGridView.DataSource = mySQL.MostrarDatosNota();

                mySQL.CommitTransaction();
            }
            catch
            {
                mySQL.RollBackTransaction();
            }
            finally
            {
                mySQL.CloseConnection();
            }
        }

        

        private void NotaCrearButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            try
            {

                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                mySQL.OpenConnection();

                if (mySQL.InsertarNota(NotaNombreTextBox.Text, NotaCategoriaComboBox.Text,NotaPrivacidadComboBox.Text, NotaColorComboBox.Text))
            {
                MessageBox.Show("Datos Insertados Correctamente");
                NotaDataGridView.DataSource = mySQL.MostrarDatosNota();
            }
            else MessageBox.Show("Los datos NO han sido ingresados");


            mySQL.CommitTransaction();
        }
            catch
            {
                mySQL.RollBackTransaction();
            }
            finally
            {
                mySQL.CloseConnection();
            }
        }

        private void BuscarNotaTextBox_TextChanged(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            try
            {

                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                mySQL.OpenConnection();

                if (BuscarNotaTextBox.Text != "") NotaDataGridView.DataSource = mySQL.BuscarNota(BuscarNotaTextBox.Text);
            else NotaDataGridView.DataSource = mySQL.MostrarDatosNota();

                mySQL.CommitTransaction();
            }
            catch
            {
                mySQL.RollBackTransaction();
            }
            finally
            {
                mySQL.CloseConnection();
            }
        }

        private void NotaEliminarButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            try
            {

                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                mySQL.OpenConnection();

                if (mySQL.EliminarNota(BuscarNotaTextBox.Text))
            {
                MessageBox.Show("Datos Eliminados Correctamente");
                NotaDataGridView.DataSource = mySQL.MostrarDatosNota();
            }
            else MessageBox.Show("Los datos NO han sido Eliminados");


            mySQL.CommitTransaction();
        }
            catch
            {
                mySQL.RollBackTransaction();
            }
            finally
            {
                mySQL.CloseConnection();
            }
        }

        private void NotaDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void NotaDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditarNotaForm editarNota = new EditarNotaForm();
            editarNota.EditarNotaGroupBox.Text = NotaDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 
            editarNota.Show();
        }
    }
}
