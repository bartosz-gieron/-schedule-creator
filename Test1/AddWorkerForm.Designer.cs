namespace Test1
{
    partial class AddWorkerForm
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
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkerForm));
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox_Pesel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_stat = new System.Windows.Forms.TextBox();
            this.add_employer_btn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(label4, 3);
            label4.Location = new System.Drawing.Point(3, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 13);
            label4.TabIndex = 10;
            label4.Text = "Ulica i numer domu";
            // 
            // textBox_code
            // 
            this.textBox_Code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_Code, 3);
            this.textBox_Code.Location = new System.Drawing.Point(3, 185);
            this.textBox_Code.MaxLength = 10;
            this.textBox_Code.Name = "textBox_code";
            this.textBox_Code.Size = new System.Drawing.Size(224, 20);
            this.textBox_Code.TabIndex = 13;
            this.textBox_Code.TextChanged += new System.EventHandler(this.TextBoxCode_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miejscowość";
            // 
            // textBox_city
            // 
            this.textBox_city.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_city.Location = new System.Drawing.Point(233, 185);
            this.textBox_city.MaxLength = 50;
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(224, 20);
            this.textBox_city.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kod pocztowy";
            // 
            // textBox_street
            // 
            this.textBox_street.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_street, 4);
            this.textBox_street.Location = new System.Drawing.Point(3, 133);
            this.textBox_street.MaxLength = 150;
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(454, 20);
            this.textBox_street.TabIndex = 12;
            // 
            // textBox_pesel
            // 
            this.textBox_Pesel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_Pesel, 3);
            this.textBox_Pesel.Location = new System.Drawing.Point(3, 81);
            this.textBox_Pesel.MaxLength = 11;
            this.textBox_Pesel.Name = "textBox_pesel";
            this.textBox_Pesel.Size = new System.Drawing.Size(224, 20);
            this.textBox_Pesel.TabIndex = 9;
            this.textBox_Pesel.TextChanged += new System.EventHandler(this.TextBoxPesel_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_name, 3);
            this.textBox_name.Location = new System.Drawing.Point(3, 29);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(224, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_surname.Location = new System.Drawing.Point(233, 29);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(224, 20);
            this.textBox_surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pesel";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_surname, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Pesel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_street, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_city, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Code, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Phone, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBox_email, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBox_stat, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.add_employer_btn, 3, 15);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_phone
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_Phone, 3);
            this.textBox_Phone.Location = new System.Drawing.Point(3, 237);
            this.textBox_Phone.MaxLength = 15;
            this.textBox_Phone.Name = "textBox_phone";
            this.textBox_Phone.Size = new System.Drawing.Size(224, 20);
            this.textBox_Phone.TabIndex = 18;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.TextBoxPhone_TextChanged_2);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 3);
            this.label8.Location = new System.Drawing.Point(3, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Telefon Kontaktowy";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "email";
            // 
            // textBox_email
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_email, 3);
            this.textBox_email.Location = new System.Drawing.Point(3, 289);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(224, 20);
            this.textBox_email.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Stanowisko";
            // 
            // textBox_stat
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_stat, 3);
            this.textBox_stat.Location = new System.Drawing.Point(3, 341);
            this.textBox_stat.Name = "textBox_stat";
            this.textBox_stat.Size = new System.Drawing.Size(224, 20);
            this.textBox_stat.TabIndex = 23;
            // 
            // add_employer_btn
            // 
            this.add_employer_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_employer_btn.Location = new System.Drawing.Point(371, 502);
            this.add_employer_btn.Name = "add_employer_btn";
            this.add_employer_btn.Size = new System.Drawing.Size(86, 32);
            this.add_employer_btn.TabIndex = 24;
            this.add_employer_btn.Text = "Dodaj";
            this.add_employer_btn.UseVisualStyleBackColor = true;
            this.add_employer_btn.Click += new System.EventHandler(this.AddWorkerBtn_CLick);
            // 
            // Form4
            // 
            this.AcceptButton = this.add_employer_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Dodaj Pracownika";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pesel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_stat;
        private System.Windows.Forms.Button add_employer_btn;
    }
}