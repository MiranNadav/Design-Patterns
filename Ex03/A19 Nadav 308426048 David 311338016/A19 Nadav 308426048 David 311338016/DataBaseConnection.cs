using System;
using System.Collections.Generic;
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
        public static void InsertIntoDataBase(string i_InsertCommandText)
        {
            try
            {
                string myConnectionString = "datasource=sql7.freesqldatabase.com;port=3306;DataBase=sql7271123;username=sql7271123;password=1cdr4UjyE1";
                MySqlConnection mySqlConnection = new MySqlConnection(myConnectionString);
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
    }
}
