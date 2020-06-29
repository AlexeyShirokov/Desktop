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
    public partial class FormSoups : Form
    {
        public FormSoups()
        {
            InitializeComponent();
            ShowSoups();
        }
        void ShowSoups()
        {
            listViewSoups.Items.Clear();
            foreach (SoupsSet soupsSet in Program.des.SoupsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                      soupsSet.Id.ToString(),
                      soupsSet.Dish,
                      soupsSet.Сomposition,
                      soupsSet.Prise,
                     
                    });
                item.Tag = soupsSet;
                listViewSoups.Items.Add(item);
            }

            listViewSoups.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SoupsSet soupsSet = new SoupsSet();
            soupsSet.Dish = textBoxDish.Text;
            soupsSet.Сomposition = richTextBoxСomposition.Text;
            soupsSet.Prise = textBoxPrise.Text;
            Program.des.SoupsSet.Add(soupsSet);
            Program.des.SaveChanges();
            ShowSoups();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSoups.SelectedItems.Count == 1)
            {
                SoupsSet soupsSet = listViewSoups.SelectedItems[0].Tag as SoupsSet;
                soupsSet.Dish = textBoxDish.Text;
                soupsSet.Сomposition = richTextBoxСomposition.Text;
                soupsSet.Prise = textBoxPrise.Text;
                Program.des.SaveChanges();
                ShowSoups();
            }
        }

        private void listViewSoups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSoups.SelectedItems.Count == 1)
            {
                SoupsSet soupsSet = listViewSoups.SelectedItems[0].Tag as SoupsSet;
                textBoxDish.Text = soupsSet.Dish;
                richTextBoxСomposition.Text = soupsSet.Сomposition;
                textBoxPrise.Text = soupsSet.Prise;

            }
            else
            {
                textBoxDish.Text = "";
                richTextBoxСomposition.Text = "";
                textBoxPrise.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSoups.SelectedItems.Count == 1)
                {
                    SoupsSet soupsSet = listViewSoups.SelectedItems[0].Tag as SoupsSet;
                    Program.des.SoupsSet.Remove(soupsSet);
                    Program.des.SaveChanges();
                    ShowSoups();
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
    }

}
