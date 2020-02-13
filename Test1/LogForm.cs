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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LoginBtnClick(object sender, EventArgs e)
        {
            infoLabel.Text = "";
            if (loginField.Text == "")  infoLabel.Text = "Wprowadz login";
            else if (passField.Text == "") infoLabel.Text = "Wprowadz hasło";
            else{
                infoLabel.Text = "Łączenie z bazą danych";
                using (SqlConnection connection = new SqlConnection(DataBaseHelper.ConnectionString()))
                {
                    try
                    {
                     
                        SqlDataAdapter adapter = new SqlDataAdapter();

                        adapter.TableMappings.Add("Table", "DaneLogowania");
                        connection.Open();

                        SqlCommand command= new SqlCommand("SELECT COUNT(*) FROM DaneLogowania" +
                                                           " WHERE username = @login AND password = @pass");
                        command.Parameters.AddWithValue("@login", loginField.Text);
                        command.Parameters.AddWithValue("@pass", passField.Text);
                        command.CommandType = CommandType.Text;
                        command.Connection = connection;
                        adapter.SelectCommand = command;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        connection.Close();
                        infoLabel.Text = "Połączenie zakończone";
                        if (dataTable.Rows[0][0].ToString() == "1")
                        {
                            infoLabel.Text = "Poprawny login i hasło";
                            new MainView().Show();
                            this.Hide();
                        }
                        else infoLabel.Text = "Niepoprawny login i/lub hasło";
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                    }
                }
            }
        }
    }
}
