using System;

namespace Labb_3_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing Circle = new Circle();
            double result = Circle.Area();
            Console.WriteLine(result);

            Drawing Square = new Square();
            double resultSquare = Square.Area();
            Console.WriteLine(resultSquare);

            Drawing Rectangle = new Rectangle();
            double resultRectangle = Rectangle.Area();
            Console.WriteLine(resultRectangle);
        }
    }
}
