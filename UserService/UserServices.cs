using System;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace UserService
{
    public class UserServices
    {           
        DBConnection db = DBConnection.Instance();

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
                MySqlConnection connection = DBConnection.Instance().Connection;
                MySqlCommand command = null;
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM users WHERE email = @email" ;
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();

                if (email == "user@example.com" && password == "1234")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}