using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage 1. number:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage 2. number:");
            double  b = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            double x = calculator.AddTwoNumbers(a, b);
            Console.WriteLine(x);




        }
    }
}
