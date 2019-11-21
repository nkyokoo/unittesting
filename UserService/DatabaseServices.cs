using System;
using MySql.Data.MySqlClient;

namespace UserService
{
    public class DatabaseServices
    {
        DBConnection db = DBConnection.Instance();
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
        
        public bool CreateCar()
        {
            throw new NotImplementedException("missing test");

        }
        public bool GetCars()
        {
            try
            {
                connection = db.Connection;
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM cars LIMIT 30 ";
                command.ExecuteNonQuery();
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(" | " + dr.GetInt32("id") + " | " + dr.GetString("brand") + " " +
                                      dr.GetString("name") + " | " + dr.GetInt32("year") + " | " );
                }
                dr.Close();

                return true;
            }
            catch (Exception e)
            {
                dr.Close();
                Console.WriteLine(e);
                return false;
            }
            
        }

        public bool DeleteCar()
        {
            throw new NotImplementedException("missing test");
        }
        
        public bool GetUsers()
        {
            try
            {
                connection = db.Connection;
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM users LIMIT 30 ";
                command.ExecuteNonQuery();
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(" | " + dr.GetString("id") + " | " +
                                      dr.GetString("name") + " | "
                                      + dr.GetString("email") + " | "
                                      + dr.GetInt32("groupid") + " | " );
                }
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                dr.Close();
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteUser()
        {
            throw new NotImplementedException("missing test");
        }
    }
}