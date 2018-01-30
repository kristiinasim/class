using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parilikkus
{
    class Ghost : Creatures
    {
        public Ghost()
        {
            Name = "Ghost";
            Hitpoints = 70;
            Damage = 80;
            Defence = 70;
            Ranged = false;
        }
        public override int Attack(int hp)
        {

            Console.WriteLine(Name + " is using black magic on you!");
            Console.WriteLine(Name + " did " + Damage + " Damage");
            var userHitpoints = hp - 15;
            Console.WriteLine("User has " + hp + " hitpoints");

            return userHitpoints;
        }
        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " is attacking  you!");
            Console.WriteLine(Name + " did " + Damage + 10 + " Damage");
            var userHitpoints = hp - 15 - 10;
            Console.WriteLine("User has " + hp + " hitpoints");

            return userHitpoints;
        }
    }
}
