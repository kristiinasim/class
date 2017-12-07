using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace pank
{
    class Program
    {
        static void Main(string[] args)
           
        {
            
           
            konto1 konto = new konto1();
            Console.WriteLine("Palun registreerige endale kontonimi:");
            konto.nimi = Console.ReadLine();
            Console.WriteLine("Nüüd registreerige palun PIN-kood:");
            konto.pin = int.Parse(Console.ReadLine());
            konto.kontoseis = 444;

            Start:
            Console.WriteLine("Mida soovite teha? Kas sisse logida (l) või registreerida (r)?");
            string c = Console.ReadLine();
            if (c == "l")
            { Console.WriteLine("Palun sisestage kontonimi ja pin-kood!");
                string [] line = File.ReadLines(@"C:\Users\opilane\Desktop\pank.txt");
                var lines = line[2];


                Console.WriteLine("Mida soovite edasi teha? Kas kontoseisu näha (n), raha välja võtta(-)või juurde lisada (+)? Väljumiseks vajutage e tähte");
            string valik = Console.ReadLine();

            if (valik == "+")
            {
                Console.WriteLine("Kui palju raha soovite lisada (eurodes)?");
                int raha = int.Parse(Console.ReadLine());
                konto.kontoseis = konto.kontoseis + raha;
                Console.WriteLine("Aitäh! Teie arvel on nüüd " + konto.kontoseis + " eurot");
                Console.ReadLine();
                goto Start;



            }
            if (valik == "-")
            {
                Console.WriteLine("Kui palju raha soovite kontolt välja võtta (eurodes)?");
                int raha = int.Parse(Console.ReadLine());
                konto.kontoseis = konto.kontoseis - raha;
                Console.WriteLine("Aitäh! Teie arvel on nüüd " + konto.kontoseis + " eurot");
                Console.ReadLine();
                goto Start;

            }
            if (valik == "n")
            {
            Console.WriteLine("Teie arvel on " + konto.kontoseis + " eurot");
            goto Start;
        }
        if (valik == "e")
        {
                StreamWriter sw = new StreamWriter(@"C:\Users\opilane\Desktop\pank.txt");
                sw.WriteLine(konto.nimi);
                sw.WriteLine(konto.pin);
                sw.WriteLine(konto.kontoseis);

                sw.Close();
        }
        {

        }
        }
    }
}






