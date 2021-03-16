using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Employee:Person
    {
        
        public double salary { get; set; }

        public virtual void printData()
        {
            base.printData();
            Console.WriteLine($"salary ={salary}");
        }
        public override string ToString()
        {
            
            return $"{base.ToString()} salary:{salary}"; 
        }
    }
}
