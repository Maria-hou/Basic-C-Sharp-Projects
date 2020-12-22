using System;
using System.Collections.Generic;


namespace ArrayandStrings
{
    class Program
    {
        static void Main()
        {
            string[] religion = { "Hinduism", "Buddhism", "Islam", "Christianity"};
            int[] followers = { 15, 7, 24, 31 };
            List<string> god = new List<string>();
            god.Add("Brahma, Vishnu, and Shiva");
            god.Add("no gods");
            god.Add("Allah");
            god.Add("Jesus");
            Console.WriteLine("Learn about the most popular religions in the world. Please choose from 4");
            int choice = (Convert.ToInt32(Console.ReadLine())) - 1;


            if (choice < 4)
            {
                Console.Write(religion[choice] + " has " + followers[choice] + "% of followers world wide, and believes in " + god[choice] + ".");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a number from 1 to 4:");
                Console.ReadLine();
            }

        }
    }
}
