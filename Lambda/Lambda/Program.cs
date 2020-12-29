using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { firstName = "Joe", lastName = "Hobo", ID = 1 };
            Employee e2 = new Employee { firstName = "Joe", lastName = "Roegan", ID = 2 };
            Employee e3 = new Employee { firstName = "Oscar", lastName = "Martinez", ID = 3 };
            Employee e4 = new Employee { firstName = "Meredith", lastName = "Palmer", ID = 4 };
            Employee e5 = new Employee { firstName = "Pam", lastName = "Halpert", ID = 5 };
            Employee e6 = new Employee { firstName = "Angela", lastName = "Martin", ID = 6 };
            Employee e7 = new Employee { firstName = "Michael", lastName = "Scott", ID = 7 };
            Employee e8 = new Employee { firstName = "Dwight", lastName = "Shrute", ID = 8 };
            Employee e9 = new Employee { firstName = "Kelly", lastName = "Kapoor", ID = 9 };
            Employee e10 = new Employee { firstName = "Karen", lastName = "Filipelli", ID = 10 };

            List<Employee> empList = new List<Employee>() { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };

            //List<Employee> joes = new List<Employee>();
            //foreach (Employee employee in empList)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        joes.Add(employee);
            //    }
            //}
            //foreach (Employee joe in joes)
            //{
            //    Console.WriteLine(joe.firstName + " " + joe.lastName + " with an ID of " + joe.ID);
            //}
            //Console.ReadLine();



            List<Employee> JoeList = empList.Where(x => x.firstName == "Joe").ToList();
            foreach(Employee joe in JoeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName + " with an ID of " + joe.ID);
            }

            List<Employee> IDList = empList.Where(x => x.ID > 5).ToList();
            foreach(Employee employee in IDList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " with an ID of " + employee.ID);
            }
            Console.ReadLine();
        }
    }
}
