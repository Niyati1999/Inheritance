using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Square : Shape
    {
        public int length { get; set; }
        public override int area()
        {
            return length * length;
        }

        public override void draw()
        {
            Console.WriteLine("draw square");
        }
    }
}
