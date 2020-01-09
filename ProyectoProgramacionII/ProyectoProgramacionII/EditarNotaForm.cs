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
        public EditarNotaForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void setData(string nom, string priv)
        {
            TituloTextBox.Text = nom;
            PrivacidadComboBox.Text = priv;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
