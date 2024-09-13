using System;

namespace zliczanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Zaczynamy:");
            while (true)
            {
                Console.WriteLine("Podaj liczbe:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    result += number;
                    Console.WriteLine($"Aktualny wynik: {result}");
                } 
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Wynik końcowy: {result}");
        }
    }
}