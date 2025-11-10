using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace SAGA_EV3
{
    public partial class Form1 : Form
    {
        List<Usuario> users = new List<Usuario>();


        public Form1()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("Users.TXT");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length == 4)
                {
                    Usuario user = new Usuario(parts[0], parts[1], parts[2], parts[3]);
                    users.Add(user);
                }

            }
            Txb_hash.Text = Argon2Hasher.HashPassword("admin");

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            {
                string username = Txb_user.Text;
                string password = Txb_password.Text;
                if (username == "" || password == "")
                {
                    MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Usuario user = null;
                bool found = false;
                foreach (var u in users)
                {
                    if (u.GetNombre() == username)
                    {
                        found = true;
                        user = u;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (user.VerificarContraseña(password))
                {
                    MessageBox.Show("Inicio de sesion exitoso", "Inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 mainForm = new Form2(username,user.GetRol());
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}


