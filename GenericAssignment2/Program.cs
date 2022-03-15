using System;
using System.Collections.Generic;

namespace GenericAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var primeMinisters = new PrimeMinisters();
                while (true)
                {
                    Console.Write("---Enter the number what you want--- ");
                    Console.WriteLine("\n\n1 for show Prime Minister by the year");
                    Console.WriteLine("2 for add the prime minister");
                    Console.WriteLine("3 for show all prime minister by sorted");
                    Console.WriteLine("Any other number for exit");

                    int query = int.Parse(Console.ReadLine());
                    switch (query)
                    {
                        case 1:
                            {
                                Console.Write("Enter the year ");
                                int year = int.Parse(Console.ReadLine());
                                string primeMinister=primeMinisters.Get(year);
                                if(primeMinister=="")
                                    Console.WriteLine("Prime Minister not Exist");
                                else
                                {
                                    Console.WriteLine($"Prime Minister is = {primeMinister}");
                                }
                                Console.WriteLine();
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Enter the name of the prime minister ");
                                string name = Console.ReadLine();
                                Console.Write("Enter the year ");
                                int year = int.Parse(Console.ReadLine());
                                primeMinisters.Add(year, name);
                                Console.WriteLine();
                                break;
                            }
                        case 3:
                            {
                                var allPrimeMinisters = primeMinisters.GetAll();
                                PrintPrimeMinister(allPrimeMinisters);
                                Console.WriteLine();
                                break;
                            }
                        default:
                            {
                                System.Environment.Exit(0);
                                break;
                            }

                    }
                }

            }
            catch(CustomeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private static void PrintPrimeMinister(SortedDictionary<int, string> allPrimeMinisters)
        {
           foreach(var primeMinister in allPrimeMinisters)
            {
                Console.WriteLine($"Name- {primeMinister.Value} Year- {primeMinister.Key}");
            }
        }
    }
}
