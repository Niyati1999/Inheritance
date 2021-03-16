using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual void printData()
        {
            Console.WriteLine($"Id { Id} Name {name}");
        }
        public override string ToString()
        {
            return $"Id {Id} name {name}";
        }
    }
}
