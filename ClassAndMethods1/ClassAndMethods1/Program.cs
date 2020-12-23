using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Enter a numer so we can do some basic math: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input+ " plus 13 equals " + Math.Addition(input));
            Console.ReadLine();

            Console.WriteLine(input + " multiplied 3 equals " + Math.Multiply(input));
            Console.ReadLine();

            Console.WriteLine(input + " minus 239 equals " + Math.Subtraction(input));
            Console.ReadLine();
        }
    }
}
