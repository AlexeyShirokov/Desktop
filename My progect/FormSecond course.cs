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
    public partial class FormSecond_course : Form
    {
        public FormSecond_course()
        {
            InitializeComponent();
            ShowSecondCourse();
        }
        void ShowSecondCourse()
        {
            listViewSecondCourse.Items.Clear();
            foreach (SecondCourseSet secondCourseSet in Program.des.SecondCourseSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                     secondCourseSet.Id.ToString(),
                     secondCourseSet.Dish,
                     secondCourseSet.Сomposition,
                     secondCourseSet.Prise,

                    });
                item.Tag = secondCourseSet;
                listViewSecondCourse.Items.Add(item);
            }

            listViewSecondCourse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SecondCourseSet secondCourseSet = new SecondCourseSet();
            secondCourseSet.Dish = textBoxDish.Text;
            secondCourseSet.Сomposition = richTextBoxСomposition.Text;
            secondCourseSet.Prise = textBoxPrise.Text;
            Program.des.SecondCourseSet.Add(secondCourseSet);
            Program.des.SaveChanges();
            ShowSecondCourse();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSecondCourse.SelectedItems.Count == 1)
            {
                SecondCourseSet secondCourseSet = listViewSecondCourse.SelectedItems[0].Tag as SecondCourseSet;
                secondCourseSet.Dish = textBoxDish.Text;
                secondCourseSet.Сomposition = richTextBoxСomposition.Text;
                secondCourseSet.Prise = textBoxPrise.Text;
                Program.des.SaveChanges();
                ShowSecondCourse();
            }
        }

       

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSecondCourse.SelectedItems.Count == 1)
                {
                    SecondCourseSet secondCourseSet = listViewSecondCourse.SelectedItems[0].Tag as SecondCourseSet;               
                    Program.des.SecondCourseSet.Remove(secondCourseSet);
                    Program.des.SaveChanges();
                    ShowSecondCourse();
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
            if (listViewSecondCourse.SelectedItems.Count == 1)
            {
                SecondCourseSet secondCourseSet = listViewSecondCourse.SelectedItems[0].Tag as SecondCourseSet;
                textBoxDish.Text = secondCourseSet.Dish;
                richTextBoxСomposition.Text = secondCourseSet.Сomposition;
                textBoxPrise.Text = secondCourseSet.Prise;

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

