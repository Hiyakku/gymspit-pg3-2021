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

                Console.WriteLine("operator pls:");
                string plusnebominus = Console.ReadLine();
                if (plusnebominus != "+" && (plusnebominus != "-") && (plusnebominus != "*") && (plusnebominus != "/"))
                {
                    Console.WriteLine("sorry, wrong operator. I shall now terminate");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                Console.WriteLine("nümber one pls:");
                double num1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));


                Console.WriteLine("nümber two:");
                double num2 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

                double result;

                if (plusnebominus == "+")
                {
                    result = num1 + num2;
                }
                else if (plusnebominus == "-")
                {
                    result = num1 - num2;
                }
                else if (plusnebominus == "*")
                {
                    result = num1 * num2;
                }
                else if (plusnebominus == "/")
                {
                    result = num1 / num2;
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
