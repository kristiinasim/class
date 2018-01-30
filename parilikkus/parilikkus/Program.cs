using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parilikkus
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängija loomine
            var hp = 100;
            //Loome vaenlase
            var enemyWolf = new Wolf();
            hp = enemyWolf.Attack(hp);

            //Monkey:
            var Monkey1 = new Monkey();
            hp = Monkey1.Attack(hp);

            var firewolf = new FireWolf();
            firewolf.Attack(hp);

            Console.ReadLine();
            



            
        }
    }
}
