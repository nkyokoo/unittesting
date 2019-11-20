using System;
using System.Text.RegularExpressions;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace UserService
{
    public class UserServices
    {           
        DBConnection db = DBConnection.Instance();
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dr;
        
        public Boolean IsValidEmail(string emailInput)
        {
            String emailRegex =
                @"^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+(?:[a-zA-Z]{2}|aero|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel)$";
            Regex regex = new Regex(emailRegex);
            if (regex.IsMatch(emailInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Login(string email, string password)
        {
            if (IsValidEmail(email))
            {
                connection = db.Connection;
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM users WHERE email = @email" ;
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();
                dr = command.ExecuteReader();
                 
                string _password = "";
                while (dr.Read())
                {
                    _password = dr.GetString("password");
                }
                
                if (password == _password)
                {
                    dr.Close();  
                    return true;
                }
                else
                {                    
                    dr.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Register(string username, string email, string password)
        {

            connection = db.Connection;
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO users(id, name, email, password, groupid) VALUES (@id,@name,@email,@password,1)";
                
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password,HashType.SHA384);
            Guid g = Guid.NewGuid();
            
            command.Parameters.AddWithValue("@id", g);
            command.Parameters.AddWithValue("@name", username);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", "1234");
             var result = command.ExecuteNonQuery();

             Console.WriteLine(result);
                return true;
                
        }
    }
}