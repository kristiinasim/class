﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._11
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
            base.Draw(); //kutsub rectangle draw esile
        }
    }
}