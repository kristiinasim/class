using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc1 = new Calculation();
            calc1.test();
            var calc2 = new Calculation();
            calc2.test();

            Console.Read();
        }
    }
}
