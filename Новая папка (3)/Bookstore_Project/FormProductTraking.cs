using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Project
{
    public partial class FormProductTraking : Form
    {
        public FormProductTraking()
        {
            InitializeComponent();
            ShowClient();   
            ShowProduct();
            ShowWorker();
            ShowProductTraking();
        }
        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet clientSet in Program.mpgc.ClientSet)
            {
                string[] item = {clientSet.Id.ToString()+". "+clientSet.FirstName, clientSet.MiddleName, clientSet.LastName};
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProduct()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProductSet productSet in Program.mpgc.ProductSet)
            {
                string[] item = {productSet.Id.ToString()+". "+productSet.Author, productSet.Name,productSet.GameName, productSet.NameOfficeSupply};
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }
        void ShowWorker()
        {
            comboBoxWorker.Items.Clear();
            foreach(WorkerSet workerSet in Program.mpgc.WorkerSet)
            {
                string[] item = { workerSet.Id.ToString() + ". " + workerSet.FirstName, workerSet.MiddleName, workerSet.LastName };
                comboBoxWorker.Items.Add(string.Join(" ", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxProduct.SelectedItem != null && comboBoxWorker.SelectedItem != null)
            {
                ProductTraking product = new ProductTraking();
                product.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                product.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                product.IdWorker = Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split('.')[0]);
                Program.mpgc.ProductTraking.Add(product);
                Program.mpgc.SaveChanges();
                ShowProductTraking();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowProductTraking()
        {
            listViewChekProduct.Items.Clear();
            foreach (ProductTraking product in Program.mpgc.ProductTraking)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                       product.IdClient.ToString(),
                       product.ClientSet.FirstName+" "+product.ClientSet.MiddleName+" "+product.ClientSet.LastName, 
                       product.IdWorker.ToString(),
                       product.WorkerSet.FirstName+" "+product.WorkerSet.MiddleName+" "+product.WorkerSet.LastName, 
                       product.IdProduct.ToString(),
                       product.ProductSet.Author+" "+product.ProductSet.Name+" "+product.ProductSet.GameName+" "+ product.ProductSet.NameOfficeSupply,
                       product.ProductSet.Prise.ToString()
                    });
                item.Tag = product;
                listViewChekProduct.Items.Add(item);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewChekProduct.SelectedItems.Count == 1)
            {
                ProductTraking product = listViewChekProduct.SelectedItems[0].Tag as ProductTraking;
                product.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                product.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                product.IdWorker = Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split('.')[0]);
                Program.mpgc.SaveChanges();
                ShowProductTraking();
            }
        }

        private void listViewChekProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewChekProduct.SelectedItems.Count == 1)
            {
                ProductTraking product = listViewChekProduct.SelectedItems[0].Tag as ProductTraking;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(product.IdClient.ToString());
                comboBoxWorker.SelectedIndex = comboBoxWorker.FindString(product.IdWorker.ToString());
                comboBoxProduct.SelectedIndex = comboBoxProduct.FindString(product.IdProduct.ToString());
              
            }
            else 
            {
                comboBoxClient.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
                comboBoxWorker.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewChekProduct.SelectedItems.Count == 1)
                {
                    ProductTraking product = listViewChekProduct.SelectedItems[0].Tag as ProductTraking;
                    Program.mpgc.ProductTraking.Remove(product);
                    Program.mpgc.SaveChanges();
                    ShowProductTraking();
                }
                comboBoxClient.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
                comboBoxWorker.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            }

        private void comboBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

