using System;
using System.Text.RegularExpressions;

namespace UserService
{
    public class UserServices
    {
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
            if (email == "user@example.com" && password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}