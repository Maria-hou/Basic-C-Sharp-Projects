using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPage231
{
    public class Divide
    {
        public void Division(int a)
        {
            Console.WriteLine(a + " / 2 = " + a / 2);
        }

        public void Division(int a, out int b)
        {
            b = 3;
            Console.WriteLine(a + " / 2 = " + a / 2);
        }
    }
}
