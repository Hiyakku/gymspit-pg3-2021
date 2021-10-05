using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char sign;
                do
                {
                    Console.WriteLine("throw an operator at me or type 0 to end: ");
                    sign = Console.ReadLine()[0];
                    if (sign == '0')
                        return;
                } while (!(sign == '+' || sign == '-' || sign == '/' || sign == '*' || sign == '%'));


                Console.WriteLine("Number number one will ya: ");
                string first = Console.ReadLine();
                double a;
                bool success = double.TryParse(first, out a);
                while (!success)
                {
                    Console.WriteLine("\"{0}\" is not a number!", first);
                    Console.WriteLine("A real one now pls: ");
                    first = Console.ReadLine();

                    success = double.TryParse(first, out a);
                }
                Console.WriteLine("Number number two will ya: ");
                string second = Console.ReadLine();
                double b;
                bool success2 = double.TryParse(second, out b);
                while (!success2)
                {
                    Console.WriteLine("\"{0}\" is not a number!", second);
                    Console.WriteLine("A real one now pls: ");
                    second = Console.ReadLine();

                    success2 = double.TryParse(second, out b);
                }

                double result = 0;

                if ((sign == '/' && b == 0)||(sign == '%' && b == 0))
                {
                    Console.WriteLine("the number 0 is individisble!");
                    Console.WriteLine("Press any key to repeat the process.");
                    Console.ReadKey();
                    continue;
                }
                if (sign == '+')
                {
                    result = a + b;
                }
                else if (sign == '-')
                {
                    result = a - b;
                }
                else if (sign == '*')
                {
                    result = a * b;
                }
                else if (sign == '/')
                {
                    result = a / b;
                }
                else if (sign == '%')
                {
                    result = a / b;
                }

                Console.WriteLine("{0} {1} {2} = {3} ", a, sign, b, result);
                Console.WriteLine("Hit any button to do the whole ride once more.");
                Console.ReadKey();
                
                

            } while (true);
        }
    }
}
