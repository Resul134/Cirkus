using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    class Program
    {
        static void Main(string[] args)

        {
            PrinsessenOgKlovnen();
        }

        private static void PrinsessenOgKlovnen()
        {
            Console.WriteLine(
                "Klovn:\nHej jeg hedder Magnus, og er klovnen der skal underholde dig! Hvis du vil fortsætte skriv; ja, hvis ikke skriv Nej.");
            string klovn = Console.ReadLine();

            if (klovn == "ja" || klovn == "Ja")
            {
                Console.WriteLine("Klovn:\nPerfekt. Hvad vil du have jeg skal... hoppe eller skrige");
                string hoppe = Console.ReadLine();

                if (hoppe == "Hoppe" || hoppe == "hoppe")
                {
                    Console.WriteLine("*Klovnen hopper og laver en salto!*");
                }
                else
                {
                    Console.WriteLine("*Klovnen skriger så højt at han skider i bukserne*");
                }
            }

            else
            {
                Console.WriteLine("Så smut med dig");
                Environment.Exit(0);
            }

            string prinsesse = Convert.ToString(Console.ReadKey());
            string synger = Console.ReadLine();
            Console.WriteLine("*Prinsessen kommer løbede ind, for at undersøge larmen*");
            Console.ReadKey();
            Console.WriteLine("Hvad fanden laver du skide klovn!");
            Console.ReadKey();
            Console.WriteLine(
                "Nu hvor i alle larmer, må jeg hellere også synge, hvis det er okay med dig? Sig Yes hvis du vil");
            if (synger == "Yes") ;
            {
                Console.ReadLine();
                Console.WriteLine("*Prinsessen spytter en brandvarm rap*");
                Console.ReadKey();
                Console.WriteLine("The eeeenddd!!");
            }
        }
    }
}







