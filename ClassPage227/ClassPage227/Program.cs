using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPage227
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number to multiply the first by, this is optional. If no number is entered, a default of 3 will be used: ");
            string b = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(b))
            {
                Console.WriteLine(a + " multiplied by 3 is " + Math.DoMath(a));
            }
            else
            {
                Console.WriteLine(a + " multiplied by " + b + " is " + Math.DoMath(a, Convert.ToInt32(b)));
            }

            Console.ReadLine();
        }
    }
}
