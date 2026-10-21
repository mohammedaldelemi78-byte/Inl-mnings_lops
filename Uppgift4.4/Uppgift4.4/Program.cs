using System;
namespace Öving4_4
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int val;

            do
            {

                Console.WriteLine("Välj ett av följande alternativ.");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");

                val = int.Parse(Console.ReadLine());

                if (val == 1)
                {
                    Console.WriteLine("skriv in ett tal");
                    int tal = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in andra talet");
                    int tal2 = int.Parse(Console.ReadLine());
                    double Resultat = tal - tal2;
                    Console.WriteLine(" här resultatet  " + Resultat);
                }

                else if (val == 2)
                {               
                    Console.WriteLine("skriv in ett tal");
                    double tal = int.Parse(Console.ReadLine());
                    Console.WriteLine("skriv in andra talet");
                    double tal2 = int.Parse(Console.ReadLine());
                  
                    double divsion = tal / tal2;
                    Console.WriteLine("här är resultatet " + divsion);
                }

                else if (val == 3)
                {
                    Console.WriteLine("programet avslutades");

                }
                else
                {
                    Console.WriteLine("vad håller du på med det finns bara 3 altanativ!!");
                }

            }while (val!=3);
        }
    }
}
