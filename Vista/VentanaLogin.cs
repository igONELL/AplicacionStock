using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionStock.Vista
{
    public partial class _vntLogin : Form
    {
        public static string usuarioActual;
        public _vntLogin()
        {
            InitializeComponent();
        }

        private void txtBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "USUARIO")
            {

                txtBoxUsuario.Text = "";
                txtBoxUsuario.ForeColor = Color.Black;

            }
        }

        private void txtBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "")
            {

                txtBoxUsuario.Text = "USUARIO";
                txtBoxUsuario.ForeColor = Color.LightGray;

            }
        }

        private void txtBoxContrasena_Enter(object sender, EventArgs e)
        {
            if (txtBoxContrasena.Text == "CONTRASEÑA")
            {
                txtBoxContrasena.Text = "";
                txtBoxContrasena.ForeColor = Color.Black;
                txtBoxContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxContrasena_Leave(object sender, EventArgs e)
        {
            if(txtBoxContrasena.Text == "")
            {
                txtBoxContrasena.Text = "CONTRASEÑA";
                txtBoxContrasena.ForeColor = Color.LightGray;
                txtBoxContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _vntProd vntProd = new _vntProd();
            if (txtBoxUsuario.Text == "admin1" && txtBoxContrasena.Text == "pass1")
            {
                usuarioActual = "admin1";
                vntProd.Show();
                this.Hide();
            }
            else if(txtBoxUsuario.Text == "admin2" && txtBoxContrasena.Text == "pass2")
            {
                usuarioActual = "admin2";
                vntProd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecta.", "Datos Inválidos");
            }
        }
    }
}

