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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();

        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientsSet in Program.mpgc.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                      clientsSet.Id.ToString(),
                      clientsSet.FirstName,
                      clientsSet.MiddleName,
                      clientsSet.LastName,
                      clientsSet.Phone,
                      clientsSet.Email
                    });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }

            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientSet clientsSet = new ClientSet();
            clientsSet.FirstName = textBoxFirstName.Text;
            clientsSet.MiddleName = textBoxMiddleName.Text;
            clientsSet.LastName = textBoxLastName.Text;
            clientsSet.Phone = textBoxPhone.Text;
            clientsSet.Email = textBoxEmail.Text;
            Program.mpgc.ClientSet.Add(clientsSet);
            Program.mpgc.SaveChanges();
            ShowClient();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientsSet.FirstName = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.mpgc.SaveChanges();
                ShowClient();

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.mpgc.ClientSet.Remove(clientsSet);
                    Program.mpgc.SaveChanges();
                    ShowClient();
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
