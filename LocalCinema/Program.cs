﻿using System;

namespace LocalCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares variables that control the main loop
            bool isRunning = true;


            while (isRunning)
            {
                Console.WriteLine("Welcome to main menu entering numbers to different menu");
                Console.WriteLine("Menu option [0] Shuts down the program");
                Console.WriteLine("Menu option [1] Youth or pensioner");
                Console.WriteLine("Menu option [2] Repeat ten times");
                Console.WriteLine("Menu option [3] The third word");

                if (Int32.TryParse(Console.ReadLine(), out int results))
                {
                    switch (results)
                    {
                        case 0:
                            Console.WriteLine("The program will end.");
                            isRunning = false;
                            break;
                        case 1:
                            Console.WriteLine("How many of you are going to the cinema?");
                            int goingCinema = Int32.Parse(Console.ReadLine());
                         //   string[] personAge = new string[goingCinema];
                            


                            double totalCost = 0;

                            for (int i = 0; i < goingCinema; i++)
                            {
                                Console.WriteLine($"Enter person age: {i + 1}");
                                // personAge[i] = Console.ReadLine();
                                var age = int.Parse(Console.ReadLine());



                                if (age <= 20)
                                {
                                    Console.WriteLine($"Youth price 80kr");
                                    totalCost += 80;
                                }else if(age >= 64)
                                {
                                    Console.WriteLine($"Pensioner 90kr");
                                    totalCost += 90;
                                }
                                else
                                {
                                    Console.WriteLine("Standard price 120kr");
                                    totalCost += 120;
                                }
                                
                            }

                            Console.WriteLine($"Number of people go to cinema: {goingCinema}");
                            Console.WriteLine($"Total cost go to cinema : {totalCost}");







                            break;
                        case 2:
                            
                            for (int i = 1; i < 11; i++)
                            {
                                Console.WriteLine("");
                                string userInput = Console.ReadLine();
                                Console.WriteLine(userInput);
                            }
                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("It is incorrect menu selection please try again.");
                }
                

            }
        }
    }
}
