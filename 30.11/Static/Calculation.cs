using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Calculation
    {
        public static int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine(i);


        }
    }
}
