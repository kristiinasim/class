using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] minuArvud = new int[5];
            minuArvud[0] = 10;
            minuArvud[1] = 12;
            minuArvud[2] = 3;
            minuArvud[3] = 1;
            minuArvud[4] = 7;

            //List<int> minuArvudListis = new List<int>();
            //minuArvudListis.Add(1); //index 0
            //minuArvudListis.Add(2);
            //minuArvudListis.Add(3);
            //minuArvudListis.Add(4);
            //minuArvudListis.Add(5);
            //minuArvudListis.Add(6);
            //minuArvudListis.Add(7);

            List<int> minuArvudListis = new List<int>(
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });


            List<string> minutekstidlistis = new List<string>(
                new string[] { "abc", "bca", "cba" });

            List<Human> minuInimesedListis = new List<Human>
            {
                new Human { Nimi = "Kris", Vanus = 19 },
                new Human { Nimi = "Kalle"},


            };
            /*var Inimesedkellevanusonkakslol = minuInimesedListis.Where(x => x.Vanus == 2); *///anonüümne muutuja x, umbes nagu var
            //f/*oreach (var item in Inimesedkellevanusonkakslol)*/
            {
                //Console.WriteLine("Inimese nimi on {0} ja vanus on {1}", /*inimene.Vanus*/);
            }
            var Inimesedkellevanusonkaks = from inimene in minuInimesedListis
                                               //where inimene.Vanus == 2
                                           orderby inimene.Vanus
                                           where inimene.Vanus <= 25
                                           where inimene.Nimi !=null && inimene.Nimi.Contains("i")
                                           where inimene.Nimi != null && inimene.Nimi.Length > 3
                                           select inimene;
            var mituInimest = minuInimesedListis.Count();
            var mituErinevat = minuInimesedListis.Distinct();

            //Human esimeneInimene = new Human();
            //esimeneInimene.Nimi = "k";
            //esimeneInimene.Vanus = 19;

            //var teineInimene = new Human();
            //teineInimene.Nimi = "ABC";
            //teineInimene.Vanus = 60;



            //minuInimesedListis.Add(esimeneInimene);
            //minuInimesedListis.Add(esimeneInimene);
            //minuInimesedListis.Add(esimeneInimene);
            //minuInimesedListis.Add(esimeneInimene);

            foreach (Human inimene in minuInimesedListis)
            {
                /*Console.WriteLine(inimene.Nimi + " " + inimene.Vanus)*/
                Console.WriteLine("inimese nimi on {0} ja vanus on {1}", inimene.Nimi, inimene.Vanus);
            }


            int uusInt = 18;
            minuArvudListis.Insert(3, uusInt);

            foreach (var item in minuArvud)
            {
                Console.WriteLine(item);
            }

            foreach (int yksNumber in minuArvudListis)
            {
                Console.WriteLine(yksNumber);
            }

            Console.ReadLine();
        }
    }
}
