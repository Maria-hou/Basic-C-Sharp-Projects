using System;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int product = num1 * 50;
            Console.WriteLine(num1 + " X 50 = " + product);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num2 + 25;
            Console.WriteLine(num2 + " + 25 = " + sum);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            double quotient = num3 / 12.5;
            Console.WriteLine(num3 + " / 12.5 = " + quotient);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool comparison = num4 > 50;
            Console.WriteLine(num4 + " > 50 is " + comparison);
            Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int modulo = num5 % 7;
            Console.WriteLine(num5 + " % 7 is " + modulo);
            Console.ReadLine();
        }
    }
}
