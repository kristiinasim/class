
using System;
using System.Collections.Generic;
using System.Text;

namespace kohvik
{
   class Kohv:User
    {
     public int Rahamaha;
     public string Name;

        public virtual int Ost(int raha)
        {
            Console.WriteLine("Sa ostsid ühe " +Name);
            Console.WriteLine("Kulutasid " +Rahamaha+ " eurot");
            var rahaalles = raha - Rahamaha;
            Console.WriteLine("Sul on nüüd " + rahaalles+ " eurot");

            return raha;
        }
        
    }
}
