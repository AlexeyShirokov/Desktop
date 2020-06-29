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
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
            ShowWorker();
        }
        void ShowWorker()
        {
            listViewWorker.Items.Clear();
            foreach (WorkerSet worcerSet in Program.mpgc.WorkerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                      worcerSet.Id.ToString(),
                      worcerSet.FirstName,
                      worcerSet.MiddleName,
                      worcerSet.LastName,
                      worcerSet.Phone,
                      worcerSet.Email
                    });
                item.Tag = worcerSet;
                listViewWorker.Items.Add(item);
            }

            listViewWorker.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WorkerSet worcerSet = new WorkerSet();
            worcerSet.FirstName = textBoxFirstName.Text;
            worcerSet.MiddleName = textBoxMiddleName.Text;
            worcerSet.LastName = textBoxLastName.Text;
            worcerSet.Phone = textBoxPhone.Text;
            worcerSet.Email = textBoxEmail.Text;
            Program.mpgc.WorkerSet.Add(worcerSet);
            Program.mpgc.SaveChanges();
            ShowWorker();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
                if (listViewWorker.SelectedItems.Count == 1)
                {
                    WorkerSet worcerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                    worcerSet.FirstName = textBoxFirstName.Text;
                    worcerSet.MiddleName = textBoxMiddleName.Text;
                    worcerSet.LastName = textBoxLastName.Text;
                    worcerSet.Phone = textBoxPhone.Text;
                    worcerSet.Email = textBoxEmail.Text;
                    Program.mpgc.SaveChanges();
                    ShowWorker();

                }
               

            }

        private void listViewWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorker.SelectedItems.Count == 1)
            {
                WorkerSet clientsSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                textBoxFirstName.Text = clientsSet.FirstName;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewWorker.SelectedItems.Count == 1)
                {
                    WorkerSet worcerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                    Program.mpgc.WorkerSet.Remove(worcerSet);
                    Program.mpgc.SaveChanges();
                    ShowWorker();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

       

    }
    

