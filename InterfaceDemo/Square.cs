using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Square : IShape
    {
        public double length { get; set; }
        public double area()
        {
            return length * length;
        }

        public void draw()
        {
            Console.WriteLine("Draw Square");
        }
        public void printLength()
        {
            Console.WriteLine($"length = {length}");
        }
    }
}
