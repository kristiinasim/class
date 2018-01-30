using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parilikkus
{
    class Wolf: Creatures
    {
        //public string Name;
        //public int Hitpoints;
        //public int Damage;
        //public int Defence;

        public Wolf()
        {
            Name = "Tont";
            Hitpoints = 80;
            Damage = 90;
            Defence = 20;
            Ranged = false;
    }
        public override int Attack(int hp)
        {
            
            Console.WriteLine(Name + " is throwing a banana at you!");
            Console.WriteLine(Name + "did " + Damage + " Damage");
            var userHitpoints = hp - 15;
            Console.WriteLine("User has " + hp + " hitpoints");

            return userHitpoints;
        }
        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " is attacking  you!");
            Console.WriteLine(Name + "did " + Damage + 10 + " Damage");
            var userHitpoints = hp - 15 - 10;
            Console.WriteLine("User has " + hp + " hitpoints");

            return userHitpoints;
        }

    }
}
