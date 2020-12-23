using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPage226
{
    public class Math
    {
        public static int DoMath(int input)
        {
            return input + 231;
        }

        public static int DoMath(decimal input2)
        {
            return Convert.ToInt32(input2 - 24.5m);
        }

        public static int DoMath(string input3)
        {
            int num = Convert.ToInt32(input3);
            return (num * 5);
        }
    }
}
