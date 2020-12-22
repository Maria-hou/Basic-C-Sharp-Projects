using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 23, 65, 56, 76, 345, 932548 };
            try
            {
                Console.WriteLine("Please enter a whole number to divide a list of integers by: ");
                int answer = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num.Count; i++)
                {
                    int division = num[i] / answer;
                    Console.WriteLine(num[i] + " divided by " + answer + " is " + division);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0, please enter another number");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nThank you!");
                Console.ReadLine();
            }
        }
    }
}
