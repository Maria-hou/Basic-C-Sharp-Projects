using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("Enter Person 1's hourly rate:");
            double rate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Person 1's hours worked per week:");
            double hours1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Enter Person 2's hourly rate:");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Person 2's hours worked per week:");
            double hours2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nAnnual salary of Person 1:");
            double salary1 = rate1 * hours1 * 52;
            Console.WriteLine(salary1);

            Console.WriteLine("Annual salary of Person 2:");
            double salary2 = rate2 * hours2 * 52;
            Console.WriteLine(salary2);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool answer = Convert.ToBoolean(salary1 > salary2);
            Console.WriteLine(answer);
            Console.ReadLine();


        }
    }
}
