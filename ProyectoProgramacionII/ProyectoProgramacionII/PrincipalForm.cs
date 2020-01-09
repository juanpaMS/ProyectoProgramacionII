﻿using System;
using System.Windows.Forms;

namespace ProyectoProgramacionII
{
    public partial class PrincipalForm : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            IniciarSesionForm loginfrm = new IniciarSesionForm();
            loginfrm.ShowDialog();
            UsuarioStatusStrip.Text = "Usuario Actual: @" + loginfrm.ObtenerUsuario().nombre;
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            if (InformacionEsValida())
            {
                CuadernoDigital cuadernoDigital = RellenarCuaderno();
                //listView1.Items.Add(cuadernoDigital.nombre, cuadernoDigital.color, cuadernoDigital.categoria);
               // AdminTreeView.
            }
            //if (HayInformacionEnLaLista())
            //{
            //    LimpiarErrorProviders();

            //    ArchivoManager archivoManager = new ArchivoManager();

            //   CargarInformacion(archivoManager);

            //    ConstruirElArchivo(archivoManager);

                //listView1.Items.Clear();
            //}
            else
            {
                //errorProvider1.SetError(listView1, "No hay informacion para crear el archivo");
            }
        }

        private void ConstruirElArchivo(ArchivoManager archivoManager)
        {
            try
            {
                string nombreNuevoArchivo = archivoManager.CrearArchivo(rutaPorDefecto);
                MessageBox.Show($"El Archivo {nombreNuevoArchivo} se creo de manera correcta", "Excelente!", MessageBoxButtons.OK);
            }
            catch(Exception exception)
            {
                MessageBox.Show($"Se ha presentado el siguiente inconveniente al crear el archivo: {exception.Message}", "Atencion", MessageBoxButtons.OK);
            }
        }

        private void CargarInformacion(ArchivoManager archivoManager)
        {
            //for(int i =0; i<listView1.Items.Count; i++)
            {
                archivoManager.BookList.Add(new CuadernoDigital
                {
                    //nombre = listView1.Items[i].Cells[0].Value.ToString(),
                });
            }
        }

        //private bool HayInformacionEnLaLista()
        //{
        //   return listView1.Items.Count >= 1;
        //}

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
        /*  if (AdminTreeView.Nodes.Find(AdminTreeView.SelectedNode.Text, false))
            {
                esValida = true;
            }*/
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
        }

        private void CategoriaButton_Click(object sender, EventArgs e)
        {
            if (CategoriaEsValida())
            {
                
                AdminTreeView.Nodes.Add(CrearCategoriaTextBox.Text);
            }
        }

        private Categoria RellenarCategoria()
        {
            return new Categoria
            {
                nombre = CrearCategoriaTextBox.Text
            };
        }

        private bool CategoriaEsValida()
        {
            bool esValida = true;
            if(CrearCategoriaTextBox.Text.Length < 2)
            {
                esValida = false;
                errorProvider1.SetError(CrearCategoriaTextBox, "El nombre debe ser mayor de dos digitos");
            }
            return esValida;
        }
    }
}
