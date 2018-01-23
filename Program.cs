using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string Name = Console.ReadLine();

            Console.WriteLine($"Hello, {Name}! Please enter a number between 1 and 100");
            int Input = int.Parse(Console.ReadLine());

            if (Input <= 1 || Input >= 100)
            {
                Console.WriteLine("You chose a number outside the range! Try again!");
                Main(args);
            }
            else
            {
                if (Input % 2 == 0)
                {
                    if (Input >= 2 && Input <= 25)
                    {
                        Console.WriteLine($"{Name}'s number ({Input}) is less than 25 and even");
                    }
                    else if (Input >= 26 && Input <= 60)
                    {
                        Console.WriteLine($"{Name}'s number is even");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}'s number ({Input}) is even");
                    }
                }
                else
                {
                    Console.WriteLine($"{Name}'s number ({Input}) is odd");
                }
                
                Console.WriteLine("Would you like to go again? (Y/N)");
                string response = Console.ReadLine();
                if (response == "y" || response == "Y")
                {
                    Main(args);
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
