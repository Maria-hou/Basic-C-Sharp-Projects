using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPage231
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide divide = new Divide();

            //get input from user and call division method
            Console.WriteLine("Enter a number to be divided by 2: ");
            int a = Convert.ToInt32(Console.ReadLine());
            divide.Division(a);

            Console.WriteLine("\nOverload method also dividing by 2: ");
            // call overload method
            divide.Division(a, out int b);

            // call static class
            StaticClass.Thanks();
            Console.ReadLine();
        }
    }
}
