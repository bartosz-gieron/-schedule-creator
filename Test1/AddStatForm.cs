using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Test1
{
    public partial class AddStatForm : Form
    {
        private bool IsForEditing = false;
        private string Id;
        public AddStatForm(string statName = "",string statDescr = "",int nbWorkers = 0, string Id = "0")
        {
            InitializeComponent();
            textBox_stat_name.Text = statName;
            textBox_stat_descr.Text = statDescr;
            numericUpDown_nb_workers.Value = nbWorkers;
            if(Id !="0")
            {
                addStationButton.Text = "Edytuj";
                IsForEditing = true;
                this.Id = Id;
                this.Text = "Edytuj Stanowisko";
            }
        }


        private void AddStationButton_Click(object sender, EventArgs e)
        {
            if (textBox_stat_descr.Text == "" ||
                textBox_stat_name.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else
            {
                string[] values = new string[] { textBox_stat_name.Text, textBox_stat_descr.Text, numericUpDown_nb_workers.Value.ToString() };
                FormIntoDatabase form;
                if (IsForEditing) form = new FormIntoDatabase("UPDATE Stanowiska SET nazwa_stanowiska = $, opis_stanowiska = $, liczba_pracownikow = $ WHERE Id = " + Id, values);
                else form = new FormIntoDatabase("INSERT INTO Stanowiska(nazwa_stanowiska,opis_stanowiska,liczba_pracownikow) VALUES($,$,$)", values);
                form.Qery();

                this.Close();
            }
            
        }

    }
}
