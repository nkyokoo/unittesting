using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class DBConnection
    {
   
        private DBConnection()
        {
            IsConnect();
        }

        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }


        private static DBConnection _instance = null;
        /// <summary>
        ///  gets the current instance and creates a new instance if the instance is null
        /// </summary>
        /// <returns>returns DBConnection</returns>
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        /// <summary>
        ///   Checks if the application is connected to the database and creates a new connection when connection is null
        /// </summary>
        /// <returns>True or False</returns>
        public bool IsConnect()
        {
            if (Connection == null)
            {
                string connstring = string.Format("Server=localhost; database=unittesting; UID=root;");
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
        }        
    }
}