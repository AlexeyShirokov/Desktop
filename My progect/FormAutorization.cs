using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_progect
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            bool key = false;
            if (textBoxLogin.Text != "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Autorization autorization in Program.des.Autorization)
                {
                    if (textBoxPassword.Text == autorization.Password && textBoxLogin.Text == autorization.Login)
                        key = true;
                }
            }
            if (key == true)
            {
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void buttonCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
