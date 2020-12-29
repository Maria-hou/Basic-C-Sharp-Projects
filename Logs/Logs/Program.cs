using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string input = Console.ReadLine();

            using (StreamWriter file = new StreamWriter("C:\\Users\\maria\\Desktop\\Basic_C#_Programs\\log2.txt", true))
            {
                file.WriteLine(input);
            }

            string text = File.ReadAllText(@"C:\\Users\\maria\\Desktop\\Basic_C#_Programs\\log2.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
        

    }
}
