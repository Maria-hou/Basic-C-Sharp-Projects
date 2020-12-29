
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            const string newYear = "Happy New Year!";
            var member = new Dictionary<string, string>()
            {
                {"0-1000", "Basic" },
                {"1000-5000", "Silver" },
                {"5000-10000", "Gold" },
                {"10000+", "Platinum" },
            };
            var tier = "platinum";
            Console.WriteLine(newYear + "\n\nWelcome to Chase Bank {0}, you are a {1} member.", name, tier);
            
            

            Message message = new Message(name);
            Console.ReadLine();

        }
    }
}
