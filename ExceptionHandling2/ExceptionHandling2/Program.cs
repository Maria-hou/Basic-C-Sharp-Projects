using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());
                DateTime year = DateTime.Now;
                int yearBorn = year.Year - age;

                if (age <= 0)
                {
                    throw new ZeroNegativeException();
                }

                Console.WriteLine("You were either born in {0} or {1}, depending on your birth month.", yearBorn, (yearBorn - 1));
                Console.ReadLine();
                return;
            }
            catch (ZeroNegativeException)
            {
                Console.WriteLine("Invalid response. You cannot be negative years old or 0 years old.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please only enter digits.");
                Console.ReadLine();
            }
        }
        public class ZeroNegativeException : Exception
        {
            public ZeroNegativeException()
                : base() { }
        }

    }
}
