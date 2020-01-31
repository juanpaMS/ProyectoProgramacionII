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
using MySql.Data.MySqlClient;


namespace ProyectoProgramacionII
{
    public partial class LibroForm : Form
    {
        LibroDigital[] cuadernoDigital = new LibroDigital[5];
        int indiceLibros = 0;
        
        public LibroForm()
        {
            InitializeComponent();
        }

        private LibroDigital RellenarCuaderno()
        {
            return new LibroDigital
            {
                nombre = LibroNombreTextBox.Text,
                color = LibroColorComboBox.Text,
                categoria = LibroCategoriaComboBox.Text,
            };
        }

        private void LimpiarErrorProviders()
        {
            LibroErrorProvider.SetError(LibroNombreTextBox, "");
            LibroErrorProvider.SetError(LibroColorComboBox, "");
            LibroErrorProvider.SetError(LibroCategoriaComboBox, "");
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            if (LibroEsValido())
            {
                LibroDigital aux = RellenarCuaderno();
                cuadernoDigital[indiceLibros] = aux;
               // PrincipalForm.ControlCollection. ListaLibroYNotaTreeView.Nodes.Add(cuadernoDigital[ixL].nombre);              
                LibroDataGridView.Rows.Add(cuadernoDigital[indiceLibros].nombre, cuadernoDigital[indiceLibros].categoria, cuadernoDigital[indiceLibros].color);
                indiceLibros += 1;
            }
        }

        private bool LibroEsValido()
        {
            bool esValido = true;
            if (LibroNombreTextBox.Text.Length < 3)
            {
                esValido = false;
                LibroErrorProvider.SetError(LibroNombreTextBox, "El nombre debe ser mayor de 3 digitos");
            }
            if (LibroColorComboBox.Text == "Elija un color")
            {
                esValido = false;
                LibroErrorProvider.SetError(LibroColorComboBox, "Debe elegir un color para continuar");
            }
            if (LibroCategoriaComboBox.Text == "Elija una categoría")
            {
                esValido = false;
                LibroErrorProvider.SetError(LibroCategoriaComboBox, "Debe elegir una categoría para continuar");
            }
            return esValido;
        }

        private void LimpiarInterfazLibro()
        {
            LibroNombreTextBox.Text = "";
            LibroColorComboBox.Text = "";
            LibroCategoriaComboBox.Text = "";
        }

        private void LibroLimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarInterfazLibro();
        }

        private void LibroDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = LibroDataGridView.Rows[e.RowIndex];
            LibroNombreTextBox.Text = Convert.ToString(fila.Cells[0]);
            LibroColorComboBox.Text = Convert.ToString(fila.Cells[1]);
            LibroCategoriaComboBox.Text = Convert.ToString(fila.Cells[2]);
        }


        private void LibroForm_Load(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            LibroDataGridView.DataSource = mySQL.MostrarDatosLibros();

            mySQL.CloseConnection();
        }

        private void LibroCrearButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            if(mySQL.InsertarLibro(LibroNombreTextBox.Text, LibroColorComboBox.Text, LibroCategoriaComboBox.Text))
            {
                MessageBox.Show("Datos Insertados Correctamente");
                LibroDataGridView.DataSource = mySQL.MostrarDatosLibros();
            }
            else MessageBox.Show("Los datos NO han sido ingresados");


            mySQL.CloseConnection();
        }

        private void BuscarLibroTextBox_TextChanged(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
            mySQL.OpenConnection();

            if (BuscarLibroTextBox.Text != "") LibroDataGridView.DataSource = mySQL.BuscarLibro(BuscarLibroTextBox.Text);
            else LibroDataGridView.DataSource = mySQL.MostrarDatosLibros();

            mySQL.CloseConnection();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            if (mySQL.Eliminar(BuscarLibroTextBox.Text))
            {
                MessageBox.Show("Datos Eliminados Correctamente");
                LibroDataGridView.DataSource = mySQL.MostrarDatosLibros();
            }
            else MessageBox.Show("Los datos NO han sido Eliminados");


            mySQL.CloseConnection();
        }
    }
}
