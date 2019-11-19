using System;
using MySql.Data.MySqlClient;

namespace UserService
{
    public class DBConnect
    {
        MySqlConnection connection = null;

        public Boolean ConnectToDB()
        {
            DBConnection db = DBConnection.Instance();
            if (db.IsConnect())
            {
                connection = db.Connection;
                Console.WriteLine("DB connection: " + connection.State);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}