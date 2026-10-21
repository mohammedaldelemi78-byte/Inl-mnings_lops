using System;
using System.Threading.Channels;
namespace uppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Skriv in ett heltal");
            int tal = int.Parse(Console.ReadLine());
            int StorstaTal= tal;

            Console.WriteLine("vill du skriva ett till heltal? JA eller inte");
            string svar=Console.ReadLine();
            while (svar== "ja" )
            {
                Console.WriteLine("skriv ett till heltal?");
                int nytttal =int.Parse(Console.ReadLine());

                if (nytttal > StorstaTal)
                {
                    StorstaTal = nytttal;
                }
                Console.WriteLine("vill du skriva ett til tal ja eller nej");
                 svar = Console.ReadLine();
            }
            if ( svar == "nej")
            {
                Console.WriteLine("ditt stösta heltal är " + StorstaTal);
            }
             else
            {
                Console.WriteLine("ogiltigt svar. pogrammet avslutar");
            }

        }

    }
}
