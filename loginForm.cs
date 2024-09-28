using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Principal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Equals("admin") && Password.Text.Equals("admin"))
            {
               
                    var searchForm = new Form1();
                    searchForm.Show();

                    this.Hide();
                

            }
            else if (!UserName.Text.Equals("admin"))
            {
                MessageBox.Show("Nom d'utilisateur est incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Password.Text.Equals("admin"))
            {
                MessageBox.Show("Mot de passe est incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            Password.Clear();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                    Password.PasswordChar = '\0';
            } else
            {
                Password.PasswordChar = '*';
            }
        }
    }
}
