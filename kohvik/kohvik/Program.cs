using System;

namespace kohvik
{
    class Program
    {
        private static int raha;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Sul on 20 eurot. Mida soovite tellida?");
            Console.WriteLine("Valikud on: Must kohv, cappucino, latte või kook.");
            var valik = Console.ReadLine();
           
         
            if (valik == "latte")
            {
               
                var latte = new Latte();
                latte.Ost(raha);
               
            }

        }
    }
}
