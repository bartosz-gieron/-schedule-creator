using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    class FormIntoDatabase
    {
        public string sqlQuery;
        public List<string> valuesNames;
        public string[] values;
        /// <summary>
        /// This class provides simply way to insert data into databas
        /// </summary>
        /// <param name="sqlQuery">Your query, use $ in every place of yours values</param>
        /// <param name="values">yours values</param>
        public FormIntoDatabase(string sqlQuery, string[] values)
        {
            this.sqlQuery = sqlQuery;
            this.values = values;
            CreateValuesNames();
            InsertNamesIntoQuery();
        }
        /// <summary>
        /// Creates temporary names to insert them into query (@1,@2,...)
        /// </summary>
        private void CreateValuesNames()
        {
            valuesNames = new List<string>();
            int i = 1;
            foreach (string v in values)
            {
                valuesNames.Add("@" + i.ToString());
                i++;
            }
        }
        /// <summary>
        /// Inserts created names into Database Query instead of $ symbol
        /// </summary>
        private void InsertNamesIntoQuery()
        {
            int index;
            foreach(string s in valuesNames)
            {
                index = sqlQuery.IndexOf('$');
                if (index > 0)
                {
                    sqlQuery = sqlQuery.Substring(0, index) + s + sqlQuery.Substring(index + 1);
                }
            }
        }
      
        public void Qery()
        {
            using (SqlConnection connection = new SqlConnection(DataBaseHelper.ConnectionString()))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlQuery);
                    int i = 0;
                    foreach(string s in valuesNames)
                    {
                        command.Parameters.AddWithValue(s, values[i]);
                        i++;
                    }
                    command.CommandType = CommandType.Text;
                    command.Connection = connection;
                    adapter.SelectCommand = command;
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    connection.Close();
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
            }
        }
    }
}
