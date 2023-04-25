using System;
namespace HCN
{
    public class Rectangle
    {
        double width, height;
        public Rectangle(){}
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimrter()
        {
            return (width + height) / 2;
        }
        public void Display()
        {
            Console.WriteLine("Retangle " + "width = " + width + ", " + "height = " + height);
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            Console.Write("Enter the width : ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            rectangle.Display();
            Console.WriteLine("Perimeter of retangle is " + rectangle.GetPerimrter());
            Console.WriteLine("Area of retangle is " + rectangle.GetArea());
        }
    }
}