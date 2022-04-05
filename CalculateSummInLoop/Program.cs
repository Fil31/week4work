using System;

namespace CalculateSummInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // САМОСТОЯТЕЛЬНАЯ РАБОТА. 10 РАНДОМНЫХ ЧИСЕЛ И ИХ СУММА
            Random rnd = new Random();
            int sum = 0;
            Console.WriteLine("Генерирую числа...");
            for (int i = 0; i < 10; i++)
            {
                int myRandom1 = rnd.Next(1, 11);
                sum += myRandom1;
                Console.WriteLine($"{myRandom1}");
            }
            Console.WriteLine($"Summa: {sum}");
            // САМОСТОЯТЕЛЬНАЯ РАБОТА. 10 РАНДОМНЫХ ЧИСЕЛ И ИХ СУММА
        }
    }
}
