using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAutorization.users.type == "agent") buttonOpenWorker.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAutorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenWorker_Click(object sender, EventArgs e)
        {
            Form formWorker = new FormWorker();
            formWorker.Show();
        }

        private void buttonOpenProduct_Click(object sender, EventArgs e)
        {
            Form formProduct = new FormProduct();
            formProduct.Show();

        }

        private void buttonOpenProductTraking_Click(object sender, EventArgs e)
        {
            Form formProductTracing = new FormProductTraking();
            formProductTracing.Show();
                 
        }

        private void buttonCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
