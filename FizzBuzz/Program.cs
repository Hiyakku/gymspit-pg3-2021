using System;
namespace nocluewhatimdoing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a number please:");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else Console.WriteLine("neither Fizz, nor Buzz");


            Console.ReadLine();
        }
    }
}
