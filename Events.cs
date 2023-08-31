using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Study
{
    public class Events
    {
        public static void SendEmailUser()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sending email user");
        }

        public static void SendEmailEncoded()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sending email encoded");
        }
    }
}