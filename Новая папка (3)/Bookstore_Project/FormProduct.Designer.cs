namespace Bookstore_Project
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.listViewOfficeSupplies = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTableGames = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNameOfficeSupply = new System.Windows.Forms.TextBox();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGameName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameOfficeSupply = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelPrise = new System.Windows.Forms.Label();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxType.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Книги",
            "Настольные игры",
            "Канцтовары"});
            this.comboBoxType.Location = new System.Drawing.Point(22, 109);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxType.TabIndex = 0;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // listViewOfficeSupplies
            // 
            this.listViewOfficeSupplies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader7});
            this.listViewOfficeSupplies.FullRowSelect = true;
            this.listViewOfficeSupplies.GridLines = true;
            this.listViewOfficeSupplies.HideSelection = false;
            this.listViewOfficeSupplies.Location = new System.Drawing.Point(194, 65);
            this.listViewOfficeSupplies.MultiSelect = false;
            this.listViewOfficeSupplies.Name = "listViewOfficeSupplies";
            this.listViewOfficeSupplies.Size = new System.Drawing.Size(543, 312);
            this.listViewOfficeSupplies.TabIndex = 1;
            this.listViewOfficeSupplies.UseCompatibleStateImageBehavior = false;
            this.listViewOfficeSupplies.View = System.Windows.Forms.View.Details;
            this.listViewOfficeSupplies.SelectedIndexChanged += new System.EventHandler(this.listViewOfficeSupplies_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Наименование товара ";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Цена";
            // 
            // listViewBooks
            // 
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.GridLines = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(194, 65);
            this.listViewBooks.MultiSelect = false;
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(543, 312);
            this.listViewBooks.TabIndex = 2;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            this.listViewBooks.Visible = false;
            this.listViewBooks.SelectedIndexChanged += new System.EventHandler(this.listViewBooks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Автор ";
            this.columnHeader1.Width = 181;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название ";
            this.columnHeader2.Width = 181;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            // 
            // listViewTableGames
            // 
            this.listViewTableGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6});
            this.listViewTableGames.FullRowSelect = true;
            this.listViewTableGames.GridLines = true;
            this.listViewTableGames.HideSelection = false;
            this.listViewTableGames.Location = new System.Drawing.Point(194, 64);
            this.listViewTableGames.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.listViewTableGames.MultiSelect = false;
            this.listViewTableGames.Name = "listViewTableGames";
            this.listViewTableGames.Size = new System.Drawing.Size(543, 313);
            this.listViewTableGames.TabIndex = 3;
            this.listViewTableGames.UseCompatibleStateImageBehavior = false;
            this.listViewTableGames.View = System.Windows.Forms.View.Details;
            this.listViewTableGames.SelectedIndexChanged += new System.EventHandler(this.listViewTableGames_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Название игры";
            this.columnHeader3.Width = 260;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            this.columnHeader6.Width = 280;
            // 
            // textBoxNameOfficeSupply
            // 
            this.textBoxNameOfficeSupply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNameOfficeSupply.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameOfficeSupply.Location = new System.Drawing.Point(22, 213);
            this.textBoxNameOfficeSupply.Name = "textBoxNameOfficeSupply";
            this.textBoxNameOfficeSupply.Size = new System.Drawing.Size(100, 23);
            this.textBoxNameOfficeSupply.TabIndex = 4;
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxGameName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGameName.Location = new System.Drawing.Point(22, 163);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(100, 23);
            this.textBoxGameName.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAuthor.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(23, 258);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 23);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(23, 308);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(99, 23);
            this.textBoxName.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelType.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(19, 93);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(75, 15);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Тип товара ";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAuthor.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.Location = new System.Drawing.Point(20, 242);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(42, 15);
            this.labelAuthor.TabIndex = 9;
            this.labelAuthor.Text = "Автор";
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameName.Location = new System.Drawing.Point(19, 144);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(97, 15);
            this.labelGameName.TabIndex = 10;
            this.labelGameName.Text = "Название игры";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(20, 292);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 15);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Название ";
            // 
            // labelNameOfficeSupply
            // 
            this.labelNameOfficeSupply.AutoSize = true;
            this.labelNameOfficeSupply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNameOfficeSupply.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfficeSupply.Location = new System.Drawing.Point(19, 194);
            this.labelNameOfficeSupply.Name = "labelNameOfficeSupply";
            this.labelNameOfficeSupply.Size = new System.Drawing.Size(171, 15);
            this.labelNameOfficeSupply.TabIndex = 12;
            this.labelNameOfficeSupply.Text = "Наименование канцтовара ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(462, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 38);
            this.buttonAdd.TabIndex = 13;
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
            this.buttonEdit.Location = new System.Drawing.Point(560, 383);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 38);
            this.buttonEdit.TabIndex = 14;
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
            this.buttonDel.Location = new System.Drawing.Point(658, 383);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 38);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrise.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrise.Location = new System.Drawing.Point(23, 338);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(37, 15);
            this.labelPrise.TabIndex = 16;
            this.labelPrise.Text = "Цена";
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPrise.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrise.Location = new System.Drawing.Point(23, 354);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(99, 23);
            this.textBoxPrise.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(751, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.labelPrise);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelNameOfficeSupply);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.textBoxNameOfficeSupply);
            this.Controls.Add(this.listViewTableGames);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.listViewOfficeSupplies);
            this.Controls.Add(this.comboBoxType);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ListView listViewOfficeSupplies;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ListView listViewTableGames;
        private System.Windows.Forms.TextBox textBoxNameOfficeSupply;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameOfficeSupply;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}