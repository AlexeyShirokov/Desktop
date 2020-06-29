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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowProductSet();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewBooks.Visible = true;
                labelAuthor.Visible = true;
                textBoxAuthor.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelPrise.Visible = true;
                textBoxPrise.Visible = true;

                listViewOfficeSupplies.Visible = false;
                listViewTableGames.Visible = false;
                labelNameOfficeSupply.Visible = false;
                textBoxNameOfficeSupply.Visible = false;
                labelGameName.Visible = false;
                textBoxGameName.Visible = false;

                textBoxAuthor.Text = "";
                textBoxName.Text = "";
                textBoxPrise.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewTableGames.Visible = true;
                labelGameName.Visible = true;
                textBoxGameName.Visible = true;
                labelPrise.Visible = true;
                textBoxPrise.Visible = true;

                listViewBooks.Visible = false;
                labelAuthor.Visible = false;
                textBoxAuthor.Visible = false;
                labelName.Visible = false;
                textBoxName.Visible = false;
                listViewOfficeSupplies.Visible = false;
                labelNameOfficeSupply.Visible = false;
                textBoxNameOfficeSupply.Visible = false;

                textBoxGameName.Text = "";
                textBoxPrise.Text = "";

            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewOfficeSupplies.Visible = true;
                labelNameOfficeSupply.Visible = true;
                textBoxNameOfficeSupply.Visible = true;
                labelPrise.Visible = true;
                textBoxPrise.Visible = true;

                listViewBooks.Visible = false;
                labelAuthor.Visible = false;
                textBoxAuthor.Visible = false;
                labelName.Visible = false;
                textBoxName.Visible = false;
                listViewTableGames.Visible = false;
                labelGameName.Visible = false;
                textBoxGameName.Visible = false;

                textBoxNameOfficeSupply.Text = "";
                textBoxPrise.Text = "";

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductSet productSet = new ProductSet();

           /* productSet.Author = textBoxAuthor.Text;
            productSet.Name = textBoxName.Text;
            productSet.GameName = textBoxGameName.Text;
            productSet.NameOfficeSupply = textBoxNameOfficeSupply.Text;*/

            if (comboBoxType.SelectedIndex == 0)
            {
                productSet.Type = 0;
                productSet.Author = textBoxAuthor.Text;
                productSet.Name = textBoxName.Text;
                productSet.Prise = Convert.ToInt32(textBoxPrise.Text);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                productSet.Type = 1;
                productSet.GameName = textBoxGameName.Text;
                productSet.Prise = Convert.ToInt32(textBoxPrise.Text);
            }
            else
            {
                productSet.Type = 2;
                productSet.NameOfficeSupply = textBoxNameOfficeSupply.Text;
                productSet.Prise = Convert.ToInt32(textBoxPrise.Text);
            }

            Program.mpgc.ProductSet.Add(productSet);
            Program.mpgc.SaveChanges();
            ShowProductSet();
        }

        void ShowProductSet()
        {
            listViewOfficeSupplies.Items.Clear();
            listViewBooks.Items.Clear();
            listViewTableGames.Items.Clear();
            
                foreach (ProductSet productSet in Program.mpgc.ProductSet)
                {
                    if (productSet.Type == 0)
                    {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                                productSet.Author,
                                productSet.Name,
                                productSet.Prise.ToString()
                        });
                        item.Tag = productSet;
                        listViewBooks.Items.Add(item);

                    }
                    else if (productSet.Type == 1)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                           {
                                productSet.GameName,
                                productSet.Prise.ToString()
                           });
                        item.Tag = productSet;
                        listViewTableGames.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new string[]
                           {
                                productSet.NameOfficeSupply,
                                productSet.Prise.ToString()
                           });
                        item.Tag = productSet;
                        listViewOfficeSupplies.Items.Add(item);
                    }
                }
            listViewBooks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewTableGames.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewOfficeSupplies.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewBooks.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewBooks.SelectedItems[0].Tag as ProductSet;

                    productSet.Author = textBoxAuthor.Text;
                    productSet.Name = textBoxName.Text;
                    productSet.Prise = Convert.ToInt32(textBoxPrise.Text);

                    Program.mpgc.SaveChanges();
                    ShowProductSet();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewTableGames.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewTableGames.SelectedItems[0].Tag as ProductSet;

                    productSet.GameName = textBoxGameName.Text;
                    productSet.Prise = Convert.ToInt32(textBoxPrise.Text);

                    Program.mpgc.SaveChanges();
                    ShowProductSet();
                }

            }
            else
            {
                if (listViewOfficeSupplies.SelectedItems.Count == 1)
                {
                    ProductSet productSet = listViewOfficeSupplies.SelectedItems[0].Tag as ProductSet;

                    productSet.NameOfficeSupply = textBoxNameOfficeSupply.Text;
                    productSet.Prise = Convert.ToInt32(textBoxPrise.Text);

                    Program.mpgc.SaveChanges();
                    ShowProductSet();
                }
            }

            
        }

        private void listViewBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBooks.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewBooks.SelectedItems[0].Tag as ProductSet;

                textBoxAuthor.Text = productSet.Author;
                textBoxName.Text = productSet.Name;
                textBoxPrise.Text= productSet.Prise.ToString();

            }
            else
            {
                textBoxAuthor.Text = "";
                textBoxName.Text = "";
                textBoxPrise.Text = "";
            }

        }

        private void listViewTableGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTableGames.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewTableGames.SelectedItems[0].Tag as ProductSet;

                textBoxGameName.Text= productSet.GameName;
                textBoxPrise.Text = productSet.Prise.ToString();            

            }
            else
            {
                textBoxGameName.Text = "";
                textBoxPrise.Text = "";
            }
        }

        private void listViewOfficeSupplies_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewOfficeSupplies.SelectedItems.Count == 1)
            {
                ProductSet productSet = listViewOfficeSupplies.SelectedItems[0].Tag as ProductSet;

                textBoxNameOfficeSupply.Text = productSet.NameOfficeSupply;
                textBoxPrise.Text = productSet.Prise.ToString();            
            }
            else
            {
                textBoxNameOfficeSupply.Text = "";
                textBoxPrise.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewBooks.SelectedItems.Count == 1)
                    {
                        ProductSet productSet = listViewBooks.SelectedItems[0].Tag as ProductSet;

                        Program.mpgc.ProductSet.Remove(productSet);
                        Program.mpgc.SaveChanges();
                        ShowProductSet();
                    }
                    textBoxAuthor.Text = "";
                    textBoxName.Text = "";

                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewTableGames.SelectedItems.Count == 1)
                    {
                        ProductSet productSet = listViewTableGames.SelectedItems[0].Tag as ProductSet;

                        Program.mpgc.ProductSet.Remove(productSet);
                        Program.mpgc.SaveChanges();
                        ShowProductSet();
                    }
                    textBoxGameName.Text = "";
                }
                else
                {
                    ProductSet productSet = listViewOfficeSupplies.SelectedItems[0].Tag as ProductSet;

                    Program.mpgc.ProductSet.Remove(productSet);
                    Program.mpgc.SaveChanges();
                    ShowProductSet();
                }
                textBoxNameOfficeSupply.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись уже используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
    }
}

