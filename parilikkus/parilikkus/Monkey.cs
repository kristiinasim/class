using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parilikkus
{
    class Monkey: Creatures
    {
        //public string Name;
        //public int Hitpoints;
        //public int Damage;
        //public int Defence;
        //public bool Ranged;

        public Monkey()
        {
            Name = "Monkey";
            Hitpoints = 80;
            Damage = 90;
            Defence = 20;
            Ranged = true;

        }
        ////public int ThrowBanana(int hp)
        //{
        //    Console.WriteLine(Name +" is throwing a banana at you!");
        //    Console.WriteLine(Name + "did " + Damage + " Damage");
        //    var userHitpoints = hp - 15;
        //    Console.WriteLine("User has " + hp + " hitpoints");

        //    return userHitpoints;

        
        public override int SpecialAttack(int hp)
        {
            Console.WriteLine(Name + " is throwing bananas at you!");
            Console.WriteLine(Name + "did " + Damage + 10 + " Damage");
            var userHitpoints = hp - 15 - 10;
            Console.WriteLine("User has " + hp + " hitpoints");

            return userHitpoints;
        }
    }
}
