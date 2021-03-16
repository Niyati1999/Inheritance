using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Manager:Employee
    {
        public double bonus { get; set; }
        //public void printData()
        //{
        //    Console.WriteLine($"Bonus = {bonus}");
        //}
        public override void printData()
        {
            base.printData();
            Console.WriteLine($"Bonus = {bonus}");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Bonus:{bonus}"; 
        }
    }
}
