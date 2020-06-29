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
    public partial class FormDrink : Form
    {
        public FormDrink()
        {
            InitializeComponent();
            ShowDrink();
        }
        void ShowDrink()
        {
            listViewDrink.Items.Clear();
            foreach (DrinkSet drinkSet in Program.des.DrinkSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    drinkSet.Id.ToString(),
                    drinkSet.Dish,
                    drinkSet.Сomposition,
                    drinkSet.Prise,
                   });
                item.Tag = drinkSet;
                listViewDrink.Items.Add(item);
            }

            listViewDrink.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DrinkSet drinkSet = new DrinkSet();
            drinkSet.Dish = textBoxDish.Text;
            drinkSet.Сomposition = richTextBoxСomposition.Text;
            drinkSet.Prise = textBoxPrise.Text;
            Program.des.DrinkSet.Add(drinkSet);
            Program.des.SaveChanges();
            ShowDrink();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDrink.SelectedItems.Count == 1)
            {
                DrinkSet drinkSet = listViewDrink.SelectedItems[0].Tag as DrinkSet;
                drinkSet.Dish = textBoxDish.Text;
                drinkSet.Сomposition = richTextBoxСomposition.Text;
                drinkSet.Prise = textBoxPrise.Text;
                Program.des.SaveChanges();
                ShowDrink();
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDrink.SelectedItems.Count == 1)
                {
                    DrinkSet drinkSet = listViewDrink.SelectedItems[0].Tag as DrinkSet;
                    Program.des.DrinkSet.Remove(drinkSet);
                    Program.des.SaveChanges();
                    ShowDrink();
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

        private void listViewDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrink.SelectedItems.Count == 1)
            {
                DrinkSet drinkSet = listViewDrink.SelectedItems[0].Tag as DrinkSet;
                textBoxDish.Text = drinkSet.Dish;
                richTextBoxСomposition.Text = drinkSet.Сomposition;
                textBoxPrise.Text = drinkSet.Prise;

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
