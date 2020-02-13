namespace Test1
{
    partial class AddTimeTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimeTableForm));
            this.listBox_workers = new System.Windows.Forms.ListBox();
            this.listView_TimeTable = new System.Windows.Forms.ListView();
            this.comboBox_station = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_resources = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addWorkerBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_leave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addMainBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Id = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Id)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_workers
            // 
            this.listBox_workers.FormattingEnabled = true;
            this.listBox_workers.Location = new System.Drawing.Point(12, 39);
            this.listBox_workers.Name = "listBox_workers";
            this.listBox_workers.Size = new System.Drawing.Size(158, 563);
            this.listBox_workers.TabIndex = 0;
            // 
            // listView_TimeTable
            // 
            this.listView_TimeTable.FullRowSelect = true;
            this.listView_TimeTable.GridLines = true;
            this.listView_TimeTable.HideSelection = false;
            this.listView_TimeTable.Location = new System.Drawing.Point(436, 39);
            this.listView_TimeTable.Name = "listView_TimeTable";
            this.listView_TimeTable.Size = new System.Drawing.Size(657, 550);
            this.listView_TimeTable.TabIndex = 3;
            this.listView_TimeTable.UseCompatibleStateImageBehavior = false;
            this.listView_TimeTable.View = System.Windows.Forms.View.Details;
            // 
            // comboBox_station
            // 
            this.comboBox_station.FormattingEnabled = true;
            this.comboBox_station.Location = new System.Drawing.Point(932, 7);
            this.comboBox_station.Name = "comboBox_station";
            this.comboBox_station.Size = new System.Drawing.Size(121, 21);
            this.comboBox_station.TabIndex = 8;
            this.comboBox_station.Text = "Brak";
            this.comboBox_station.SelectedIndexChanged += new System.EventHandler(this.ComboBox_station_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stanowisko:";
            // 
            // comboBox_resources
            // 
            this.comboBox_resources.FormattingEnabled = true;
            this.comboBox_resources.Location = new System.Drawing.Point(306, 179);
            this.comboBox_resources.Name = "comboBox_resources";
            this.comboBox_resources.Size = new System.Drawing.Size(121, 21);
            this.comboBox_resources.TabIndex = 10;
            this.comboBox_resources.Text = "Brak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Zasoby:";
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.comboBox_month.Location = new System.Drawing.Point(622, 6);
            this.comboBox_month.MaxDropDownItems = 100;
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_month.TabIndex = 12;
            this.comboBox_month.SelectedIndexChanged += new System.EventHandler(this.ComboBox_year_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Miesiąc:";
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBox_year.Location = new System.Drawing.Point(785, 7);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(70, 21);
            this.comboBox_year.TabIndex = 14;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.ComboBox_year_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(749, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rok:";
            // 
            // addWorkerBtn
            // 
            this.addWorkerBtn.Location = new System.Drawing.Point(176, 265);
            this.addWorkerBtn.Name = "addWorkerBtn";
            this.addWorkerBtn.Size = new System.Drawing.Size(251, 39);
            this.addWorkerBtn.TabIndex = 16;
            this.addWorkerBtn.Text = "Dodaj Pracownika";
            this.addWorkerBtn.UseVisualStyleBackColor = true;
            this.addWorkerBtn.Click += new System.EventHandler(this.AddWorkerBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Urlop:";
            // 
            // textBox_leave
            // 
            this.textBox_leave.Location = new System.Drawing.Point(259, 211);
            this.textBox_leave.Name = "textBox_leave";
            this.textBox_leave.Size = new System.Drawing.Size(168, 20);
            this.textBox_leave.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Wpisz dni miesiąca po przecinku";
            // 
            // addMainBtn
            // 
            this.addMainBtn.Location = new System.Drawing.Point(974, 595);
            this.addMainBtn.Name = "addMainBtn";
            this.addMainBtn.Size = new System.Drawing.Size(119, 23);
            this.addMainBtn.TabIndex = 27;
            this.addMainBtn.Text = "Dodaj Harmonogram";
            this.addMainBtn.UseVisualStyleBackColor = true;
            this.addMainBtn.Click += new System.EventHandler(this.AddMainBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dodaj Zasoby oraz dni urlopu(opcjonalnie)\r\ndla zaznaczonego pracownika:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Id Harmormonogramu";
            // 
            // numericUpDown_Id
            // 
            this.numericUpDown_Id.Location = new System.Drawing.Point(848, 598);
            this.numericUpDown_Id.Name = "numericUpDown_Id";
            this.numericUpDown_Id.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Id.TabIndex = 31;
            // 
            // AddTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 624);
            this.Controls.Add(this.numericUpDown_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMainBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_leave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addWorkerBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_resources);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_station);
            this.Controls.Add(this.listView_TimeTable);
            this.Controls.Add(this.listBox_workers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTimeTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utwórz Harmonogram";
            this.Load += new System.EventHandler(this.AddTimeTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_workers;
        private System.Windows.Forms.ListView listView_TimeTable;
        private System.Windows.Forms.ComboBox comboBox_station;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_resources;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addWorkerBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_leave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addMainBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Id;
    }
}