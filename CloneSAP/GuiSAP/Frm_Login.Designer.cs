namespace GuiSAP
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Log = new System.Windows.Forms.Button();
            this.Txb_User = new System.Windows.Forms.TextBox();
            this.Txb_Pass = new System.Windows.Forms.TextBox();
            this.Txb_Lang = new System.Windows.Forms.TextBox();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Lang = new System.Windows.Forms.Label();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Log
            // 
            this.Btn_Log.Location = new System.Drawing.Point(122, 286);
            this.Btn_Log.Name = "Btn_Log";
            this.Btn_Log.Size = new System.Drawing.Size(246, 27);
            this.Btn_Log.TabIndex = 0;
            this.Btn_Log.Text = "Logar";
            this.Btn_Log.UseVisualStyleBackColor = true;
            this.Btn_Log.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txb_User
            // 
            this.Txb_User.Location = new System.Drawing.Point(195, 192);
            this.Txb_User.Name = "Txb_User";
            this.Txb_User.Size = new System.Drawing.Size(173, 20);
            this.Txb_User.TabIndex = 1;
            // 
            // Txb_Pass
            // 
            this.Txb_Pass.Location = new System.Drawing.Point(195, 218);
            this.Txb_Pass.MaxLength = 20;
            this.Txb_Pass.Name = "Txb_Pass";
            this.Txb_Pass.PasswordChar = '*';
            this.Txb_Pass.Size = new System.Drawing.Size(173, 20);
            this.Txb_Pass.TabIndex = 2;
            // 
            // Txb_Lang
            // 
            this.Txb_Lang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Lang.Location = new System.Drawing.Point(195, 244);
            this.Txb_Lang.MaxLength = 2;
            this.Txb_Lang.Name = "Txb_Lang";
            this.Txb_Lang.Size = new System.Drawing.Size(17, 20);
            this.Txb_Lang.TabIndex = 3;
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(119, 195);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(68, 13);
            this.Lbl_User.TabIndex = 4;
            this.Lbl_User.Text = "USERNAME";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(119, 221);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Password.TabIndex = 5;
            this.Lbl_Password.Text = "PASSWORD";
            // 
            // Lbl_Lang
            // 
            this.Lbl_Lang.AutoSize = true;
            this.Lbl_Lang.Location = new System.Drawing.Point(119, 247);
            this.Lbl_Lang.Name = "Lbl_Lang";
            this.Lbl_Lang.Size = new System.Drawing.Size(66, 13);
            this.Lbl_Lang.TabIndex = 6;
            this.Lbl_Lang.Text = "LANGUAGE";
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Microsoft Uighur", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(109, 56);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(278, 75);
            this.Lbl_Title.TabIndex = 7;
            this.Lbl_Title.Text = "SAP CLONE";
            this.Lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Lbl_Lang);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_User);
            this.Controls.Add(this.Txb_Lang);
            this.Controls.Add(this.Txb_Pass);
            this.Controls.Add(this.Txb_User);
            this.Controls.Add(this.Btn_Log);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Log;
        private System.Windows.Forms.TextBox Txb_User;
        private System.Windows.Forms.TextBox Txb_Pass;
        private System.Windows.Forms.TextBox Txb_Lang;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_Lang;
        private System.Windows.Forms.Label Lbl_Title;
    }
}

