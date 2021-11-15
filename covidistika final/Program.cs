using System;
using System.Linq;
namespace Covid_Statistics
{
    class Program
    {
  

        static int AmountOfDays(bool nonZero = true)
        {
            int result;
            bool success;
            do
            {
                string input = Console.ReadLine();
                success = Int32.TryParse(input, out result) && !(nonZero && result == 0);
                if (!success)
                {
                    Console.WriteLine("\"{0}\" is not a {1}number!", input, nonZero ? "non-zero " : "");
                    Console.WriteLine("Please enter a non-zero number: ");
                }
            }
            while (!success);
            return result;
        }

        static int Menu()
         {
            int whereto;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Edit Data");
                Console.WriteLine("2 - Delete Data");
                Console.WriteLine("3 - Show Data");
                Console.WriteLine("0 - Quit");
                Console.WriteLine("Enter your number of choice:");
                while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out whereto) && whereto < 4 && whereto >= 0) ;
                return whereto;
                
            }           
        }

            
        
        static void Main(string[] args)
        {
            Console.WriteLine("How many days of recorded cases do you want to input?");
            int days = AmountOfDays();
            int[] cases = new int[days];
            for (int i = 0; i < cases.Length; i++)
            {
                Console.WriteLine("Cases recorded on day {0}: ", i + 1);
                int casesperday = AmountOfDays();
                cases[i] = casesperday;
            }
            bool direction = true;
            int op;
            Console.Clear();
            do
            {
                op = Menu();
                if (op == 0)
                {
                    Console.Clear();
                    break;
                }
                if (op == 1)
                {
                    Console.Clear();
                    for (int i = 0; i < cases.Length; i++)
                    {
                        Console.WriteLine("Cases recorded on day {0}: ", i + 1);
                        int casesperday = AmountOfDays();
                        cases[i] = casesperday;
                    }
                    
                }
                if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the amount of days you want to erase or type \"0\" to clear all (inputing said number in negative will delete desired amount of data from the other side");
                    int del;
                    bool delete = (int.TryParse(Console.ReadLine(), out del) && Math.Abs(del) <= cases.Length);
                    while (!delete)
                    {
                        Console.WriteLine("Entered value is out of range!");
                        delete = (int.TryParse(Console.ReadLine(), out del) && Math.Abs(del) <= cases.Length);
                    }
                    if (del > 0)
                    {
                        Array.Reverse(cases);
                        Array.Resize(ref cases, cases.Length - del);
                        Array.Reverse(cases);
                        Console.WriteLine("New list: ");
                        for (int iclear = 0; iclear < cases.Length; iclear++)
                        {
                            Console.WriteLine("Day {0}: {1}", iclear + 1, cases[iclear]);
                        }
                        
                    }
                    if (del < 0)
                    {
                        del = Math.Abs(del);
                        Array.Resize(ref cases, cases.Length - del);
                        Console.WriteLine("New list: ");
                        for (int iclear = 0; iclear < cases.Length; iclear++)
                        {
                            Console.WriteLine("Day {0}: {1}", iclear + 1, cases[iclear]);
                        }
                        
                    }
                    if (del == 0)
                    {
                        Array.Resize(ref cases, cases.Length - cases.Length);
                        Console.WriteLine("All clear");
                        Console.ReadLine();
                    }

                }
                if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("List of entered data: ");
                    for (int i = 0; i < cases.Length; i ++)
                    {
                        Double R = 0;
                        if (i >= 14)
                            R = Math.Round((double)(cases[i] + cases[i - 1] + cases[i - 2] + cases[i - 3] + cases[i - 4] + cases[i - 5] + cases[i - 6]) * 100.0 / (double)(cases[i - 7] + cases[i - 8] + cases[i - 9] + cases[i - 10] + cases[i - 11] + cases[i - 12] + cases[i - 13])) / 100.0;
                        Console.WriteLine("Day {0} - {1}, R was {2}", i + 1, cases[i], R);
                    }
                    if (cases.Length == 0)
                    {
                        Console.WriteLine("No data to be shown");
                        Console.ReadLine();
                        break;
                    }
                    else {
                        float sum = cases.Sum();
                        Console.WriteLine("The total amount of cases in a {0} day period is {1}.", days, sum);
                        Console.WriteLine("The average number of cases per 100 000 citizens for the past {1} days is {0}", sum / 10, days);
                        Console.WriteLine("The minimum was {0} cases", cases.Min());
                        Console.WriteLine("The maximum was {0} cases", cases.Max());
                        Console.WriteLine("The average was {0} cases per day", cases.Average());
                        Console.ReadLine();  }
                }
            } while (direction == true);

            Console.WriteLine();
            Console.Write("You can now exit the program, press any key to do so.");
            Console.ReadKey();
        }
    }
}
