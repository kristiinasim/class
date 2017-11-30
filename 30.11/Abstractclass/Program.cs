using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new square(4);
            Console.WriteLine("Ruudu pindala on " + square.Area());
            Console.ReadLine();
        }




    }
}
