using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimePage300
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The time is now " + now);
            Console.WriteLine("\nNow please eneter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("It will be {0} in {1} hours.", now.AddHours(input), input);
            Console.ReadLine();
        }
    }
}
