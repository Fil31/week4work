using System;

namespace Loops3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int myRandom = rnd.Next(1, 11);
                Console.WriteLine($"{myRandom}");
            }
        }
    }
}
