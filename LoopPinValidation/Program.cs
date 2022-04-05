using System;

namespace LoopPinValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter PIN!");
                string userPin = Console.ReadLine();

                if (userPin == "1234")
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Login failed. You tried to log  in {i+1}");
                    if (i == 2)
                        {
                        Console.WriteLine("No attempts left. Try again later.");
                    }
                }
            }
        }
    }
}
