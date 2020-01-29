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
            ErrorProvider.SetError(LibroNombreTextBox, "");
            ErrorProvider.SetError(LibroColorComboBox, "");
            ErrorProvider.SetError(LibroCategoriaComboBox, "");
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            if (LibroEsValido())
            {
                LibroDigital aux = RellenarCuaderno();
                cuadernoDigital[indiceLibros] = aux;
                //ListaLibroYNotaTreeView.Nodes.Add(cuadernoDigital[ixL].nombre);                hay que linkearlo al principal form
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
                ErrorProvider.SetError(LibroNombreTextBox, "El nombre debe ser mayor de 3 digitos");
            }
            if (LibroColorComboBox.Text == "Elija un color")
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


    }
}
