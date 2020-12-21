using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            string pageNumber = Console.ReadLine();
            ushort pgNum = Convert.ToUInt16(pageNumber);

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false.\" ");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positives = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            string study = Console.ReadLine();
            byte hours = Convert.ToByte(study);

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
