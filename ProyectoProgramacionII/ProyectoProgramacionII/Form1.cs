﻿using System;
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
    public partial class IniciarSesionForm : Form
    {
        Usuario persona = new Usuario();

        public IniciarSesionForm()
        {
            InitializeComponent();
        }

        private void IniciarSesionForm_Load(object sender, EventArgs e)
        {

        }

        public Usuario ObtenerUsuario()
        {
            return persona;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if(UsuarioTextBox.TextLength == 0)
            {
                UsuarioErrorProvider.SetError(UsuarioTextBox, "Porfavor Ingrese un nombre de usuario válido");
            }
            if(ContrasenaTextBox.TextLength == 0)
            {
                ContrasenaErrorProvider.SetError(ContrasenaTextBox,"Porfavor ingrese una contraseña valida");
            }
            else
            {
                if(persona.Validar(UsuarioTextBox.Text, ContrasenaTextBox.Text) == true)
                {
                    persona.nombre = UsuarioTextBox.Text;
                    persona.contraseña = ContrasenaTextBox.Text;
                    Close();
                }
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            UsuarioTextBox.Text = "";
            ContrasenaTextBox.Text = "";
            Close();
        }
    }
}
