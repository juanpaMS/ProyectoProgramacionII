﻿using Biblioteca.Biblioteca.Clases;
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
    public partial class PrincipalForm : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            IniciarSesionUsuarioForm loginfrm = new IniciarSesionUsuarioForm();
            loginfrm.ShowDialog();

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
            return MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void LibroCrearButton_Click(object sender, EventArgs e)
        {
            LibroForm libro = new LibroForm();
            libro.Show();
        }

        private void NotaCrearButton_Click(object sender, EventArgs e)
        {
            NotaForm nota = new NotaForm();
            nota.Show();
        }


        private void ListaLibroYNotaTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /* poner codigo
                            + Abrir Hoja de Nota Cliqueada
                            
    */
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            HojaRichTextBox.Text = mySQL.GetHoja();

            mySQL.CloseConnection();
        }

        private void VerNotasButton_Click(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            principalDataGridView.DataSource = mySQL.MostrarDatosNota();

            mySQL.CloseConnection();
        }

        private void BuscarLibroTextBox_TextChanged(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            if (BuscarLibroTextBox.Text != "") principalDataGridView.DataSource = mySQL.BuscarLibro(BuscarLibroTextBox.Text);
            else principalDataGridView.DataSource = mySQL.MostrarDatosLibros();

            mySQL.CloseConnection();
        }

        private void principalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            //Esto tiene que retornar un string -- el cual es la hoja que será puesta en pantalla
            HojaRichTextBox.Text = mySQL.getHoja(principalDataGridView.SelectedCells.ToString());
            

            mySQL.CloseConnection();
        }
    }
}  
