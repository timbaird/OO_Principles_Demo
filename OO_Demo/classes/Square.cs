using System;

namespace OO_Demo
{
    public class Square:Quadrilateral, IShapeData
    {
        public Square(double sideLength){
            Side1 = sideLength;
            Side2 = sideLength;
            Side3 = sideLength;
            Side4 = sideLength;
        }

        public double GetPerimeter(){
            return 4 * Side1;
        }

        public double GetArea(){
            return Side1 * Side1;
        }
    }
}