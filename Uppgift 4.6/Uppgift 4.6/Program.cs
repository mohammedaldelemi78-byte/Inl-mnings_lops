using System;
namespace Uppgift4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett medelande?");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Sriv in ett heltal");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)

            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);


            }
        }
    }
}
