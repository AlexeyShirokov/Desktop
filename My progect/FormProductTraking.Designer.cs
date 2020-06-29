namespace My_progect
{
    partial class FormProductTraking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductTraking));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDrink = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelSalad = new System.Windows.Forms.Label();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.comboBoxSalad = new System.Windows.Forms.ComboBox();
            this.comboBoxSecondCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxSoups = new System.Windows.Forms.ComboBox();
            this.labelSoups = new System.Windows.Forms.Label();
            this.labelSecondCourse = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(227, 76);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader4});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.GridLines = true;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(12, 127);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(1303, 217);
            this.listViewOrder.TabIndex = 17;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Сотрудник";
            this.columnHeader6.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Первое блюдо";
            this.columnHeader3.Width = 221;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Цена";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Горячее блюдо ";
            this.columnHeader2.Width = 248;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Цена";
            this.columnHeader7.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Салат";
            this.columnHeader5.Width = 178;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Цена";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Напиток";
            this.columnHeader9.Width = 139;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Цена";
            this.columnHeader10.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Сумма заказа";
            this.columnHeader4.Width = 113;
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrink.Location = new System.Drawing.Point(850, 54);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(60, 15);
            this.labelDrink.TabIndex = 16;
            this.labelDrink.Text = "Напитки ";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorker.Location = new System.Drawing.Point(260, 54);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(62, 15);
            this.labelWorker.TabIndex = 15;
            this.labelWorker.Text = "Сотрудик";
            // 
            // labelSalad
            // 
            this.labelSalad.AutoSize = true;
            this.labelSalad.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalad.Location = new System.Drawing.Point(695, 54);
            this.labelSalad.Name = "labelSalad";
            this.labelSalad.Size = new System.Drawing.Size(52, 15);
            this.labelSalad.TabIndex = 14;
            this.labelSalad.Text = "Cалаты";
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(853, 79);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDrink.TabIndex = 13;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(263, 79);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWorker.TabIndex = 12;
            // 
            // comboBoxSalad
            // 
            this.comboBoxSalad.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSalad.FormattingEnabled = true;
            this.comboBoxSalad.Location = new System.Drawing.Point(698, 79);
            this.comboBoxSalad.Name = "comboBoxSalad";
            this.comboBoxSalad.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSalad.TabIndex = 11;
            // 
            // comboBoxSecondCourse
            // 
            this.comboBoxSecondCourse.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSecondCourse.FormattingEnabled = true;
            this.comboBoxSecondCourse.Location = new System.Drawing.Point(543, 79);
            this.comboBoxSecondCourse.Name = "comboBoxSecondCourse";
            this.comboBoxSecondCourse.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSecondCourse.TabIndex = 23;
            // 
            // comboBoxSoups
            // 
            this.comboBoxSoups.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSoups.FormattingEnabled = true;
            this.comboBoxSoups.Location = new System.Drawing.Point(405, 79);
            this.comboBoxSoups.Name = "comboBoxSoups";
            this.comboBoxSoups.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSoups.TabIndex = 24;
            // 
            // labelSoups
            // 
            this.labelSoups.AutoSize = true;
            this.labelSoups.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoups.Location = new System.Drawing.Point(402, 54);
            this.labelSoups.Name = "labelSoups";
            this.labelSoups.Size = new System.Drawing.Size(93, 15);
            this.labelSoups.TabIndex = 25;
            this.labelSoups.Text = "Первое блюдо";
            // 
            // labelSecondCourse
            // 
            this.labelSecondCourse.AutoSize = true;
            this.labelSecondCourse.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondCourse.Location = new System.Drawing.Point(540, 54);
            this.labelSecondCourse.Name = "labelSecondCourse";
            this.labelSecondCourse.Size = new System.Drawing.Size(97, 15);
            this.labelSecondCourse.TabIndex = 26;
            this.labelSecondCourse.Text = "Горячее блюдо";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(868, 364);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(106, 43);
            this.buttonDel.TabIndex = 63;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(757, 364);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 43);
            this.buttonEdit.TabIndex = 62;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(635, 364);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 43);
            this.buttonAdd.TabIndex = 61;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Location = new System.Drawing.Point(1187, 350);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(128, 20);
            this.textBoxPrise.TabIndex = 64;
        
            // 
            // FormProductTraking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1326, 425);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSecondCourse);
            this.Controls.Add(this.labelSoups);
            this.Controls.Add(this.comboBoxSoups);
            this.Controls.Add(this.comboBoxSecondCourse);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelDrink);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelSalad);
            this.Controls.Add(this.comboBoxDrink);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.comboBoxSalad);
            this.Name = "FormProductTraking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelDrink;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Label labelSalad;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.ComboBox comboBoxSalad;
        private System.Windows.Forms.ComboBox comboBoxSecondCourse;
        private System.Windows.Forms.ComboBox comboBoxSoups;
        private System.Windows.Forms.Label labelSoups;
        private System.Windows.Forms.Label labelSecondCourse;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}