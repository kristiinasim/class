using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new Shape();
            shape1.x = 10;
            shape1.y = 20;
            shape1.Width = 100;
            shape1.Height = 50;
            shape1.Draw();

            var circle1 = new Circle();
            circle1.x = 20;
            circle1.y = 10;
            circle1.Width = 100;
            circle1.Height = 300;
            circle1.Draw();

            var rectangle1 = new Rectangle();
            rectangle1.x = 20;
            rectangle1.y = 8;
            rectangle1.Width = 90;
            rectangle1.Height = 60;
            rectangle1.Draw();

            var triangle1 = new Triangle();
            triangle1.x = 22;
            triangle1.y = 8;
            triangle1.Width = 90;
            triangle1.Height = 60;
            triangle1.Draw();

            Console.ReadLine();
        }
    }
}
