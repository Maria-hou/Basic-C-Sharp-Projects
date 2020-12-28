using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Anna = new Employee() { Name = "Anna", ID = 001 };
            Employee Lauren = new Employee() { Name = "Lauren", ID = 002 };

            Console.WriteLine("Both employees have the same IDs." + (Anna == Lauren));
            Console.WriteLine("Both employees do not have the same IDs." + (Anna != Lauren));
        }
    }
}
