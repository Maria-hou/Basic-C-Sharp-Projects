using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? (Answer true or false)");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQualified?");
            bool isQualified = age > 15 && DUI == false && tickets <= 3;
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
