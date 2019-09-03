using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Callerid_demo
{
    class DatabaseManager
    {
        private static string data_source = ".";
        private static string initial_catalog = "db_ros";
        public static SqlConnection connection;
        SqlCommand command;

        public static void  Connect()
        {
            string connection_string = string.Format("Data Source ={0}; Initial Catalog = {1}; Integrated Security = True", data_source, initial_catalog);
            connection = new SqlConnection(connection_string);
        }

        public static void Open()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void Close()
        {
            connection.Close();
        }


    }
}
