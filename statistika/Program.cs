using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Select a number for your desired action");
                Console.WriteLine("1, Data input + result");
                Console.WriteLine("2, input data for a certain number of days");
                Console.WriteLine("3, Erase all data");
                Console.WriteLine("4, ");
                Console.WriteLine("5, Exit");
                string menu = Console.ReadLine();
                int num;
                bool succc = int.TryParse(menu, out num);
                while (!succc)
                {
                    Console.WriteLine("Not a number!\nTry again please: ");
                    menu = Console.ReadLine();
                    succc = int.TryParse(menu, out num);
                }
                if (num != 1 &&(num != 2) && (num != 3) && (num != 4) && (num != 5))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again please");
                    Console.WriteLine("1, Data input + result");
                    Console.WriteLine("2, amount of ppl infected in the last week");
                    Console.WriteLine("3, Erase all data");
                    Console.WriteLine("4, ");
                    Console.WriteLine("5, Exit");
                    menu = Console.ReadLine();                    
                    succc = int.TryParse(menu, out num);
                    while (!succc)
                    {
                        Console.WriteLine("Not a number!\nTry again please: ");
                        menu = Console.ReadLine();
                        succc = int.TryParse(menu, out num);
                    }
                }
                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount of infected ppl for today: ");
                    string first = Console.ReadLine();
                    int inf;
                    bool success = int.TryParse(first, out inf);
                    while (!success)
                    {
                        Console.WriteLine("Not a number!\nTry again please: ");
                        first = Console.ReadLine();
                        success = int.TryParse(first, out inf);
                    }
                    Console.Clear();
                    Console.WriteLine("The amount of infected ppl yesterday was {0}", inf);
                }

                if (num == 2)
                {
                    Console.Clear();
                    Console.WriteLine("how many days of data are you going to input?");
                    string week = Console.ReadLine();
                    int weeknum;
                    bool success2 = int.TryParse(week, out weeknum);
                    while (!success2)
                    {
                        Console.WriteLine("Not a number!\nTry again please: ");
                        week = Console.ReadLine();
                        success2 = int.TryParse(week, out weeknum);
                    }
                    int[] infected = new int[weeknum];
                    
                    foreach (int value in infected)
                    {
                        Console.WriteLine(value);
                    }
                }

                if (num == 3)
                {
                    Console.Clear();
                    menu = "No data!";
                    num = 0;
                    Console.WriteLine("All clear boss");
                }

                if (num == 4)
                {
                    Console.Clear();
                }

                if (num == 5)
                {
                    System.Environment.Exit(0);
                }
                Console.WriteLine("Press any key to go again..");
                Console.ReadKey();
            } while (true);
        }
    }
}
