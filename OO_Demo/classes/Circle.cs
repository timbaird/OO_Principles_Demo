using System;


namespace OO_Demo
{
    public class Circle:Shape
    {
        public double PI { get; } = 3.142;
        public double radius { get; set; }

        public Circle(double newRadius){
            radius = newRadius;
        }

        public double GetPerimeter(){
            return 2 * PI * radius;
        }

        public double GetArea(){
            return PI * radius * radius;
        }
    }
}