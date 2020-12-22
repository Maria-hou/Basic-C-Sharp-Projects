using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6stepConsole
{
    class Program
    {
        static void Main()
        {

            //-------part 1----------
            string[] people = { "Luke was happy he got a ", "Anna hated her ", "Alex really enjoyed his ", "Lauren was sulking becuase of the ", "Maria was gratedful for the " };
            Console.WriteLine("Enter a Christmas present you bought your family member:");
            string present = Console.ReadLine();

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = people[i] + present;
            }

            for (int j = 0; j < people.Length; j++)
            {
                Console.WriteLine(people[j]);
            }
            Console.ReadLine();


            //------part 2---------
            //for (int i = 0; i < 100; i--)
            //{
            //    Console.WriteLine("Merry Chistmas");
            //}

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Merry Christmas");

            }
            Console.ReadLine();

            //-----------Part 3------------
            string[] colors = { "black", "blue", "green", "pink", "red" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            Console.ReadLine();

            for (int k = 0; k <= 2; k++)
            {
                Console.WriteLine(colors[k]);
            }
            Console.ReadLine();

            //-----------Part 4------------
            List<string> shapes = new List<string>();
            shapes.Add("circle");
            shapes.Add("parallelogram");
            shapes.Add("square");
            shapes.Add("triangle");
            shapes.Add("octogon");
            shapes.Add("oval");

            Console.WriteLine("Please enter a well known shape: ");
            string response = Console.ReadLine();

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] == response)
                {
                    Console.WriteLine("That shape is in the list! It has an index of " + i);
                    Console.ReadLine();
                    break;
                }
            }

            if (shapes.Contains(response) == false)
            {
                Console.WriteLine("That shape is not in the list.");
                Console.ReadLine();
            }


            //-----------Part 5------------
            List<string> dresses = new List<string>();
            dresses.Add("wedding");
            dresses.Add("prom");
            dresses.Add("cocktail");
            dresses.Add("prom");
            dresses.Add("dinner");
            dresses.Add("summer");

            Console.WriteLine("Which dress did you donate to GoodWill? Was it my wedding, prom, cocktail, dinner, or summer dress?");
            string guess = Console.ReadLine();

            for (int i = 0; i < dresses.Count; i++)
            {
                if (dresses[i] == guess)
                {
                    Console.WriteLine("Are you sure it was the " + guess + " dress? That was the " + i + "th dress in my closet.");
                    Console.ReadLine();
                }
                if (dresses.Contains(guess) == false)
                {
                    Console.WriteLine("I don't have a " + guess + " dress.");
                    Console.ReadLine();
                }
            }


            //-----------Part 6-----------
            List<string> cars = new List<string>() { "Honda", "Toyota", "Ram", "Subaru", "Lincoln", "Toyota", "Chevrolet", "Chevrolet"};

            List<string> duplicate = new List<string>();

            foreach (string car in cars)
            {
                if (duplicate.Contains(car))
                {
                    Console.WriteLine(car + " has appeared in the list.");
                }
                else
                {
                    Console.WriteLine(car + " has not appeared yet in the list");
                    duplicate.Add(car);
                }

            }
            Console.ReadLine();
        }
    }
}
