using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject? Don't forget to capitalize the first letter");

            var answer = Console.ReadLine();

            switch (answer)
            {
                case "Math":
                    Console.WriteLine("Math is my favorite as well!");
                    break;
                case "Science":
                    Console.WriteLine("Science is cool.");
                    break;
                case "History":
                    Console.WriteLine("History is important.");
                    break;
                case "English":
                    Console.WriteLine("English is tough...");
                    break;
                case "Spanish":
                    Console.WriteLine("Muy bien, yo también.");
                    break;
                default:
                    Console.WriteLine("I'm not familiar, but that sounds intriguing.");
                    break;
            }
        }
    }
}
