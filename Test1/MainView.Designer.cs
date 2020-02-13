namespace Test1
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.database1DataSet = new Test1.Database1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Test1.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage_res = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.resources_descr = new System.Windows.Forms.TextBox();
            this.AddResourcesBtn = new System.Windows.Forms.Button();
            this.EditResourceBtn = new System.Windows.Forms.Button();
            this.DeleteResourceBtn = new System.Windows.Forms.Button();
            this.listBox_resources = new System.Windows.Forms.ListBox();
            this.tabPage_workers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.workers_descr = new System.Windows.Forms.TextBox();
            this.AddBtn_pracownicy = new System.Windows.Forms.Button();
            this.EditBtn_pracownicy = new System.Windows.Forms.Button();
            this.DelBtn_pracownicy = new System.Windows.Forms.Button();
            this.listBox_workers = new System.Windows.Forms.ListBox();
            this.tabPage_stat = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listbox_station = new System.Windows.Forms.ListBox();
            this.station_descr = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.Edytuj = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.tabPage_harm = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listbox_harm = new System.Windows.Forms.ListBox();
            this.addTimeTableBtn = new System.Windows.Forms.Button();
            this.deleteTimeTableBtn = new System.Windows.Forms.Button();
            this.listView_Harm = new System.Windows.Forms.ListView();
            this.main_control = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.tabPage_res.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage_workers.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage_stat.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage_harm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.main_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.database1DataSet;
            // 
            // tabPage_res
            // 
            this.tabPage_res.Controls.Add(this.tableLayoutPanel4);
            this.tabPage_res.Location = new System.Drawing.Point(4, 22);
            this.tabPage_res.Name = "tabPage_res";
            this.tabPage_res.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_res.Size = new System.Drawing.Size(852, 511);
            this.tabPage_res.TabIndex = 3;
            this.tabPage_res.Text = "Zasoby";
            this.tabPage_res.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.resources_descr, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddResourcesBtn, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.EditResourceBtn, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.DeleteResourceBtn, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.listBox_resources, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(852, 511);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // resources_descr
            // 
            this.resources_descr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.resources_descr, 4);
            this.resources_descr.Location = new System.Drawing.Point(173, 3);
            this.resources_descr.Multiline = true;
            this.resources_descr.Name = "resources_descr";
            this.resources_descr.ReadOnly = true;
            this.resources_descr.Size = new System.Drawing.Size(676, 453);
            this.resources_descr.TabIndex = 2;
            this.resources_descr.Text = "Wybierz Stanowisko";
            // 
            // AddResourcesBtn
            // 
            this.AddResourcesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddResourcesBtn.Location = new System.Drawing.Point(599, 462);
            this.AddResourcesBtn.Name = "AddResourcesBtn";
            this.AddResourcesBtn.Size = new System.Drawing.Size(79, 46);
            this.AddResourcesBtn.TabIndex = 3;
            this.AddResourcesBtn.Text = "Dodaj";
            this.AddResourcesBtn.UseVisualStyleBackColor = true;
            this.AddResourcesBtn.Click += new System.EventHandler(this.AddResourcesBtn_Click);
            // 
            // EditResourceBtn
            // 
            this.EditResourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditResourceBtn.Location = new System.Drawing.Point(684, 462);
            this.EditResourceBtn.Name = "EditResourceBtn";
            this.EditResourceBtn.Size = new System.Drawing.Size(79, 46);
            this.EditResourceBtn.TabIndex = 4;
            this.EditResourceBtn.Text = "Edytuj";
            this.EditResourceBtn.UseVisualStyleBackColor = true;
            this.EditResourceBtn.Click += new System.EventHandler(this.EditResourceBtn_Click);
            // 
            // DeleteResourceBtn
            // 
            this.DeleteResourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteResourceBtn.Location = new System.Drawing.Point(769, 462);
            this.DeleteResourceBtn.Name = "DeleteResourceBtn";
            this.DeleteResourceBtn.Size = new System.Drawing.Size(80, 46);
            this.DeleteResourceBtn.TabIndex = 5;
            this.DeleteResourceBtn.Text = "Usuń";
            this.DeleteResourceBtn.UseVisualStyleBackColor = true;
            this.DeleteResourceBtn.Click += new System.EventHandler(this.DeleteResourceBtn_Click);
            // 
            // listBox_resources
            // 
            this.listBox_resources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_resources.FormattingEnabled = true;
            this.listBox_resources.Location = new System.Drawing.Point(3, 3);
            this.listBox_resources.Name = "listBox_resources";
            this.tableLayoutPanel4.SetRowSpan(this.listBox_resources, 2);
            this.listBox_resources.Size = new System.Drawing.Size(164, 498);
            this.listBox_resources.TabIndex = 1;
            this.listBox_resources.SelectedIndexChanged += new System.EventHandler(this.ListBoxResources_SelectedIndexChanged);
            // 
            // tabPage_workers
            // 
            this.tabPage_workers.Controls.Add(this.tableLayoutPanel3);
            this.tabPage_workers.Location = new System.Drawing.Point(4, 22);
            this.tabPage_workers.Name = "tabPage_workers";
            this.tabPage_workers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_workers.Size = new System.Drawing.Size(852, 511);
            this.tabPage_workers.TabIndex = 2;
            this.tabPage_workers.Text = "Pracownicy";
            this.tabPage_workers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.workers_descr, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.AddBtn_pracownicy, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.EditBtn_pracownicy, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.DelBtn_pracownicy, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.listBox_workers, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(852, 511);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // workers_descr
            // 
            this.workers_descr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.workers_descr, 4);
            this.workers_descr.Location = new System.Drawing.Point(173, 3);
            this.workers_descr.Multiline = true;
            this.workers_descr.Name = "workers_descr";
            this.workers_descr.ReadOnly = true;
            this.workers_descr.Size = new System.Drawing.Size(676, 453);
            this.workers_descr.TabIndex = 2;
            this.workers_descr.Text = "Wybierz Stanowisko";
            // 
            // AddBtn_pracownicy
            // 
            this.AddBtn_pracownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn_pracownicy.Location = new System.Drawing.Point(599, 462);
            this.AddBtn_pracownicy.Name = "AddBtn_pracownicy";
            this.AddBtn_pracownicy.Size = new System.Drawing.Size(79, 46);
            this.AddBtn_pracownicy.TabIndex = 3;
            this.AddBtn_pracownicy.Text = "Dodaj";
            this.AddBtn_pracownicy.UseVisualStyleBackColor = true;
            this.AddBtn_pracownicy.Click += new System.EventHandler(this.AddWorkersBtn_Click);
            // 
            // EditBtn_pracownicy
            // 
            this.EditBtn_pracownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn_pracownicy.Location = new System.Drawing.Point(684, 462);
            this.EditBtn_pracownicy.Name = "EditBtn_pracownicy";
            this.EditBtn_pracownicy.Size = new System.Drawing.Size(79, 46);
            this.EditBtn_pracownicy.TabIndex = 4;
            this.EditBtn_pracownicy.Text = "Edytuj";
            this.EditBtn_pracownicy.UseVisualStyleBackColor = true;
            this.EditBtn_pracownicy.Click += new System.EventHandler(this.EditWorkerBtn_Click);
            // 
            // DelBtn_pracownicy
            // 
            this.DelBtn_pracownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelBtn_pracownicy.Location = new System.Drawing.Point(769, 462);
            this.DelBtn_pracownicy.Name = "DelBtn_pracownicy";
            this.DelBtn_pracownicy.Size = new System.Drawing.Size(80, 46);
            this.DelBtn_pracownicy.TabIndex = 5;
            this.DelBtn_pracownicy.Text = "Usuń";
            this.DelBtn_pracownicy.UseVisualStyleBackColor = true;
            this.DelBtn_pracownicy.Click += new System.EventHandler(this.DeleteWorkersBtn_Click);
            // 
            // listBox_workers
            // 
            this.listBox_workers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_workers.FormattingEnabled = true;
            this.listBox_workers.Location = new System.Drawing.Point(3, 3);
            this.listBox_workers.Name = "listBox_workers";
            this.tableLayoutPanel3.SetRowSpan(this.listBox_workers, 2);
            this.listBox_workers.Size = new System.Drawing.Size(164, 498);
            this.listBox_workers.TabIndex = 1;
            this.listBox_workers.SelectedIndexChanged += new System.EventHandler(this.ListBoxWorkers_SelectedIndexChanged);
            // 
            // tabPage_stat
            // 
            this.tabPage_stat.Controls.Add(this.tableLayoutPanel2);
            this.tabPage_stat.Location = new System.Drawing.Point(4, 22);
            this.tabPage_stat.Name = "tabPage_stat";
            this.tabPage_stat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_stat.Size = new System.Drawing.Size(852, 511);
            this.tabPage_stat.TabIndex = 1;
            this.tabPage_stat.Text = "Stanowiska";
            this.tabPage_stat.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.listbox_station, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.station_descr, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Edytuj, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Deletebtn, 4, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(852, 511);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // listbox_station
            // 
            this.listbox_station.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_station.FormattingEnabled = true;
            this.listbox_station.Location = new System.Drawing.Point(3, 3);
            this.listbox_station.Name = "listbox_station";
            this.tableLayoutPanel2.SetRowSpan(this.listbox_station, 2);
            this.listbox_station.Size = new System.Drawing.Size(164, 498);
            this.listbox_station.TabIndex = 1;
            this.listbox_station.SelectedIndexChanged += new System.EventHandler(this.ListBoxStation_SelectedIndexChanged);
            // 
            // station_descr
            // 
            this.station_descr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.station_descr, 4);
            this.station_descr.Location = new System.Drawing.Point(173, 3);
            this.station_descr.Multiline = true;
            this.station_descr.Name = "station_descr";
            this.station_descr.ReadOnly = true;
            this.station_descr.Size = new System.Drawing.Size(676, 453);
            this.station_descr.TabIndex = 2;
            this.station_descr.Text = "Wybierz Stanowisko";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(599, 462);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(79, 46);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Dodaj";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddStationBtn_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Edytuj.Location = new System.Drawing.Point(684, 462);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(79, 46);
            this.Edytuj.TabIndex = 4;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.EditStationBtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Deletebtn.Location = new System.Drawing.Point(769, 462);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(80, 46);
            this.Deletebtn.TabIndex = 5;
            this.Deletebtn.Text = "Usuń";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.DeleteStationBtn_Click);
            // 
            // tabPage_harm
            // 
            this.tabPage_harm.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_harm.Location = new System.Drawing.Point(4, 22);
            this.tabPage_harm.Name = "tabPage_harm";
            this.tabPage_harm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_harm.Size = new System.Drawing.Size(852, 511);
            this.tabPage_harm.TabIndex = 0;
            this.tabPage_harm.Text = "Harmonogramy";
            this.tabPage_harm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.listbox_harm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addTimeTableBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteTimeTableBtn, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView_Harm, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listbox_harm
            // 
            this.listbox_harm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_harm.FormattingEnabled = true;
            this.listbox_harm.Location = new System.Drawing.Point(3, 3);
            this.listbox_harm.Name = "listbox_harm";
            this.tableLayoutPanel1.SetRowSpan(this.listbox_harm, 2);
            this.listbox_harm.Size = new System.Drawing.Size(164, 498);
            this.listbox_harm.TabIndex = 0;
            this.listbox_harm.SelectedIndexChanged += new System.EventHandler(this.ListboxTimetable_SelectedIndexChanged);
            // 
            // addTimeTableBtn
            // 
            this.addTimeTableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTimeTableBtn.Location = new System.Drawing.Point(684, 462);
            this.addTimeTableBtn.Name = "addTimeTableBtn";
            this.addTimeTableBtn.Size = new System.Drawing.Size(79, 46);
            this.addTimeTableBtn.TabIndex = 3;
            this.addTimeTableBtn.Text = "Dodaj";
            this.addTimeTableBtn.UseVisualStyleBackColor = true;
            this.addTimeTableBtn.Click += new System.EventHandler(this.AddTimeTableBtn_Click);
            // 
            // deleteTimeTableBtn
            // 
            this.deleteTimeTableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTimeTableBtn.Location = new System.Drawing.Point(769, 462);
            this.deleteTimeTableBtn.Name = "deleteTimeTableBtn";
            this.deleteTimeTableBtn.Size = new System.Drawing.Size(80, 46);
            this.deleteTimeTableBtn.TabIndex = 4;
            this.deleteTimeTableBtn.Text = "Usuń";
            this.deleteTimeTableBtn.UseVisualStyleBackColor = true;
            this.deleteTimeTableBtn.Click += new System.EventHandler(this.DeleteTimeTableBtn_Click);
            // 
            // listView_Harm
            // 
            this.listView_Harm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.listView_Harm, 4);
            this.listView_Harm.FullRowSelect = true;
            this.listView_Harm.GridLines = true;
            this.listView_Harm.HideSelection = false;
            this.listView_Harm.Location = new System.Drawing.Point(173, 3);
            this.listView_Harm.Name = "listView_Harm";
            this.listView_Harm.Size = new System.Drawing.Size(676, 453);
            this.listView_Harm.TabIndex = 5;
            this.listView_Harm.UseCompatibleStateImageBehavior = false;
            this.listView_Harm.View = System.Windows.Forms.View.Details;
            // 
            // main_control
            // 
            this.main_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_control.Controls.Add(this.tabPage_harm);
            this.main_control.Controls.Add(this.tabPage_stat);
            this.main_control.Controls.Add(this.tabPage_workers);
            this.main_control.Controls.Add(this.tabPage_res);
            this.main_control.Location = new System.Drawing.Point(12, 12);
            this.main_control.Name = "main_control";
            this.main_control.SelectedIndex = 0;
            this.main_control.Size = new System.Drawing.Size(860, 537);
            this.main_control.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.main_control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja";
            this.Activated += new System.EventHandler(this.MainView_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.tabPage_res.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage_workers.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage_stat.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage_harm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.main_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.TabPage tabPage_res;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox resources_descr;
        private System.Windows.Forms.Button AddResourcesBtn;
        private System.Windows.Forms.Button EditResourceBtn;
        private System.Windows.Forms.Button DeleteResourceBtn;
        private System.Windows.Forms.ListBox listBox_resources;
        private System.Windows.Forms.TabPage tabPage_workers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox workers_descr;
        private System.Windows.Forms.Button AddBtn_pracownicy;
        private System.Windows.Forms.Button EditBtn_pracownicy;
        private System.Windows.Forms.Button DelBtn_pracownicy;
        private System.Windows.Forms.ListBox listBox_workers;
        private System.Windows.Forms.TabPage tabPage_stat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listbox_station;
        private System.Windows.Forms.TextBox station_descr;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TabPage tabPage_harm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listbox_harm;
        private System.Windows.Forms.Button addTimeTableBtn;
        private System.Windows.Forms.Button deleteTimeTableBtn;
        private System.Windows.Forms.ListView listView_Harm;
        private System.Windows.Forms.TabControl main_control;
    }
}