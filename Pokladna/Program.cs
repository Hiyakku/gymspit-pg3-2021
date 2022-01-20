using System;
using System.IO;
using System.Collections.Generic;

namespace denik
{
    class Program
    {
        static readonly string textFile = @"C:\trash\lines.txt";
        static string[] arrayAdd(string[] array, string newvalue)
        {
            string[] resize = new string[array.Length + 1];
            int i = 0;
            foreach (string e in array)
            {
                resize[i] = e;
                i++;
            }
            resize[array.Length] = newvalue;
            return resize;
        }
        static int[] arrayintAdd(int[] array, int newvalue)
        {
            int[] resize = new int[array.Length + 1];
            int i = 0;
            foreach (int e in array)
            {
                resize[i] = e;
                i++;
            }
            resize[array.Length] = newvalue;
            return resize;
        }
        static void Menu(string[] popisy, int[] cisla)
        {
            int penize = cisla[0];
            Console.Clear();
            Console.WriteLine("press A to add data");
            Console.WriteLine("press D to delete data");
            Console.WriteLine("press P to print all data");
            Console.WriteLine("press E to exit");
            int i = 1;
            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    Console.Clear();
                    Console.WriteLine("enter a value");
                    string[] checkpoint = Console.ReadLine().Split(" ");
                    if (!int.TryParse(checkpoint[0], out int a)) { Console.WriteLine("invalid text file"); Console.ReadKey(); Environment.Exit(0); }
                    popisy = arrayAdd(popisy, checkpoint[1]);
                    cisla = arrayintAdd(cisla, a);
                    Menu(popisy, cisla);
                    break;
                case 'd':
                    Console.Clear();
                    popisy = new string[0];
                    cisla = new int[0];
                    Console.WriteLine("enter a value");

                    Menu(popisy, cisla);
                    break;
                case 'p':
                    Console.Clear();


                    int currentsum = cisla[0];
                    Console.WriteLine("Pocatecni hodnota:" + cisla[0]);
                    while (i <= cisla.Length - 1)
                    {
                        Console.Write(currentsum + " ");
                        Console.Write(cisla[i] + " ");
                        Console.Write(popisy[i] + " ");
                        currentsum = currentsum + cisla[i];
                        Console.WriteLine(currentsum);
                        i++;
                    }
                    Console.WriteLine("konecna hodnota: " + currentsum);
                    int negative = 0;
                    int positive = 0;
                    foreach (int e in cisla)
                    {
                        if (e > 0)
                        {
                            positive = positive + e;
                        }
                        else
                        {
                            negative = negative + e;
                        }
                    }
                    Console.WriteLine("Celkem kladne: " + positive);
                    Console.WriteLine("Celkem zaporne: " + negative);
                    Console.Write("Celkem: ");
                    Console.WriteLine(positive + negative);
                    Console.ReadKey();
                    Menu(popisy, cisla);
                    break;
                case 'e':
                    string exitvalue = "";
                    int n = 0;
                    while (n < cisla.Length)
                    {
                        exitvalue = exitvalue + cisla[n] + " " + popisy[n] + ",";
                        n++;
                    }
                    exitvalue = exitvalue.Replace(",", System.Environment.NewLine);
                    Console.WriteLine(exitvalue);
                    Console.ReadKey();
                    Console.Clear();
                    File.WriteAllText(@"C:\trash\lines.txt", exitvalue);
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("invalid key");
                    Console.ReadKey();
                    Menu(popisy, cisla);
                    break;
            }
        }
        static void Main(string[] args)
        {
            if (File.Exists(textFile))
            {
                string[] textlines = File.ReadAllLines(textFile);
                int[] cisla = new int[0];
                string[] popisy = new string[0];

                foreach (string e in textlines)
                {
                    string[] checkpoint = e.Split(" ");
                    if (!int.TryParse(checkpoint[0], out int a)) { Console.WriteLine("invalid text file"); Console.ReadKey(); Environment.Exit(0); }
                    popisy = arrayAdd(popisy, checkpoint[1]);
                    cisla = arrayintAdd(cisla, a);
                }
                Menu(popisy, cisla);

            }
            Console.WriteLine("file doesnt exist");
        }
    }
}