using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person();
            p1.Id = 51;
            p1.name = "Bhakti";
            p1.printData();
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.name = "Niyati";
            e1.salary = 50000;
            e1.printData();
            Manager m1 = new Manager();
            m1.bonus = 10000;
            
            m1.Id = 2;
            m1.name = "Priya";
            m1.salary = 20000;
            m1.printData();
            Salesman s1 = new Salesman();
            s1.Id = 3;
            s1.name = "Devanshi";
            s1.salary = 15000;
            s1.commission = 8000;
            s1.printData();
            Console.WriteLine(p1.ToString());
            Console.WriteLine(e1.ToString());
            Console.WriteLine(m1.ToString());
            Console.WriteLine(s1.ToString());
            Person p2 = e1;
            Console.WriteLine(p2.ToString());
            Square s = new Square();
            s.length = 2;
            Console.WriteLine(s.area());
            s.draw();

        }
    }
}
