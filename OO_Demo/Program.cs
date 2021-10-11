using System;

namespace OO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Square s = new Square(5);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());
            
            Circle c = new Circle(5);
            Console.WriteLine(c.GetArea());
            Console.WriteLine(c.GetPerimeter());     

            Console.WriteLine("Test");
            Console.ReadKey();
        }
    }
}
