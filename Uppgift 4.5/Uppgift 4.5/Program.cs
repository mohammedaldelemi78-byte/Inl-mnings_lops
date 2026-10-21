using System;
using System.ComponentModel.Design;
namespace Uppift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal");
            string heltal=Console.ReadLine();
            string resultat = " ";
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                int siffra = int.Parse(tecken);

                if (siffra == 9)
                {
                    siffra = 0;

                }

                else
                {
                    siffra++;
                }

                resultat += siffra;

                

            }

            Console.WriteLine("Det nya talet blir" + resultat);
        }
    }
}
