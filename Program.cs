﻿using System;
using System.IO;
using System.Linq;

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
                Console.Write("Enter file path: ");
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
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine("File loaded!");

        while (true)
        {
            try
            {
                int input = 0;
                for (; ; )
                {
                    try
                    {
                        Console.Write("What line do you want to see? ");
                        input = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("The string was not in the correct format.");
                    }
                }
                if (input == 0) break;
                Console.WriteLine(lines[input - 1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine("End");
        Console.ReadLine();
    }
}