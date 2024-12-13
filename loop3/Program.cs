using System;
using System.Diagnostics.CodeAnalysis;

namespace loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Skriv in fem heltal");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in ett heltal");
                int nummer = int.Parse(Console.ReadLine());
                sum += nummer;
            }

            Console.WriteLine($"Summan av talen är: {sum}");
        }
    }
}