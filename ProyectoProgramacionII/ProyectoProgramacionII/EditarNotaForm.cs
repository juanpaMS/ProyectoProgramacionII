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

        int indice;
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AsignarPropiedades()
        {
            aux.privacidad = NotaPrivacidadComboBox.Text;
            //aux.letraColor = ColorFuenteComboBox.Text;
            //aux.fuente = FuenteComboBox.Text;
            aux.color = NotaColorComboBox.Text;
            aux.hoja = "hola putito";
            aux.fechaDeModificacion = DateTime.Today;
        }

        private void AplicarButton_Click(object sender, EventArgs e)
        {
            AsignarPropiedades();
            
            this.Close();
            
        }

        public Nota getNota()
        {
            return aux;
        }

        private void EditarNotaForm_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ContenidoRichTextBox.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ContenidoRichTextBox.LoadFile(OpenFileDialog.FileName);
            }
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
