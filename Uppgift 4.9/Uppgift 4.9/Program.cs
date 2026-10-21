using System;

namespace Uppgift4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int antalX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            int antalO = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            int antalMönster = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int antalRader = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int rad = 0; rad < antalRader; rad++)
            {
                // Rad börjar med en X-grupp
                for (int i = 0; i < antalX; i++)
                {
                    Console.Write("X");
                }

                // Sedan upprepas: bindestreck, O-grupp, bindestreck, X-grupp
                for (int m = 0; m < antalMönster; m++)
                {
                    Console.Write("-");

                    for (int i = 0; i < antalO; i++)
                    {
                        Console.Write("O");
                    }

                    Console.Write("-");

                    for (int i = 0; i < antalX; i++)
                    {
                        Console.Write("X");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}