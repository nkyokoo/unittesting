using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Application
{
    public class Printer
    {
        public static void SlowPrint(string message, int delay)
        {
            List<Char> messageList = message.ToCharArray().ToList();
            foreach (char c in messageList)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }

        }
            
    }
}