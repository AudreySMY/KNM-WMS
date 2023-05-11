namespace GuiSAP
{
    partial class Frm_Login
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
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Uighur", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(79, 106);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(324, 114);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "SapClone";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(146, 223);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(210, 20);
            this.txb_username.TabIndex = 1;
            this.txb_username.TextChanged += new System.EventHandler(this.txb_username_TextChanged);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(146, 249);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(210, 20);
            this.txb_Password.TabIndex = 2;
            this.txb_Password.TextChanged += new System.EventHandler(this.txb_Password_TextChanged);
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(83, 226);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(57, 13);
            this.Lbl_UserName.TabIndex = 4;
            this.Lbl_UserName.Text = "UserName";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(83, 252);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(146, 276);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(210, 33);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Logar";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.Lbl_Title);
            this.Name = "Frm_Login";
            this.Text = "Mean";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button Btn_Login;
    }
}