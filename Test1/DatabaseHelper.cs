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
    public static class DataBaseHelper
    {
        
        public static void deleteRow(string table, string columnName, string value)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseHelper.ConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = @value", connection))
                    {
                        command.Parameters.AddWithValue("@value", value);
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
        public static string ConnectionString()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                   "AttachDbFilename = " + Environment.CurrentDirectory + "\\Database1.mdf;" +
                   "Integrated Security = True";
        }
        /// <summary>
        /// Filling dataset with data that comes from database
        /// </summary>
        /// <param name="DataBaseQuery">Your query, if you want to add one parametr call it for example @param</param>
        /// <param name="name">(opcjonally) given name, like param (without @)</param>
        /// <param name="obj">(opcjonally) object that will be pass into database istead of param</param>
        /// <returns></returns>
        public static DataSet FillDataset(string DataBaseQuery, string name = "none", object obj = null)
        {
            using (SqlConnection connection = new SqlConnection(DataBaseHelper.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    DataSet dataset = new DataSet();
                    SqlCommand command = new SqlCommand(DataBaseQuery, connection);
                    if (name != "none")
                        command.Parameters.AddWithValue("@" + name, obj);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset);
                    connection.Close();
                    return dataset;
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                    return null;
                }
            }

        }
    }
}

