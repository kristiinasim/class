using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle");
            base.Draw(); //kutsub circle draw esile
        }
    }
}
