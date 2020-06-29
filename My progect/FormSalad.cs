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
    public partial class FormSalad : Form
    {
        public FormSalad()
        {
            InitializeComponent();
            ShowSalad();
        }
        void ShowSalad()
        {
            listViewSalad.Items.Clear();
            foreach (SaladSet saladSet in Program.des.SaladSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    saladSet.Id.ToString(),
                    saladSet.Dish,
                    saladSet.Сomposition,
                    saladSet.Prise,
                   });
                item.Tag = saladSet;
                listViewSalad.Items.Add(item);
            }

            listViewSalad.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SaladSet saladSet = new SaladSet();
            saladSet.Dish = textBoxDish.Text;
            saladSet.Сomposition = richTextBoxСomposition.Text;
            saladSet.Prise = textBoxPrise.Text;
            Program.des.SaladSet.Add(saladSet);
            Program.des.SaveChanges();
            ShowSalad();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSalad.SelectedItems.Count == 1)
            {
                SaladSet saladSet = listViewSalad.SelectedItems[0].Tag as SaladSet;
                saladSet.Dish = textBoxDish.Text;
                saladSet.Сomposition = richTextBoxСomposition.Text;
                saladSet.Prise = textBoxPrise.Text;
                Program.des.SaveChanges();
                ShowSalad();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSalad.SelectedItems.Count == 1)
                {
                    SaladSet saladSet = listViewSalad.SelectedItems[0].Tag as SaladSet;
                    Program.des.SaladSet.Remove(saladSet);
                    Program.des.SaveChanges();
                    ShowSalad();
                }
                textBoxDish.Text = "";
                richTextBoxСomposition.Text = "";
                textBoxPrise.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSecondCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSalad.SelectedItems.Count == 1)
            {
                SaladSet saladSet = listViewSalad.SelectedItems[0].Tag as SaladSet;
                textBoxDish.Text = saladSet.Dish;
                richTextBoxСomposition.Text = saladSet.Сomposition;
                textBoxPrise.Text = saladSet.Prise;

            }
            else
            {
                textBoxDish.Text = "";
                richTextBoxСomposition.Text = "";
                textBoxPrise.Text = "";
            }
        }
    }
}
