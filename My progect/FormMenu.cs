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
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void buttonWorker_Click(object sender, EventArgs e)
        {
            Form formWorker = new FormWorker();
            formWorker.Show();
        }

        private void buttonSoups_Click(object sender, EventArgs e)
        {
            Form formSoups = new FormSoups();
            formSoups.Show();
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            Form formSecondcourse = new FormSecond_course();
            formSecondcourse.Show();

        }

        private void buttonSalads_Click(object sender, EventArgs e)
        {
            Form formSalad = new FormSalad();
            formSalad.Show();
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            Form formDrink = new FormDrink();
            formDrink.Show();

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormProductTraking();
            formOrder.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
