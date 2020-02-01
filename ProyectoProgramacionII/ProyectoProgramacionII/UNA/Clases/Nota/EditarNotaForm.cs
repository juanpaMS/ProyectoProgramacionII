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
        private int unicFormId = '7';
        Nota notaAuxiliar = new Nota();
        public bool salir = false;

        public EditarNotaForm()
        {
            InitializeComponent();
        }
       

        public void AsignarDatosNota(Nota nota)
        {
            notaAuxiliar = nota;
            NotaPrivacidadComboBox.Text = notaAuxiliar.privacidad;
            NotaColorComboBox.Text = notaAuxiliar.color;
            NotaNombreTextBox.Text = notaAuxiliar.titulo;
        }

        private void AsignarPropiedades()
        {
            notaAuxiliar.titulo = NotaNombreTextBox.Text;
            notaAuxiliar.privacidad = NotaPrivacidadComboBox.Text;
            notaAuxiliar.letraColor = ColorDialog.Color.Name;
            notaAuxiliar.fuente = FontDialog.Font.Name;
            notaAuxiliar.color = NotaColorComboBox.Text;
            notaAuxiliar.hoja = ContenidoRichTextBox.Text;
            notaAuxiliar.fechaDeModificacion = DateTime.Today;
        }

        private void AplicarButton_Click(object sender, EventArgs e)
        {
            AsignarPropiedades();

            MySQLAccess mySQL = new MySQLAccess();
           

                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                mySQL.OpenConnection();

                if(mySQL.actualizarNotaEditada(EditarNotaGroupBox.Text,NotaNombreTextBox.Text, ContenidoRichTextBox.Text, NotaPrivacidadComboBox.Text, NotaColorComboBox.Text))
                {
                    MessageBox.Show("Hoja editada Correctamente");
                }else MessageBox.Show("Hoja NO editada / ERROR");

             
                mySQL.CloseConnection();
                this.Hide();
      
           
        }

        private void EditarNotaForm_Load(object sender, EventArgs e)
        {
            MySQLAccess mySQL = new MySQLAccess();
            try
            {

                mySQL.ConnectionString = @"server=localhost;uid=root;pwd=escandalo89;database=mydb";
                mySQL.OpenConnection();


                ContenidoRichTextBox.Text = mySQL.obtenerHojaDeNota(EditarNotaGroupBox.Text);


                mySQL.CommitTransaction();
            }
            catch
            {
                mySQL.RollBackTransaction();
            }
            finally
            {
                mySQL.CloseConnection();
                
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
