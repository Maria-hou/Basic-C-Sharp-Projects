using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPage226
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Enter a number to add to 231: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + " plus 231 is " + Math.DoMath(input));

            Console.WriteLine("Enter a decimal to subtract 24.5 from: ");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(input2 + " minus 24.5 is " + Math.DoMath(input2));

            Console.WriteLine("Enter a number to multiply by 5: ");
            string input3 = Console.ReadLine();
            Console.WriteLine(input3 + " multiplied by 5 is " + Math.DoMath(input3));


            Console.ReadLine();
        }
    }
}
