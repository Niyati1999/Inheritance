using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Circle : IShape
    {
        public double radius { get; set; }

        public double area()
        {
            return Math.PI * radius * radius;
        }

        public void draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
