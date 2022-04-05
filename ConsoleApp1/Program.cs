using System;

namespace HelloWorld
{
    public class Hello
    {
        static void Main()
        {
            // ЭТО НЕ ОТНОСИТСЯ К ЗАДАНИЮ И К ЛЕКЦИИ!!! 
            // ЭТО НЕ ОТНОСИТСЯ К ЗАДАНИЮ И К ЛЕКЦИИ!!! 
            // ЭТО НЕ ОТНОСИТСЯ К ЗАДАНИЮ И К ЛЕКЦИИ!!! 
            // ЭТО НЕ ОТНОСИТСЯ К ЗАДАНИЮ И К ЛЕКЦИИ!!! 
            // ЭТО НЕ ОТНОСИТСЯ К ЗАДАНИЮ И К ЛЕКЦИИ!!! 
           
            Console.WriteLine("Welcome to the online casino!");
            String name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            switch (age)
            {
                case < 18:
                    Console.WriteLine("You are too young.");
                    return;

                case > 18:
                    Console.WriteLine($"Good, let's play a game, {name}!");
                    break;

                default:
                    Console.WriteLine($"Incorrect number.");
                    break;
            }

            Console.WriteLine("I will guess a number between 1 and 100");
            Console.WriteLine($"All you need to do, {name}, is say whether my number is closer to 1 or 100");
            Console.WriteLine($"If you win, {name}, you will get a fabulous prize!");
            int playAgaincode = 0;
            while (playAgaincode != -1)
            //for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ok, {name}, Let's Go! Enter you GUESS. Enter either the number 1 or 100, {name}");
                int players_number = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int computer_guess = rnd.Next(1, 100);
                Console.WriteLine("Here i my number, {0}: {1}", name, computer_guess);

                if (computer_guess < 50 && players_number == 1)
                {
                    Console.WriteLine("player WINS!!!");
                }
                else if (computer_guess >= 50 && players_number == 100)
                {
                    Console.WriteLine("player WINS!!");
                }
                else
                {
                    Console.WriteLine("player loses!!!");
                }
                {
                    Console.WriteLine($"As to your Prize - Honestly, {name}, at the Sweet Age of {age}, you should know better than to believe vague promises...");
                }
            }
        }
    }
}




