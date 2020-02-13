using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class AddTimeTableForm : Form
    {
        private List<string> workers;
        private List<string> pesels;
        private List<string> stations;
        private List<string> resources;
        private List<int> resourcesCount;
        private List<int> sundays;
        private List<int> saturdays;
        private int year;
        private int month;
        private int days;
        private string[,] shiftsTable;
        private int workersNeeded;
        private int workersNeededCount;
        public AddTimeTableForm()
        {
            InitializeComponent();
            sundays = new List<int>();
            saturdays = new List<int>();
        }

        private void AddTimeTableForm_Load(object sender, EventArgs e)
        {
            listBox_workers.Items.Clear();
            listView_TimeTable.Items.Clear();

            workers = new List<string>();
            pesels = new List<string>();
            stations = new List<string>();
            resources = new List<string>();
            resourcesCount = new List<int>();
            

            DataSet dataset = DataBaseHelper.FillDataset("SELECT * from Pracownicy");
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                workers.Add(dataRow["Imie"].ToString() + " " + dataRow["Nazwisko"].ToString());
                pesels.Add(dataRow["pesel"].ToString());
                listBox_workers.Items.Add(workers.Last());
            }
            dataset = DataBaseHelper.FillDataset("SELECT * from Stanowiska");
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                stations.Add(dataRow["nazwa_stanowiska"].ToString());
                comboBox_station.Items.Add(stations.Last());
            }
            dataset = DataBaseHelper.FillDataset("SELECT * from Zasoby");
            foreach (DataRow dataRow in dataset.Tables[0].Rows)
            {
                resources.Add(dataRow["nazwa"].ToString());
                resourcesCount.Add(int.Parse(dataRow["Ilosc"].ToString()));
                comboBox_resources.Items.Add(resources.Last());
            }
            dataset.Clear();

            comboBox_resources.Enabled = false;
            textBox_leave.Enabled = false;
            addWorkerBtn.Enabled = false;
            comboBox_station.Enabled = false;
        }

        private void AddWorkerBtn_Click(object sender, EventArgs e)
        {
            bool stop = false;
            string leaveDay = "";
            List<string> leaveDaysList = new List<string>();

            if (listBox_workers.SelectedIndex != -1)
            {
                if (comboBox_resources.SelectedIndex != -1)
                {
                    resourcesCount[comboBox_resources.SelectedIndex]--;
                    if (resourcesCount[comboBox_resources.SelectedIndex] < 0)
                    {
                        MessageBox.Show("Niewystarczająca ilość zasobu: " + comboBox_resources.SelectedItem.ToString());
                        stop = true;
                    }
                }
                if(textBox_leave != null)
                {
                    textBox_leave.Text += ",";
                    foreach(var x in textBox_leave.Text)
                    {
                        if (x == ',')
                        {
                            leaveDaysList.Add(leaveDay);
                            leaveDay = "";
                        }
                        else leaveDay += x;
                    }
                }
                if (workersNeededCount > 0 && !stop)
                {
                    List<string> daysTable = CreateWorkingMonth(workersNeeded, shiftsTable, listBox_workers.SelectedItem.ToString(), leaveDaysList);
                    workersNeededCount--;
                    var item = new ListViewItem(daysTable.ToArray());
                    listView_TimeTable.Items.Add(item);
                    listBox_workers.Items.RemoveAt(listBox_workers.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("To stanowisko nie potrzebuje wiekszej liczby pracowników.");
                }
                textBox_leave.Text = "";
                comboBox_resources.ResetText();
                comboBox_station.Enabled = false;
                comboBox_month.Enabled = false;
                comboBox_year.Enabled = false;
            }
        }

        private void ComboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_month.SelectedIndex != -1 && comboBox_year.SelectedIndex != -1)
            {
                listView_TimeTable.Columns.Add("Nazwisko", 80);
                year = int.Parse(comboBox_year.SelectedItem.ToString());
                month = comboBox_month.SelectedIndex + 1;
                days = DateTime.DaysInMonth(year, month);
                for (int i = 1; i <= days; i++)
                {
                    listView_TimeTable.Columns.Add(i.ToString(), 30);
                }
                sundays = FindDayOfWeek(year, month, days, DayOfWeek.Sunday);
                saturdays = FindDayOfWeek(year, month, days, DayOfWeek.Saturday);
                comboBox_station.Enabled = true;
            }
        }
        private void ComboBox_station_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_month.SelectedIndex != -1 && comboBox_year.SelectedIndex != -1 && comboBox_station.SelectedIndex != -1)
            {
                listView_TimeTable.Items.Clear();

                DataSet dataSet = DataBaseHelper.FillDataset("SELECT liczba_pracownikow from Stanowiska WHERE nazwa_stanowiska = @nazwa", "nazwa", comboBox_station.SelectedItem.ToString());
                workersNeeded = 3 * (int.Parse(dataSet.Tables[0].Rows[0]["liczba_pracownikow"].ToString()));

                shiftsTable = CreateShifts(workersNeeded);

                workersNeededCount = workersNeeded;
                comboBox_resources.Enabled = true;
                textBox_leave.Enabled = true;
                addWorkerBtn.Enabled = true;
            }
        }
        private List<int> FindDayOfWeek(int year, int month, int days, DayOfWeek dayOfWeek)
        {
            List<int> myDay = new List<int>();
            for (int i = 1; i <= days; i++)
            {
                DateTime dateTime = new DateTime(year, month, i);
                if (dateTime.DayOfWeek == dayOfWeek)
                    myDay.Add(i);
            }
            return myDay;
        }
        private List<string> CreateWorkingMonth(int workersNeeded, string[,] shiftsTable, string name, List<string> leaveDays)
        {
            string[] daysTable = new string[days + 1];
            foreach (var s in sundays)
            {
                daysTable[s - 1] = "Nd";
            }
            foreach (var s in saturdays)
            {
                daysTable[s - 1] = "Sb";
            }

            int x = 0;
            Random random = new Random();
            int rndNum;

            do
            {
                 rndNum = random.Next(0, workersNeeded);
            } while (shiftsTable[rndNum,x] == null);
            for (int i = 0; i < days; i++)
            {
                if (daysTable[i] == null)
                {
                    daysTable[i] = shiftsTable[rndNum, x];
                    shiftsTable[rndNum, x] = null;
                    x++;
                }
                if (daysTable[i] == "Nd")
                {
                    int rest = x % 5;
                    if (rest == 0) continue;
                    for (int j = x; j < (x - rest + 5); j++)
                    {
                        shiftsTable[rndNum, j] = null;
                    }
                    x += (5 - rest);
                }
                if (x >= 26) break;
            }

            List<string> finalDays = new List<string>();
            finalDays.Add(name);
            finalDays.AddRange(daysTable);
            foreach(var s in leaveDays)
            {
                if (s == "") break;
                finalDays[int.Parse(s)] = "U";
            }
            return finalDays;
        }

        private static string[,] CreateShifts(int workersNeeded)
        {
            string[] shiftSymbols = new string[workersNeeded * 25];
            for (int i = 0; i < shiftSymbols.Length; i += 15)
            {
                if (i + 1 == shiftSymbols.Length) break;
                for (int j = 0; j < 5; j++)
                {
                    shiftSymbols[i + j] = "R";
                }
                if (i + 1 == shiftSymbols.Length) break;
                for (int j = 5; j < 10; j++)
                {
                    shiftSymbols[i + j] = "P";
                }
                if (i + 1 == shiftSymbols.Length) break;
                for (int j = 10; j < 15; j++)
                {
                    shiftSymbols[i + j] = "N";
                }
            }
            string[,] shiftsTable = new string[workersNeeded, 25];
            for (int i = 0; i < workersNeeded; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    shiftsTable[i, j] = shiftSymbols[j + (25 * i)];
                }
            }

            return shiftsTable;
        }

        private void AddMainBtn_Click(object sender, EventArgs e)
        {
            if (comboBox_year.SelectedIndex == -1 || comboBox_month.SelectedIndex == -1 || comboBox_station.SelectedIndex == -1 || listView_TimeTable.Items.Count == 0)
            {
                MessageBox.Show("Nie wypełniłeś wszystkich pól");
            }
            else
            {
                string harmName;

                if (numericUpDown_Id.Value == 0)
                {
                    harmName = numericUpDown_Id.Value + "_" + comboBox_year.SelectedItem.ToString() + "_" + comboBox_month.SelectedItem.ToString();
                }
                else
                {
                    harmName = new Random().Next(0, 9999999).ToString() + "_" + comboBox_year.SelectedItem.ToString() + "_" + comboBox_month.SelectedItem.ToString();
                }

                FormIntoDatabase form = new FormIntoDatabase("ALTER TABLE Harmonogramy ADD ["+harmName+"] VARCHAR(MAX) ", new string[] { harmName});
                form.Qery();

                for (int i = 0; i < listView_TimeTable.Items.Count; i++)
                {
                    string row = "";
                    for (int j = 0; j < listView_TimeTable.Items[i].SubItems.Count; j++)
                    {
                        row += listView_TimeTable.Items[i].SubItems[j].Text + "#";
                    }
                    form = new FormIntoDatabase("UPDATE Harmonogramy SET [" + harmName + "]=$ WHERE Id = $", new string[] { row, (i+1).ToString() });
                    form.Qery();
                }

                listView_TimeTable.Items.Clear();
                listView_TimeTable.Columns.Clear();

                this.Close();
            }
        }
    }
}
