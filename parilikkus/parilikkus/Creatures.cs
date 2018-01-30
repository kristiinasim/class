using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parilikkus
{
    abstract class Creatures
    {
        //protected int, etc
        protected string Name;
        protected int Damage;
        protected int Defence;
        protected bool Ranged;
        protected int Hitpoints;

        public virtual int Attack(int hp)
            //virtual and override int
        {
            Console.WriteLine(Name + " is attacking  you!");
            Console.WriteLine(Name + "did " + Damage + " Damage");
            var userHitpoints = hp - 15;
            Console.WriteLine("User has " + hp + " hitpoints");

            return userHitpoints;

        }
        public abstract int SpecialAttack(int hp);
  
        }
    }

    

