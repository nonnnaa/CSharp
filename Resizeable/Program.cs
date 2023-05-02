using System;
namespace Shape
{
    class Program
    {
        static void Main(string[] s)
        {
            // Circle circle = new Circle(3.4);
            // circle.Resize(0.3);
            // Console.Write(circle.getRadius());
            // Square square = new Square(0.4);
            // square.setSide(0.5);
            // square.Resize(1.2);
            // Console.Write(square.getSide());
            Rectangle rectangle = new Rectangle(0.3, 0.7);
            rectangle.setLength(1.2);
            rectangle.setWidth(1.3);
            rectangle.Resize(2.1);
            Console.Write(rectangle.ToString());
        }
    }
}