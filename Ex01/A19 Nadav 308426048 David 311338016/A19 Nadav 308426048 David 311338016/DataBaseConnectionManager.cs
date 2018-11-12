using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    class DataBaseConnectionManager
    {
        /// <summary>
        /// maybe sould use Reader insted of Scaler 
        /// </summary>


        private readonly SqlConnectionStringBuilder r_SqlConnectionStringBuilder;
        private SqlConnection m_SqlConnection;

        public DataBaseConnectionManager()
        {
            r_SqlConnectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "design-patterns.database.windows.net",
                UserID = "davidshemian18@gmail.com@design-patterns",
                Password = "design-patterns123",
                InitialCatalog = "Design-Patterns-DataBase"
            };

            //TODO: should add try catch? 
            m_SqlConnection = new SqlConnection(r_SqlConnectionStringBuilder.ConnectionString);

        }

        public object excecuteSqlCommand(SqlCommand i_sqlCommnand)
        {
            using (m_SqlConnection)
            {
                m_SqlConnection.Open();
                i_sqlCommnand.Connection = m_SqlConnection;

                return i_sqlCommnand.ExecuteScalar();

                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {
                //        for (int i = 0; i < reader.FieldCount; i++)
                //        {
                //            Console.WriteLine(reader.GetValue(i));
                //        }
                //    }
                //}
            }
        }
    }
}