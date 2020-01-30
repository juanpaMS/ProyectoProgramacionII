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
    public partial class PrincipalForm : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        ConsultasSQL sql = new ConsultasSQL();

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            IniciarSesionUsuarioForm loginfrm = new IniciarSesionUsuarioForm();
            loginfrm.ShowDialog();
        }

        

        private bool HayInformacionEnLaLista()
        {
            return ListaLibroYNotaTreeView.Nodes.Count >= 1;
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

        

        
    }
}
