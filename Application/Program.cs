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

            DataConstructor dataConstructor = new DataConstructor();
            dataConstructor.ConvertUser();

            String title =
                "-------------------------------------------------------\n"
                + "             Database interface                        \n"
                + "-------------------------------------------------------";

            Printer.SlowPrint(title, 100);
            Printer.SlowPrint("\nwrite credentials", 100);
            Printer.SlowPrint("\nemail: ", 100);
            email = Console.ReadLine();
            Printer.SlowPrint("\npassword: ", 100);
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
            if (services.Login(email, pass)) ;
            {
                Thread thread = new Thread(new ThreadStart(Run));
                thread.Start();
            }
            programState = "ready";
        }

        public static void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "showCars":
                        
                            
                        break;
                }
            }
        }
    }
}