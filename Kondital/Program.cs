using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondital
{
    class Program
    {
        static string sex;
        static int weight;
        static int restingpuls;
        static int maxpuls;

        static void Main(string[] args)
        {
            Console.WriteLine("Kondital");
            sex = MandEllerKvinde();
            weight = vaegt();
            restingpuls = Hvilepuls();
            maxpuls = MaksPuls();
            Console.WriteLine($"Deres Kontital er: {Kondital.BeregnKondital(restingpuls, maxpuls)}");
            Console.ReadLine();
        }
        /// <summary>
        /// Finder ud af hvilke værdier der skal bruges når der en udregners kondital
        /// </summary>
        /// <returns>sender enten "mand" eller "kvinde" tilbage</returns>
        static string MandEllerKvinde()
        {
            Console.WriteLine("Hvad er deres køn?");
            Console.WriteLine("Hvilket værdier skal vi regne med?\n\t Mand \n\t eller \n\t Kvinde");
            string koon = "";
            bool proevIgen = false;
            string input = Console.ReadLine();
            do
            {
                switch (input.ToLower())
                {
                    case "mand":
                    case "m":
                        proevIgen = false;
                        koon = "mand";
                        break;
                    case "kvinde":
                    case "k":
                        proevIgen = false;
                        koon = "kvinde";
                        break;
                    default:
                        proevIgen = true;
                        Console.WriteLine("Du skal skrive om det er en mand eller en kvinde");
                        break;
                }
            } while (proevIgen);
            return koon;
        }
        /// <summary>
        /// vægt
        /// </summary>
        /// <returns></returns>
        static int vaegt()
        {
            Console.WriteLine("hvad er deres vægt i kg ?");
            return ErDetEtTal(Console.ReadLine());
        }
        static int Hvilepuls()
        {
            Console.WriteLine("Hvad er deres hvilepuls? (pulsen er slag pr. minut)");
            return ErDetEtTal(Console.ReadLine());
        }
        static int MaksPuls()
        {
            Console.WriteLine("Hvad er deres makspuls? (pulsen er slag pr. minut)");
            return ErDetEtTal(Console.ReadLine());
        }
        /// <summary>
        /// Finder ud af om det er et int tal. Hvis det IKKE er, tvinges brugeren til at skrive et.
        /// </summary>
        /// <param name="indtastet">den string som der skal findes ud af om er et int tal</param>
        /// <returns>sender en int værdi tilbage</returns>
        static int ErDetEtTal(string indtastet)
        {
            bool erNummer = int.TryParse(indtastet, out int nummer);
            while (!erNummer)
            {
                Console.WriteLine("Du skal intaste et nummer!");
                Console.WriteLine("Prøv igen");
                erNummer = int.TryParse(Console.ReadLine(), out nummer);
            }
            return nummer;
        }


    }
}