using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPage228
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Multiply(2, 8);
            math.Multiply(a: 2, b: 8);

            Console.ReadLine();
        }
    }
}
