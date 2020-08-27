using System;

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
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("It is incorrect menu selection.");
                }
                

            }
        }
    }
}
