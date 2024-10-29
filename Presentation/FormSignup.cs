using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace Presentation
{
    public partial class FormSignup : Form
    {
        UserLogic userLogic;
        public FormSignup()
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty || txtContrasena.Text == string.Empty || txtGmail.Text == string.Empty)
            {
                MessageBox.Show("Hay campos vacios!!");
            }
            else
            {
                if (CuentaValida())
                {
                    if (RegistrarCuenta())
                    {
                        MessageBox.Show("Usuario registrado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar usuario");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o correo ya en uso");
                }
                txtUsuario.Text = string.Empty;
                txtGmail.Text = string.Empty;
                txtContrasena.Text = string.Empty;
            }
        }
        private bool RegistrarCuenta()
        {
            User user = new User(txtUsuario.Text,txtGmail.Text,txtContrasena.Text);
            return userLogic.Add(user);
        }
        private bool CuentaValida()
        {
            if (userLogic.ObtainByUsername(txtUsuario.Text) == null && userLogic.ObtainByEmail(txtGmail.Text) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
