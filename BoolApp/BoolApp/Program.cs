using System;

namespace BoolApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess what the cat is doing!");
            string activity = Console.ReadLine();
            bool guess = activity == "sleeping";

            do
            {
                switch (activity)
                {
                    case "eating":
                        Console.WriteLine("\nWhile cats do love to eat, this one is doing something different.");
                        Console.WriteLine("Guess what the cat is doing!");
                        activity = Console.ReadLine();
                        break;

                    case "hunting":
                        Console.WriteLine("\nHmm, not quite, this cat is quite lazy.");
                        Console.WriteLine("Guess what the cat is doing!");
                        activity = Console.ReadLine();
                        break;

                    case "sleeping":
                        Console.WriteLine("\nAhh yes, this cat loves to sleep.");
                        guess = true;
                        break;

                    default:
                        Console.WriteLine("\nHmm, try 'sleeping', 'eating', or 'hunting'.");
                        activity = Console.ReadLine();
                        break;
                }

            }
            while (!guess);
            Console.ReadLine();

        }
    }
}
