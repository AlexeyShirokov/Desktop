namespace Bookstore_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenWorker = new System.Windows.Forms.Button();
            this.buttonOpenProduct = new System.Windows.Forms.Button();
            this.buttonOpenProductTraking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCanel = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.Location = new System.Drawing.Point(24, 109);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenClients.TabIndex = 0;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenWorker
            // 
            this.buttonOpenWorker.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOpenWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenWorker.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenWorker.Location = new System.Drawing.Point(24, 167);
            this.buttonOpenWorker.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenWorker.Name = "buttonOpenWorker";
            this.buttonOpenWorker.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenWorker.TabIndex = 1;
            this.buttonOpenWorker.Text = "Сотрудники";
            this.buttonOpenWorker.UseVisualStyleBackColor = false;
            this.buttonOpenWorker.Click += new System.EventHandler(this.buttonOpenWorker_Click);
            // 
            // buttonOpenProduct
            // 
            this.buttonOpenProduct.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOpenProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenProduct.Location = new System.Drawing.Point(24, 226);
            this.buttonOpenProduct.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenProduct.Name = "buttonOpenProduct";
            this.buttonOpenProduct.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenProduct.TabIndex = 2;
            this.buttonOpenProduct.Text = "Товары";
            this.buttonOpenProduct.UseVisualStyleBackColor = false;
            this.buttonOpenProduct.Click += new System.EventHandler(this.buttonOpenProduct_Click);
            // 
            // buttonOpenProductTraking
            // 
            this.buttonOpenProductTraking.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOpenProductTraking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenProductTraking.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenProductTraking.Location = new System.Drawing.Point(24, 285);
            this.buttonOpenProductTraking.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenProductTraking.Name = "buttonOpenProductTraking";
            this.buttonOpenProductTraking.Size = new System.Drawing.Size(250, 50);
            this.buttonOpenProductTraking.TabIndex = 3;
            this.buttonOpenProductTraking.Text = "Покупка";
            this.buttonOpenProductTraking.UseVisualStyleBackColor = false;
            this.buttonOpenProductTraking.Click += new System.EventHandler(this.buttonOpenProductTraking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCanel
            // 
            this.buttonCanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanel.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCanel.Location = new System.Drawing.Point(24, 342);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(250, 50);
            this.buttonCanel.TabIndex = 12;
            this.buttonCanel.Text = "Выйти из программы";
            this.buttonCanel.UseVisualStyleBackColor = false;
            this.buttonCanel.Click += new System.EventHandler(this.buttonCanel_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(0, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(44, 13);
            this.labelHello.TabIndex = 13;
            this.labelHello.Text = "Привет";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(300, 423);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenProductTraking);
            this.Controls.Add(this.buttonOpenProduct);
            this.Controls.Add(this.buttonOpenWorker);
            this.Controls.Add(this.buttonOpenClients);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenWorker;
        private System.Windows.Forms.Button buttonOpenProduct;
        private System.Windows.Forms.Button buttonOpenProductTraking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCanel;
        private System.Windows.Forms.Label labelHello;
    }
}

