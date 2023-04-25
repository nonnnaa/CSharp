using System;
namespace Demo
{
    class Circle
    {
        public const double PI = 3.14;
        public double radius {get; set;}
        public string Color {get; set;}
        public Circle(double radius, string Color)
        {
            this.radius = radius;
            this.Color = Color;
        }
        public double Area()
        {
            return  (PI * (radius * radius)); 
        }
        public override string ToString()
        {
            return "A circle with radius is " 
                    + radius + ", Color is "
                    + Color + ", Area is "
                    + Area();
        }
    }
    class Cylinder : Circle
    {
        public double height;
        public Cylinder(double radius, string Color, double height) : base(radius,Color)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            return (PI * radius * radius * height);
        }
        public override string ToString()
        {
            return "A cylinder with radius is " 
                    + radius + ", Color is "
                    + Color + ", Volume is "
                    + GetVolume();
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            Circle cir = new Circle(5, "red");
            Cylinder cylinder = new Cylinder(5, "blue", 2);
            Console.WriteLine(cir.ToString());
             Console.WriteLine(cylinder.ToString());
        }
    }
}