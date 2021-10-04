using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("operator pls, or type \"Exit\" to exit:");
                string plusnebominus = Console.ReadLine();
                if (plusnebominus != "+" && (plusnebominus != "-") && (plusnebominus != "*") && (plusnebominus != "/") && (plusnebominus != "Exit"))
                {
                    Console.WriteLine("sorry, invalid input. I shall now terminate");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                else if (plusnebominus == "Exit")
                {
                    Console.WriteLine("So you've chosen... death.");
                    System.Environment.Exit(0);
                }
                Console.WriteLine("Enter number one.");
                string input = Console.ReadLine();
                double a;
                bool success = double.TryParse(input, out a);

                while (!success)
                {
                    Console.WriteLine("\"{0}\" is not a number.", input);
                    Console.WriteLine("a real one now pls...");
                    input = Console.ReadLine();

                    success = double.TryParse(input, out a);
                }

                Console.WriteLine("Enter number two.");

                string input2 = Console.ReadLine();
                double b;
                bool success2 = double.TryParse(input2, out b);

                while (!success2)
                {
                    Console.WriteLine("\"{0}\" is not a number.", input2);
                    Console.WriteLine("a real one now pls...");
                    input2 = Console.ReadLine();

                    success2 = double.TryParse(input2, out b);
                }

                double result;

                if (plusnebominus == "+")
                {
                    result = a + b;
                }
                else if (plusnebominus == "-")
                {
                    result = a - b;
                }
                else if (plusnebominus == "*")
                {
                    result = a * b;
                }
                else if (plusnebominus == "/")
                {
                    result = a / b;
                }
                else
                {
                    result = 0;
                }

                Console.WriteLine(result);

                Console.ReadLine();
            }
        }
    }
}

