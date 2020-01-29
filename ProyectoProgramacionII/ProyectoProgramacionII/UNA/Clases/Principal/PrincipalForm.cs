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
    public partial class PrincipalForm : Form
    {
        private readonly string rutaPorDefecto = AppDomain.CurrentDomain.BaseDirectory;

        ConsultasSQL sql = new ConsultasSQL();
        int ixL = 0; //tiene que ser borrado
        int ixN = 0; //tiene que ser borrado
        Nota[] nota = new Nota[10]; //tiene que ser borrado
        LibroDigital[] cuadernoDigital = new LibroDigital[5]; //tiene que ser borrado

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

        private void RefreshButton_Click(object sender, EventArgs e) //codigo que sirve para refrescar NO BORRAR
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
            return MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewRow fila = dgv.Rows[e.RowIndex];
            // txtID.Text =
        }
    }
}
