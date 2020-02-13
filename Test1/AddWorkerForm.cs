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
    public partial class AddWorkerForm : Form
    {
        private string Id;
        private bool IsForEditing = false;
        public AddWorkerForm(string Id="0", string name = "", string surname = "", string pesel = "", string street = "", string code = "", string city = "", string phone = "", string email = "", string stat = "")
        {
            InitializeComponent();
            textBox_name.Text = name;
            textBox_surname.Text = surname;
            textBox_Pesel.Text = pesel;
            textBox_street.Text = street;
            textBox_Code.Text = code;
            textBox_city.Text = city;
            textBox_Phone.Text = phone;
            textBox_email.Text = email;
            textBox_stat.Text = stat;
            if (Id != "0")
            {
                add_employer_btn.Text = "Edytuj";
                IsForEditing = true;
                this.Id = Id;
                this.Text = "Edytuj Pracownika";
            }
        }

        private void TextBoxPesel_TextChanged(object sender, EventArgs e)
        {
            OnlyDigits(textBox_Pesel);
        }

        private void OnlyDigits(TextBox textBox)
        {
            if (!Int64.TryParse(textBox.Text, out _) && textBox.Text.Length != 0)
            { 
                if (textBox.Text.Length != 0) textBox.Text = textBox.Text.Remove(textBox.Text.Length-1);         
            }
            textBox.Text = textBox.Text.Trim();
            textBox.Focus();
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void TextBoxCode_TextChanged(object sender, EventArgs e)
        {

            if (textBox_Code.Text.Length > 0)
            {
                char[] tab = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
                int i = 0;
                foreach(char v in tab)
                {
                    if (textBox_Code.Text.Last() == v) i++;
                }
                if (i == 0)
                {
                    if (textBox_Code.Text.Length != 0) textBox_Code.Text = textBox_Code.Text.Remove(textBox_Code.Text.Length - 1);
                    textBox_Code.Text = textBox_Code.Text.Trim();
                    textBox_Code.Focus();
                    textBox_Code.SelectionStart = textBox_Code.Text.Length;
                }
            }
        }

        

        private void TextBoxPhone_TextChanged_2(object sender, EventArgs e)
        {
            if (textBox_Phone.Text.Length != 0)
            {
                if (textBox_Phone.Text.First() == '+')
                {
                    string number = "";
                    if (textBox_Phone.Text.Length > 1)
                    {
                        for (int i = 1; i < textBox_Phone.Text.Length; i++)
                        {
                            number += textBox_Phone.Text[i];
                        }
                        if (!Int64.TryParse(number, out _))
                        {
                            textBox_Phone.Text = textBox_Phone.Text.Remove(textBox_Phone.Text.Length - 1);
                        }
                        textBox_Phone.Text = textBox_Phone.Text.Trim();
                        textBox_Phone.Focus();
                        textBox_Phone.SelectionStart = textBox_Phone.Text.Length;
                    }

                }
                else OnlyDigits(textBox_Phone);
            }
        }

        private void AddWorkerBtn_CLick(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" ||
                textBox_surname.Text == "" ||
                textBox_Pesel.Text == "" ||
                textBox_street.Text == "" ||
                textBox_Code.Text == "" ||
                textBox_city.Text == "" ||
                textBox_Phone.Text == "" ||
                textBox_email.Text == "" ||
                textBox_stat.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else
            {
                string[] values = new string[]
                {
                textBox_name.Text,
                textBox_surname.Text,
                textBox_Pesel.Text,
                textBox_street.Text,
                textBox_Code.Text,
                textBox_city.Text,
                textBox_Phone.Text,
                textBox_email.Text,
                textBox_stat.Text
                };

                FormIntoDatabase form;

                if (IsForEditing) form = new FormIntoDatabase("UPDATE Pracownicy SET Imie = $, Nazwisko = $, Pesel = $, Ulica = $, KodPocztowy = $, Miejscowosc = $,Telefon = $, Email = $," +
                                                              "Stanowisko = $ WHERE Id = " + Id, values);
                else form = new FormIntoDatabase("INSERT INTO Pracownicy VALUES($, $, $, $, $, $, $, $, $) ", values);
                form.Qery();

                this.Close();
            }
        }
    }
}
