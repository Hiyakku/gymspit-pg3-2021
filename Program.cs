using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chytáníchybiček
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[0];
            string path = "";

            while (true)
            {
                try
                {
                    Console.WriteLine("Please direct me to your directory: ");
                    path = Console.ReadLine();                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
                try
                {
                    lines = File.ReadAllLines(path);
                    break;
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);                    
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            while (true)
            {
                try
                {
                    int input = 0;
                    while (true)
                    {
                        try
                        {
                            Console.Write("which line r u looking for? ");
                            input = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("String not stringed");
                            continue;
                        }
                    }
                    if (input == 0)
                    {
                        Console.WriteLine("Terminating...");
                        break;
                    }
                    Console.WriteLine(lines[input - 1]);
                }   
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
