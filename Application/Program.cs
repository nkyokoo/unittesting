using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using UserService;

namespace Application
{
    class Program
    {
      
        static void Main(string[] args)
        {
            DBConnect dbConnect = new DBConnect();
            dbConnect.ConnectToDB();
            
            Console.WriteLine("Enter your credentials");
        }
    }
}
    
