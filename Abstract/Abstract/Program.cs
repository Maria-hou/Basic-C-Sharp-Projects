﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            IQuittable quit = new Employee();
            quit.Quit();

            Console.ReadLine();

        }
    }
}
