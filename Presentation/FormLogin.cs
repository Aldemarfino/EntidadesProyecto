using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Presentation
{
    public partial class FormLogin : Form
    {
        UserLogic userLogic;
        public FormLogin()
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }

        private void lblRegistrate_Click(object sender, EventArgs e)
        {
            ShowForm(new FormSignup());
        }

        private void ShowForm(Form form)
        {
            form.Show();
        }

        private void lblRegistrate_MouseHover(object sender, EventArgs e)
        {
            lblRegistrate.ForeColor = Color.Blue;
        }

        private void lblRegistrate_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrate.ForeColor = Color.Black;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarCuenta();
        }

        private void IngresarCuenta()
        {
            if (txtUsuario.Text == string.Empty || txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("Hay campos vacios!!");
            }
            else
            {
                User user = userLogic.ObtainByUsername(txtUsuario.Text);
                if (user != null && user.Password == txtContrasena.Text)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    new FormMainView().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos erroneos");
                }
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
            }
        }
    }
}
