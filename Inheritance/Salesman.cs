using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Salesman:Employee
    {
        public double commission { get; set; }
        public override void printData()
        {
            base.printData();
            Console.WriteLine($"Commission = {commission}");
        }
        public override string ToString()
        {
            return $"{base.ToString()} commission: {commission}"; 
        }
    }
}
