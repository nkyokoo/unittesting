using System;
using System.Collections.Generic;
using System.Threading;
using MySql.Data.MySqlClient;
using UserService;

namespace Application
{
    class Program
    {
        private static string programState = "";

        static void Main(string[] args)
        {
            string email = "";
            string pass = "";

            String title =
                "-------------------------------------------------------\n"
                + "             Database interface                        \n"
                + "-------------------------------------------------------";

            Printer.SlowPrint(title, 50);
            Printer.SlowPrint("\nwrite credentials", 50);
            Printer.SlowPrint("\nemail: ", 50);
            email = Console.ReadLine();
            Printer.SlowPrint("\npassword: ", 50);
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if(key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);
            UserServices services = new UserServices();
            if (services.Login(email, pass)) 
            {
                Printer.SlowPrint("\nlogged in\n", 50);
                Thread thread = new Thread(new ThreadStart(Run));
                thread.Start();
            }
            else
            {
                Console.WriteLine("password incorrect");
                Environment.Exit(-1);
                
            }
            programState = "ready";
        }

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                string command = Console.ReadLine();
                DatabaseServices databaseServices = new DatabaseServices();
                switch (command)
                {
                    case "showCars":

                        databaseServices.GetCars();
                            
                        break;
                    case "showUsers":

                        databaseServices.GetUsers();
                            
                        break;
                }
            }
        }
    }
}