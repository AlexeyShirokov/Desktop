namespace My_progect
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonCanel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labeLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(40, 120);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(212, 23);
            this.textBoxPassword.TabIndex = 20;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(40, 64);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(212, 23);
            this.textBoxLogin.TabIndex = 19;
            // 
            // buttonCanel
            // 
            this.buttonCanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCanel.Location = new System.Drawing.Point(158, 159);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(125, 55);
            this.buttonCanel.TabIndex = 18;
            this.buttonCanel.Text = "Отмена";
            this.buttonCanel.UseVisualStyleBackColor = false;
            this.buttonCanel.Click += new System.EventHandler(this.buttonCanel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOK.Location = new System.Drawing.Point(20, 159);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(125, 55);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "Войти";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labeLogin
            // 
            this.labeLogin.AutoSize = true;
            this.labeLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeLogin.Location = new System.Drawing.Point(37, 43);
            this.labeLogin.Name = "labeLogin";
            this.labeLogin.Size = new System.Drawing.Size(48, 18);
            this.labeLogin.TabIndex = 16;
            this.labeLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(37, 99);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 18);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Пароль";
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHead.Location = new System.Drawing.Point(16, 14);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(278, 19);
            this.labelHead.TabIndex = 14;
            this.labelHead.Text = "Войдите под своей учетной записью";
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(313, 237);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labeLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelHead);
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAutorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonCanel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labeLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelHead;
    }
}