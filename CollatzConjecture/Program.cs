using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DU4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string odpoved;
            string line = new string('-', Console.WindowWidth);


            Console.SetCursorPosition(30, 10);
            Console.WriteLine("|------------------------------------------------------|\n");
            Thread.Sleep(1000);
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("   Vítejte v programu, který imituje Colatzův problém\n");
            Thread.Sleep(1000);
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("|------------------------------------------------------|");

            for (int i = 1; i <= 6; i++)
            {
                Console.SetCursorPosition(5, 28);

                Console.Write($"{i}..");
                Thread.Sleep(1000);
            }


            do
            {
                Console.Clear();
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("|------------------------------------------------------|");
                Console.SetCursorPosition(45, 14);
                int user_input;

                //kontrola - input
                while (true)
                {
                    Console.SetCursorPosition(48, 14);
                    Console.Write("Zadejte celé číslo: ");
                    try
                    {
                        user_input = int.Parse(Console.ReadLine());
                        if (user_input <= 0)
                        {
                            //vyzdvihnout vyjímku 
                            throw new ArgumentOutOfRangeException();
                        }
                        break;
                    }
                    //když input není číslo
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(30, 10);
                        Console.WriteLine("|------------------------------------------------------|\n");
                        Console.SetCursorPosition(37, 16);
                        Console.WriteLine("Chybný formát. Zadejte prosím celé číslo.");
                        Console.SetCursorPosition(30, 10);
                        Console.WriteLine("|------------------------------------------------------|");


                    }
                    //když input je záporné číslí
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(30, 10);
                        Console.WriteLine("|------------------------------------------------------|\n");
                        Console.SetCursorPosition(45, 16);
                        Console.WriteLine("Zadejte kladné celé číslo.");
                        Console.SetCursorPosition(30, 10);
                        Console.WriteLine("|------------------------------------------------------|");
                    }
                }




                Console.SetCursorPosition(30, 18);
                Console.WriteLine("|------------------------------------------------------|");
                Console.Clear();
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(line);
                Console.SetCursorPosition(0, 14);
                Console.Write($"Posloupnost pro číslo {user_input} je: ");
                Console.Write(user_input);


                while (user_input != 1)
                {
                    if (user_input % 2 == 0)
                    {
                        user_input = user_input / 2;
                    }
                    else
                    {
                        user_input = 1 + (user_input * 3);
                    }
                    Console.Write($" -> {user_input}");
                }



                Console.WriteLine("\n\nChcete pokračovat? y/n");

                odpoved = Console.ReadLine();
                Console.Clear();
            } while (odpoved.ToLower() == "y");

        }
    }
}
