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
            PrivacidadComboBox.Text = aux.privacidad;
            ColorComboBox.Text = aux.color;
            TituloTextBox.Text = aux.titulo;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AsignarPropiedades()
        {
            aux.privacidad = PrivacidadComboBox.Text;
            aux.letraColor = ColorFuenteComboBox.Text;
            aux.fuente = FuenteComboBox.Text;
            aux.color = ColorComboBox.Text;
            aux.hoja = contenidoTextBox.Text;
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

        
    }
}
