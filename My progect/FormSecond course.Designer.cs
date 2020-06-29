namespace My_progect
{
    partial class FormSecond_course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecond_course));
            this.richTextBoxСomposition = new System.Windows.Forms.RichTextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPrise = new System.Windows.Forms.TextBox();
            this.textBoxDish = new System.Windows.Forms.TextBox();
            this.labelPrise = new System.Windows.Forms.Label();
            this.labelComposition = new System.Windows.Forms.Label();
            this.labelDish = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewSecondCourse = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxСomposition
            // 
            this.richTextBoxСomposition.Location = new System.Drawing.Point(26, 135);
            this.richTextBoxСomposition.Name = "richTextBoxСomposition";
            this.richTextBoxСomposition.Size = new System.Drawing.Size(119, 96);
            this.richTextBoxСomposition.TabIndex = 50;
            this.richTextBoxСomposition.Text = "";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(502, 263);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(106, 43);
            this.buttonDel.TabIndex = 49;
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
            this.buttonEdit.Location = new System.Drawing.Point(391, 263);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 43);
            this.buttonEdit.TabIndex = 48;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPrise
            // 
            this.textBoxPrise.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrise.Location = new System.Drawing.Point(26, 260);
            this.textBoxPrise.Name = "textBoxPrise";
            this.textBoxPrise.Size = new System.Drawing.Size(119, 23);
            this.textBoxPrise.TabIndex = 47;
            // 
            // textBoxDish
            // 
            this.textBoxDish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDish.Location = new System.Drawing.Point(26, 78);
            this.textBoxDish.Name = "textBoxDish";
            this.textBoxDish.Size = new System.Drawing.Size(119, 23);
            this.textBoxDish.TabIndex = 46;
            // 
            // labelPrise
            // 
            this.labelPrise.AutoSize = true;
            this.labelPrise.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrise.Location = new System.Drawing.Point(23, 241);
            this.labelPrise.Name = "labelPrise";
            this.labelPrise.Size = new System.Drawing.Size(84, 16);
            this.labelPrise.TabIndex = 45;
            this.labelPrise.Text = "Цена блюда ";
            // 
            // labelComposition
            // 
            this.labelComposition.AutoSize = true;
            this.labelComposition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComposition.Location = new System.Drawing.Point(23, 116);
            this.labelComposition.Name = "labelComposition";
            this.labelComposition.Size = new System.Drawing.Size(95, 16);
            this.labelComposition.TabIndex = 44;
            this.labelComposition.Text = "Состав блюда ";
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDish.Location = new System.Drawing.Point(23, 60);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(47, 16);
            this.labelDish.TabIndex = 43;
            this.labelDish.Text = "Блюдо";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(269, 263);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 43);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewSecondCourse
            // 
            this.listViewSecondCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listViewSecondCourse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewSecondCourse.FullRowSelect = true;
            this.listViewSecondCourse.GridLines = true;
            this.listViewSecondCourse.HideSelection = false;
            this.listViewSecondCourse.Location = new System.Drawing.Point(172, 40);
            this.listViewSecondCourse.MultiSelect = false;
            this.listViewSecondCourse.Name = "listViewSecondCourse";
            this.listViewSecondCourse.Size = new System.Drawing.Size(484, 217);
            this.listViewSecondCourse.TabIndex = 51;
            this.listViewSecondCourse.UseCompatibleStateImageBehavior = false;
            this.listViewSecondCourse.View = System.Windows.Forms.View.Details;
            this.listViewSecondCourse.SelectedIndexChanged += new System.EventHandler(this.listViewSecondCourse_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Блюдо";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Состав блюда";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Цена блюда";
            this.columnHeader4.Width = 181;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(166, 57);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 52;
            this.pictureBox.TabStop = false;
            // 
            // FormSecond_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(667, 317);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listViewSecondCourse);
            this.Controls.Add(this.richTextBoxСomposition);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPrise);
            this.Controls.Add(this.textBoxDish);
            this.Controls.Add(this.labelPrise);
            this.Controls.Add(this.labelComposition);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormSecond_course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Горячее блюдо ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxСomposition;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxPrise;
        private System.Windows.Forms.TextBox textBoxDish;
        private System.Windows.Forms.Label labelPrise;
        private System.Windows.Forms.Label labelComposition;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewSecondCourse;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}