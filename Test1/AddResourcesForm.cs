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
    public partial class AddResourcesForm : Form
    {
        private bool IsForEditing = false;
        private string Id;
        public AddResourcesForm(string name = "", string descr = "", int count = 0, string Id = "0")
        {
            InitializeComponent();
            textBoxResName.Text = name;
            textBoxResDescr.Text = descr;
            numericUpDownResources.Value = count;
            if (Id != "0")
            {
                addResourceBtn.Text = "Edytuj";
                IsForEditing = true;
                this.Id = Id;
                this.Text = "Edytuj Zasób";
            }
        }

        private void AddResourceBtnClick(object sender, EventArgs e)
        {
            if (textBoxResName.Text == "" ||
                textBoxResDescr.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie pola");
            }
            else
            {
                string[] values = new string[] { textBoxResName.Text, textBoxResDescr.Text, numericUpDownResources.Value.ToString() };
                FormIntoDatabase form;
                if (IsForEditing) form = new FormIntoDatabase("UPDATE Zasoby SET nazwa = $, opis = $, ilosc = $ WHERE Id = " + Id, values);
                else form = new FormIntoDatabase("INSERT INTO Zasoby VALUES($,$,$)", values);
                form.Qery();

                this.Close();
            }
        }
    }
}
