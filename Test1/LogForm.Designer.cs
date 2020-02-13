namespace Test1
{
    partial class LogForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.Login_bt = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_bt
            // 
            this.Login_bt.Location = new System.Drawing.Point(12, 264);
            this.Login_bt.Name = "Login_bt";
            this.Login_bt.Size = new System.Drawing.Size(329, 23);
            this.Login_bt.TabIndex = 2;
            this.Login_bt.Text = "Zaloguj";
            this.Login_bt.UseVisualStyleBackColor = true;
            this.Login_bt.Click += new System.EventHandler(this.LoginBtnClick);
            // 
            // passField
            // 
            this.passField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passField.Location = new System.Drawing.Point(12, 198);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(329, 20);
            this.passField.TabIndex = 1;
            this.passField.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(9, 182);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(36, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Hasło";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(12, 159);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(329, 20);
            this.loginField.TabIndex = 0;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(9, 143);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(42, 237);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 5;
            // 
            // Logowanie
            // 
            this.AcceptButton = this.Login_bt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(359, 426);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.Login_bt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel logowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button Login_bt;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label infoLabel;
    }
}

