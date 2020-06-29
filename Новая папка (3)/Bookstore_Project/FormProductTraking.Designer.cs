namespace Bookstore_Project
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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.listViewChekProduct = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(162, 57);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 23);
            this.comboBoxClient.TabIndex = 0;
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(319, 57);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWorker.TabIndex = 1;
            this.comboBoxWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorker_SelectedIndexChanged);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(497, 57);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 23);
            this.comboBoxProduct.TabIndex = 2;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(159, 32);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(49, 15);
            this.labelClient.TabIndex = 3;
            this.labelClient.Text = "Клиент";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorker.Location = new System.Drawing.Point(316, 32);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(69, 15);
            this.labelWorker.TabIndex = 4;
            this.labelWorker.Text = "Сотрудник";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(494, 32);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(42, 15);
            this.labelProduct.TabIndex = 5;
            this.labelProduct.Text = "Товар";
            // 
            // listViewChekProduct
            // 
            this.listViewChekProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader5});
            this.listViewChekProduct.FullRowSelect = true;
            this.listViewChekProduct.GridLines = true;
            this.listViewChekProduct.HideSelection = false;
            this.listViewChekProduct.Location = new System.Drawing.Point(8, 103);
            this.listViewChekProduct.MultiSelect = false;
            this.listViewChekProduct.Name = "listViewChekProduct";
            this.listViewChekProduct.Size = new System.Drawing.Size(610, 237);
            this.listViewChekProduct.TabIndex = 6;
            this.listViewChekProduct.UseCompatibleStateImageBehavior = false;
            this.listViewChekProduct.View = System.Windows.Forms.View.Details;
            this.listViewChekProduct.SelectedIndexChanged += new System.EventHandler(this.listViewChekProduct_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id Клиента";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ФИО клиента";
            this.columnHeader6.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " Id Сотрудникa";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО сотрудника";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id Товарa";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Товар";
            this.columnHeader7.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(381, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 38);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(462, 356);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 38);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(543, 356);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 38);
            this.buttonDel.TabIndex = 9;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormProductTraking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(644, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewChekProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxWorker);
            this.Controls.Add(this.comboBoxClient);
            this.Name = "FormProductTraking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет проданного товара";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ListView listViewChekProduct;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}