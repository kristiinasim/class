using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parilikkus
{
    class FireWolf : Wolf
    {
        public FireWolf()
        {
            Hitpoints = 100;
            Damage = 70;
        }
        public override int Attack(int hp)
        {
            Console.WriteLine("Firewolf attacked");
            var userHitpoints = base.Attack(hp);
            return userHitpoints;

        }
    }
}
