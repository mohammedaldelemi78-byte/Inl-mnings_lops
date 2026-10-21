using System;

namespace Uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en sträng");
            string str = Console.ReadLine();

            Console.WriteLine("Skriv en till sträng med två tecken");
            string str2 = Console.ReadLine();

            if (str2.Length != 2)
            {
                Console.WriteLine("Strängen måste vara exakt två tecken lång.");
                return;
            }

            if (str.Contains(str2[0].ToString()) && str.Contains(str2[1].ToString()))
            {
                Console.WriteLine($"Båda tecknen i '{str2}' finns i '{str}'.");
            }
            else
            {
                Console.WriteLine($"Inte båda tecknen i '{str2}' finns i '{str}'.");
            }
        }
    }
}