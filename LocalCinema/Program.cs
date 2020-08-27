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
                            Console.WriteLine("How many of you are going to the cinema?");
                            int goingCinema = Int32.Parse(Console.ReadLine());
                            string[] people = new string[goingCinema];

                            for (int i = 0; i < people.Length; i++)
                            {
                                Console.WriteLine($"Enter people age: {i + 1}");
                                people[i] = Console.ReadLine();

                            }
                            
                            int age = Int32.Parse(Console.ReadLine());
                            if (age <= 20)
                            {
                                Console.WriteLine("Youth price is 80kr");
                            }else if(age >= 64)
                            {
                                Console.WriteLine("Retirement price is 90kr");
                            }
                            else
                            {
                                Console.WriteLine("Standard price 120kr");
                            }
                            Console.WriteLine("Number of people");
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
                    Console.WriteLine("It is incorrect menu selection please try again.");
                }
                

            }
        }
    }
}
