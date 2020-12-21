using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nPlease enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50.00)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());
                double dimensions = (width + height + length);
                double quote = (height * width * length * weight) / 100.00;
                

                Console.WriteLine(dimensions > 50.00 ? "\nPackage too big to be shipped " +
                    "via Package Express" : "\nYour Estimated total for shipping this " +
                    "package is: $" + String.Format("{0:0.00}", quote));

                Console.WriteLine("\nThank you!");
            }
        }
    }
}
