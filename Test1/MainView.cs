using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class MainView : Form
    {
        private List<string> stations;
        private List<string> workers;
        private List<string> pesels;
        private List<string> tables;
        private List<string> resources;
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            listbox_station.Items.Clear();
            listBox_workers.Items.Clear();
            listBox_resources.Items.Clear();
            listbox_harm.Items.Clear();

            station_descr.Text = "Wybierz stanowisko";
            workers_descr.Text = "Wybierz Pracownika";
            resources_descr.Text = "Wybierz Zasób";
            listView_Harm.Items.Clear();

            stations = new List<string>();
            resources = new List<string>();
            workers = new List<string>();
            pesels = new List<string>();
            tables = new List<string>();

            DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Stanowiska");
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                stations.Add(dataRow["nazwa_stanowiska"].ToString());
                listbox_station.Items.Add(stations.Last());
            }
            dataset.Clear();

            dataset = DataBaseHelper.FillDataset("SELECT * from Pracownicy");
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                workers.Add(dataRow["Imie"].ToString() + " " + dataRow["Nazwisko"].ToString());
                pesels.Add(dataRow["pesel"].ToString());
                listBox_workers.Items.Add(workers.Last());
            }

            dataset.Clear();
            dataset = DataBaseHelper.FillDataset("SELECT * from Zasoby");
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                resources.Add(dataRow["nazwa"].ToString());
                listBox_resources.Items.Add(resources.Last());
            }

            dataset.Clear();
            dataset = DataBaseHelper.FillDataset("SELECT * from Harmonogramy");
            foreach(var s in dataset.Tables[0].Columns)
            {
                if (s.ToString() != "Id")
                {
                    tables.Add(s.ToString());
                    listbox_harm.Items.Add(tables.Last());
                }
            }



        }


        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddStationBtn_Click(object sender, EventArgs e)
        {
            new AddStatForm().Show();
        }

        private void AddWorkersBtn_Click(object sender, EventArgs e)
        {
            new AddWorkerForm().Show();
        }
        private void AddResourcesBtn_Click(object sender, EventArgs e)
        {
            new AddResourcesForm().Show();
        }
        private void AddTimeTableBtn_Click(object sender, EventArgs e)
        {
            new AddTimeTableForm().Show();
        }
        private void ListBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_workers.SelectedIndex != -1)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Pracownicy WHERE pesel = @pesel", "pesel", pesels.ElementAt(listBox_workers.SelectedIndex));
                workers_descr.Text = String.Format("Imię: {0}\n\r\n\r" +
                                                        "Nazwisko: {1}\n\r\n\r" +
                                                        "Pesel: {2}\n\r\n\r" +
                                                        "Ulica: {3}\n\r\n\r" +
                                                        "Kod Pocztowy: {4}\n\r\n\r" +
                                                        "Miejsowość: {5}\n\r\n\r" +
                                                        "Telefon Kontaktowy: {6}\n\r\n\r" +
                                                        "Adres email: {7}\n\r\n\r" +
                                                        "Stanowisko: {8}\n\r\n\r",
                                                        dataset.Tables[0].Rows[0]["Imie"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Nazwisko"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Pesel"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Ulica"].ToString(),
                                                        dataset.Tables[0].Rows[0]["KodPocztowy"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Miejscowosc"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Telefon"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Email"].ToString(),
                                                        dataset.Tables[0].Rows[0]["Stanowisko"].ToString());
            }
        }

        private void ListBoxStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_station.SelectedIndex != -1)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Stanowiska WHERE nazwa_stanowiska = @selected","selected", listbox_station.SelectedItem.ToString());
                station_descr.Text = String.Format("Opis Stanowiska:\n\r {0}\n\r\n\r\n\rLiczba Pracowników: {1}",
                                                      dataset.Tables[0].Rows[0]["opis_stanowiska"].ToString(), 
                                                      dataset.Tables[0].Rows[0]["liczba_pracownikow"].ToString());
            }
        }

        private void ListBoxResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_resources.SelectedIndex != -1)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Zasoby WHERE nazwa = @selected", "selected", listBox_resources.SelectedItem.ToString());
                resources_descr.Text = String.Format("Opis Zasobu:\n\r {0}\n\r\n\r\n\r Ilość: {1}",
                                                      dataset.Tables[0].Rows[0]["opis"].ToString(),
                                                      dataset.Tables[0].Rows[0]["ilosc"].ToString());
            }
        }
        private void ListboxTimetable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbox_harm.SelectedIndex != -1)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Harmonogramy");

                List<string> harmToView = new List<string>();
                List<ListViewItem> items = new List<ListViewItem>();
                string element = "";
                int columnCount = 0;
                foreach(DataRow dataRow in dataset.Tables[0].Rows)
                {
                    foreach (var c in dataRow[listbox_harm.SelectedItem.ToString()].ToString())
                    {
                        if (c == '#')
                        {
                            if(element !="" )harmToView.Add(element);
                            columnCount++;
                            element = "";
                        }
                        else
                        {
                            element += c;
                        }
                    }
                    items.Add(new ListViewItem(harmToView.ToArray()));
                    harmToView.Clear();
                }

                listView_Harm.Items.Clear();
                listView_Harm.Columns.Clear();
                listView_Harm.Columns.Add("Nazwisko", 100);
                for (int i = 0; i < items[0].SubItems.Count - 1; i++)
                {
                    listView_Harm.Columns.Add((i + 1).ToString(), 35);
                }
                listView_Harm.Items.AddRange(items.ToArray());
            }
        }

        private void DeleteWorkersBtn_Click(object sender, EventArgs e)
        {
           
            if (listBox_workers.SelectedItem != null)
            {
                int selectedIndex = listBox_workers.SelectedIndex;
                if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczonego Pracownika? Tej czynności nie można anulować",
                                   $"Usunięcie elementu: {listBox_workers.SelectedItem.ToString()}",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataBaseHelper.deleteRow("Pracownicy", "pesel", pesels.ElementAt(selectedIndex));
                }

            }
            MainView_Load(new object(), new EventArgs());
        }
        private void DeleteStationBtn_Click(object sender, EventArgs e)
        {
            
            if (listbox_station.SelectedItem != null)
            {
                string selectedItem = listbox_station.SelectedItem.ToString();
                if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone stanowisko? Tej czynności nie można anulować",
                                   $"Usunięcie elementu: {selectedItem}",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataBaseHelper.deleteRow("Stanowiska", "nazwa_stanowiska", selectedItem);
                }

            }
            MainView_Load(new object(), new EventArgs());
        }

        private void DeleteResourceBtn_Click(object sender, EventArgs e)
        {
            
            if (listBox_resources.SelectedItem != null)
            {
                string selectedItem = listBox_resources.SelectedItem.ToString();
                if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony zasób? Tej czynności nie można anulować",
                                   $"Usunięcie elementu: {selectedItem}",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataBaseHelper.deleteRow("Zasoby", "nazwa", selectedItem);
                }

            }
            MainView_Load(new object(), new EventArgs());
        }

        private void DeleteTimeTableBtn_Click(object sender, EventArgs e)
        {
            
            if (listbox_harm.SelectedItem != null)
            {
               string selectedItem = listbox_harm.SelectedItem.ToString();
                if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony Harmonogram? Tej czynności nie można anulować",
                                   $"Usunięcie elementu: {selectedItem}",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(DataBaseHelper.ConnectionString()))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand("ALTER TABLE Harmonogramy DROP COLUMN [" + selectedItem + "]", connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            connection.Close();
                        }
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                    }
                }

            }
            MainView_Load(new object(), new EventArgs());
        }
        private void EditStationBtn_Click(object sender, EventArgs e)
        {
            if (listbox_station.SelectedItem != null)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Stanowiska WHERE nazwa_stanowiska = @selected", "selected", listbox_station.SelectedItem.ToString());
                new AddStatForm(dataset.Tables[0].Rows[0]["nazwa_stanowiska"].ToString(),
                          dataset.Tables[0].Rows[0]["opis_stanowiska"].ToString(),
                          Int32.Parse(dataset.Tables[0].Rows[0]["liczba_pracownikow"].ToString()),
                          dataset.Tables[0].Rows[0]["Id"].ToString()).Show();
            }         
        }

        private void EditWorkerBtn_Click(object sender, EventArgs e)
        {
            if (listBox_workers.SelectedItem != null)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Pracownicy WHERE pesel = @pesel", "pesel", pesels.ElementAt(listBox_workers.SelectedIndex));
                new AddWorkerForm(dataset.Tables[0].Rows[0]["Id"].ToString(),
                          dataset.Tables[0].Rows[0]["Imie"].ToString(),
                          dataset.Tables[0].Rows[0]["Nazwisko"].ToString(),
                          dataset.Tables[0].Rows[0]["Pesel"].ToString(),
                          dataset.Tables[0].Rows[0]["Ulica"].ToString(),
                          dataset.Tables[0].Rows[0]["KodPocztowy"].ToString(),
                          dataset.Tables[0].Rows[0]["Miejscowosc"].ToString(),
                          dataset.Tables[0].Rows[0]["Telefon"].ToString(),
                          dataset.Tables[0].Rows[0]["Email"].ToString(),
                          dataset.Tables[0].Rows[0]["Stanowisko"].ToString()).Show();
            }
        }

        private void EditResourceBtn_Click(object sender, EventArgs e)
        {
            if (listBox_resources.SelectedItem != null)
            {
                DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Zasoby WHERE nazwa = @selected", "selected", listBox_resources.SelectedItem.ToString());
                new AddResourcesForm(dataset.Tables[0].Rows[0]["nazwa"].ToString(),
                          dataset.Tables[0].Rows[0]["opis"].ToString(),
                          Int32.Parse(dataset.Tables[0].Rows[0]["ilosc"].ToString()),
                          dataset.Tables[0].Rows[0]["Id"].ToString()).Show();
            }
        }

    }
}
