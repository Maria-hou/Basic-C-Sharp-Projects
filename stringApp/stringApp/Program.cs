using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringApp
{
    class Program
    {
        static void Main()
        {
            string string1 = "Merry Christmas ";
            string string2 = "everyone ";
            string string3 = "happy holidays";

            string sentence = string1 + string2 + "and " + string3 + "!";
            Console.WriteLine(sentence);
            Console.ReadLine();

            string loud = "I hope you have a nice break!";
            Console.WriteLine(loud.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("This year has been full of surprises");
            sb.Append(" and up and downs.");
            sb.Append("\nBut it's nice to know that it will end just as any other year.");
            sb.Append(" With Christmas and New Years Eve.");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
