using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace A19_Nadav_308426048_David_311338016
{
    public class DataBaseConnection
    {
        private static readonly string r_ConnectionString = "datasource=sql7.freesqldatabase.com;port=3306;DataBase=sql7271123;username=sql7271123;password=1cdr4UjyE1";

        public static void InsertIntoDataBase(string i_InsertCommandText)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(r_ConnectionString);
                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = i_InsertCommandText;
                mySqlConnection.Open();
                command.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static DataTable GetFromDataBase(string i_SelectCommand)
        {
            DataTable dataTable = new DataTable();

            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection(r_ConnectionString);
                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = i_SelectCommand;
                mySqlConnection.Open();
                command.ExecuteNonQuery();

                using (MySqlDataAdapter da = new MySqlDataAdapter(command))
                {
                    da.Fill(dataTable);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return dataTable;
        }
    }
}
