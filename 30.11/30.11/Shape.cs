using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11
{
    public class Shape
    {
        public int x { get; set;}
        public int y { get; set;}
        public int Height { get; set;}
        public int Width { get; set;}

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }
}
