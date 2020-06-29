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
    public partial class FormProductTraking : Form
    {
        public FormProductTraking()
        {
            InitializeComponent();
            ShowWorker();
            ShowSoups();
            ShowSecondCourse();
            ShowSalad();
            ShowDrink();
            ShowProductTraking();
            UpdatetextboxPrise();


        }       
        void ShowWorker()
        {
            comboBoxWorker.Items.Clear();
            foreach (WorkerSet workerSet in Program.des.WorkerSet)
            {
                string[] item = { workerSet.Id.ToString() + ". " + workerSet.FirstName, workerSet.MiddleName, workerSet.LastName };
                comboBoxWorker.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSoups()
        {
            comboBoxSoups.Items.Clear();
            foreach (SoupsSet soupsSet in Program.des.SoupsSet)
            {
                string[] item = { soupsSet.Id.ToString() + ". " + soupsSet.Dish, soupsSet.Prise };
                comboBoxSoups.Items.Add(string.Join(" ", item));
            }

        }
        void ShowSecondCourse()
        {
            comboBoxSecondCourse.Items.Clear();
            foreach (SecondCourseSet secondCourseSet in Program.des.SecondCourseSet)
            {
                string[] item = { secondCourseSet.Id.ToString() + ". " + secondCourseSet.Dish, secondCourseSet.Prise };
                comboBoxSecondCourse.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSalad()
        {
            comboBoxSalad.Items.Clear();
            foreach (SaladSet saladSet in Program.des.SaladSet)
            {
                string[] item = { saladSet.Id.ToString() + ". " + saladSet.Dish, saladSet.Prise };
                comboBoxSalad.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDrink()
        {
            comboBoxDrink.Items.Clear();
            foreach (DrinkSet drinkSet in Program.des.DrinkSet)
            {
                string[] item = { drinkSet.Id.ToString() + ". " + drinkSet.Dish, drinkSet.Prise };
                comboBoxDrink.Items.Add(string.Join(" ", item));
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxWorker.SelectedItem != null && comboBoxSalad.SelectedItem != null && comboBoxSoups.SelectedItem != null && comboBoxSecondCourse.SelectedItem != null && comboBoxDrink.SelectedItem != null)
            {
                ProductTraking product = new ProductTraking();
                product.IdWorker = Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split('.')[0]);
                product.IdSoups = Convert.ToInt32(comboBoxSoups.SelectedItem.ToString().Split('.')[0]);
                product.IdSalad = Convert.ToInt32(comboBoxSalad.SelectedItem.ToString().Split('.')[0]);
                product.IdSecondCourse = Convert.ToInt32(comboBoxSecondCourse.SelectedItem.ToString().Split('.')[0]);
                product.IdDrink = Convert.ToInt32(comboBoxDrink.SelectedItem.ToString().Split('.')[0]);
                Program.des.ProductTraking.Add(product);
                Program.des.SaveChanges();
                ShowProductTraking();
                UpdatetextboxPrise();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowProductTraking()
        {
            listViewOrder.Items.Clear();
            foreach (ProductTraking product in Program.des.ProductTraking)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                       product.IdWorker.ToString()+". "+product.WorkerSet.FirstName+" "+product.WorkerSet.MiddleName+" "+product.WorkerSet.LastName,
                       product.IdSoups.ToString()+". "+product.SoupsSet.Dish, product.SoupsSet.Prise,
                       product.IdSecondCourse.ToString()+". "+product.SecondCourseSet.Dish, product.SecondCourseSet.Prise,
                       product.IdSalad.ToString()+". "+ product.SaladSet.Dish, product.SaladSet.Prise,
                       product.IdDrink.ToString()+". "+ product.DrinkSet.Dish, product.DrinkSet.Prise,
                      (
                   Convert.ToInt32(product.SoupsSet.Prise) +
                   Convert.ToInt32(product.SecondCourseSet.Prise) +
                   Convert.ToInt32(product.SaladSet.Prise) +
                   Convert.ToInt32(product.DrinkSet.Prise)
                      ).ToString()
                    });
                item.Tag = product;
                listViewOrder.Items.Add(item);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                ProductTraking product = listViewOrder.SelectedItems[0].Tag as ProductTraking;
                product.IdWorker = Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split('.')[0]);
                product.IdSoups = Convert.ToInt32(comboBoxSoups.SelectedItem.ToString().Split('.')[0]);
                product.IdSalad = Convert.ToInt32(comboBoxSalad.SelectedItem.ToString().Split('.')[0]);
                product.IdSecondCourse = Convert.ToInt32(comboBoxSecondCourse.SelectedItem.ToString().Split('.')[0]);
                product.IdDrink = Convert.ToInt32(comboBoxDrink.SelectedItem.ToString().Split('.')[0]);
                Program.des.SaveChanges();
                ShowProductTraking();
                UpdatetextboxPrise();
            }
        }
        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count == 1)
            {
                ProductTraking product = listViewOrder.SelectedItems[0].Tag as ProductTraking;
                comboBoxSalad.SelectedIndex = comboBoxSalad.FindString(product.IdSalad.ToString());
                comboBoxWorker.SelectedIndex = comboBoxWorker.FindString(product.IdWorker.ToString());
                comboBoxSoups.SelectedIndex = comboBoxSoups.FindString(product.IdSoups.ToString());
                comboBoxDrink.SelectedIndex = comboBoxDrink.FindString(product.IdDrink.ToString());
                comboBoxSecondCourse.SelectedIndex = comboBoxSecondCourse.FindString(product.IdSecondCourse.ToString());
            }
            else
            {
                comboBoxSalad.SelectedItem = null;
                comboBoxSoups.SelectedItem = null;
                comboBoxWorker.SelectedItem = null;
                comboBoxDrink.SelectedItem = null;
                comboBoxSecondCourse.SelectedItem = null;
            }
            UpdatetextboxPrise();
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrder.SelectedItems.Count == 1)
                {
                    ProductTraking product = listViewOrder.SelectedItems[0].Tag as ProductTraking;
                    Program.des.ProductTraking.Remove(product);
                    Program.des.SaveChanges();
                    ShowProductTraking();
                }
                comboBoxSoups.SelectedItem = null;
                comboBoxSalad.SelectedItem = null;
                comboBoxSecondCourse.SelectedItem = null;
                comboBoxDrink.SelectedItem = null;
                comboBoxWorker.SelectedItem = null;
            }
         
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdatetextboxPrise();
        }

        void UpdatetextboxPrise()
        { 
            int summsun= 0;
            foreach (ProductTraking product in Program.des.ProductTraking)
            {
                int a = Convert.ToInt32(product.SoupsSet.Prise);
                int b = Convert.ToInt32(product.SecondCourseSet.Prise);
                int c = Convert.ToInt32(product.SaladSet.Prise);
                int d = Convert.ToInt32(product.DrinkSet.Prise);
                int summ = a + b + c + d;
               
                summsun = summsun + summ;
                textBoxPrise.Text =(summsun).ToString();               
            }
        }
    }
}



