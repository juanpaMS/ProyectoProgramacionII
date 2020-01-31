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
    public partial class EditarNotaForm : Form
    {
        Nota aux = new Nota();
        public bool cierre = false;

        public EditarNotaForm()
        {
            InitializeComponent();
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void setData(Nota note)
        {
            aux = note;
            NotaPrivacidadComboBox.Text = aux.privacidad;
            NotaColorComboBox.Text = aux.color;
            NotaNombreTextBox.Text = aux.titulo;
        }

        private void AsignarPropiedades()
        {
            aux.titulo = NotaNombreTextBox.Text;
            aux.privacidad = NotaPrivacidadComboBox.Text;
            aux.letraColor = ColorDialog.Color.Name;
            aux.fuente = FontDialog.Font.Name;
            aux.color = NotaColorComboBox.Text;
            aux.hoja = ContenidoRichTextBox.Text;
            aux.fechaDeModificacion = DateTime.Today;
        }

        private void AplicarButton_Click(object sender, EventArgs e)
        {
            AsignarPropiedades();

            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();

            mySQL.actualizarNotaEditada(NotaNombreTextBox.Text, ContenidoRichTextBox.Text);

            mySQL.CloseConnection();

            this.Hide();
        }

        public Nota getNota()
        {
            return aux;
        }

        private void EditarNotaForm_Load(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";

            mySQL.OpenConnection();


            ContenidoRichTextBox.Text = mySQL.getHoja(TituloLabel.Text);


            mySQL.CloseConnection();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                ContenidoRichTextBox.SelectionFont = FontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                ContenidoRichTextBox.SelectionColor = ColorDialog.Color;
            }
        }
    }
}
