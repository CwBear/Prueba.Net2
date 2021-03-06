﻿using SistemaVenta.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Credenciales();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Credenciales()
        {
            string user = "CajeroAdm";
            string pass = "HnmX2020!";

            if (txtUsuario.Text != user || txtContrasena.Text != pass)
            {
                MessageBox.Show("Error en las Credenciales Ingreselas Nuevamente");
            }
            else if (txtUsuario.Text == user && txtContrasena.Text == pass)
            {
                MessageBox.Show("Bienvenido " + user);
                Vista.Menu mainMenu = new Vista.Menu();
                mainMenu.Show();
                this.Hide();
            }
        }

        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }
    }
}
