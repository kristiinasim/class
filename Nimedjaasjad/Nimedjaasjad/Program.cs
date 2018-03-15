using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimedjaasjad
{
    class Program
    {
        static void Main(string[] args)

        {

            var humans1 = new List<Humans>
            {
                new Humans(){Name = "Tont", Age = 67 },
                new Humans(){Name = "Pontu", Age = 42 },
                new Humans(){Name = "Tontu", Age = 15 },
                new Humans(){Name = "Lontu", Age = 44 },
                new Humans(){Name = "Jontu", Age = 26 },
            };

            var inimestequery = from human in humans1

                                orderby humans1.Name
                                where


        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item.Name + " " + item.Age);
        //    }
        //}
        }
    }
}
