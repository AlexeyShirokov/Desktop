namespace Bookstore_Project
{
    partial class FormAutorization
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
            this.labelHead = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labeLogin = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCanel = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHead.Location = new System.Drawing.Point(15, 12);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(271, 18);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Войдите под своей учетной записью";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(17, 89);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(51, 15);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Пароль";
            // 
            // labeLogin
            // 
            this.labeLogin.AutoSize = true;
            this.labeLogin.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeLogin.Location = new System.Drawing.Point(27, 49);
            this.labeLogin.Name = "labeLogin";
            this.labeLogin.Size = new System.Drawing.Size(42, 15);
            this.labeLogin.TabIndex = 2;
            this.labeLogin.Text = "Логин";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOK.Location = new System.Drawing.Point(18, 125);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(130, 36);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Войти";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCanel
            // 
            this.buttonCanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanel.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCanel.Location = new System.Drawing.Point(156, 125);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(130, 36);
            this.buttonCanel.TabIndex = 4;
            this.buttonCanel.Text = "Отмена";
            this.buttonCanel.UseVisualStyleBackColor = false;
            this.buttonCanel.Click += new System.EventHandler(this.buttonCanel_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(74, 46);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(212, 23);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(74, 86);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(212, 23);
            this.textBoxPassword.TabIndex = 6;
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(299, 170);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labeLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelHead);
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labeLogin;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCanel;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}