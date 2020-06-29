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
    public partial class FormWorker : System.Windows.Forms.Form
    {
        public FormWorker()
        {
            InitializeComponent();
            ShowWorker();
        }
        void ShowWorker()
        {
            listViewWorker.Items.Clear();
            foreach (WorkerSet workerSet in Program.des.WorkerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                      workerSet.Id.ToString(),
                      workerSet.FirstName,
                      workerSet.MiddleName,
                      workerSet.LastName,
                      workerSet.Phone                    
                    });
                item.Tag = workerSet;
                listViewWorker.Items.Add(item);
            }

            listViewWorker.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }        
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            WorkerSet workerSet = new WorkerSet();
            workerSet.FirstName = textBoxFirstName.Text;
            workerSet.MiddleName = textBoxMiddleName.Text;
            workerSet.LastName = textBoxLastName.Text;
            workerSet.Phone = textBoxPhone.Text;
            Program.des.WorkerSet.Add(workerSet);
            Program.des.SaveChanges();
            ShowWorker();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewWorker.SelectedItems.Count == 1)
            {
                WorkerSet workerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                workerSet.FirstName = textBoxFirstName.Text;
                workerSet.MiddleName = textBoxMiddleName.Text;
                workerSet.LastName = textBoxLastName.Text;
                workerSet.Phone = textBoxPhone.Text;
                Program.des.SaveChanges();
                ShowWorker();
            }

        }

        private void listViewWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorker.SelectedItems.Count == 1)
            {
                WorkerSet workerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                textBoxFirstName.Text = workerSet.FirstName;
                textBoxMiddleName.Text = workerSet.MiddleName;
                textBoxLastName.Text = workerSet.LastName;
                textBoxPhone.Text = workerSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewWorker.SelectedItems.Count == 1)
                {
                    WorkerSet workerSet = listViewWorker.SelectedItems[0].Tag as WorkerSet;
                    Program.des.WorkerSet.Remove(workerSet);
                    Program.des.SaveChanges();
                    ShowWorker();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

    

