using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Square s1 = new Square() { length = 3 };
            //s1.length = 2;
            double a = s1.area();
            Console.WriteLine($"Area {a}");
            s1.draw();
            s1.printLength();
            Console.WriteLine("CIRCLE !!!");
            Circle c1 = new Circle() { radius = 1 };
            double ans = c1.area();
            Console.WriteLine($"Area {ans}");
            c1.draw();
            IShape n;
            n = s1;
            n.draw();
            var objtype = typeof(Circle);
            var result = objtype.IsInstanceOfType(n);
            Console.WriteLine(result);
            Square s2 = n as Square;
            s2.printLength();
            n = c1;
            n.draw();


        }
    }
}
