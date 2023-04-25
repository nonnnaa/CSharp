using System;
namespace _Fan
{
    class Fan
    {
        public const int slow = 1;
        public const int medium = 2;
        public const int fast = 3;
        private int speed {get; set;} = 1;
        private bool on {get; set;} = false;
        private double radius {get; set;} = 5;
        private string color {get; set;} = "blue";
        public Fan(){ }
        public Fan(bool on, double radius,int speed, string color)
        {
            this.color = color;
            this.radius = radius;
            this.on = on;
            this.speed = speed;
        }
        
        public void Infor()
        {
            Console.WriteLine("========================");
            if(on == true)
            {
                Console.WriteLine("Fan is on");
                Console.WriteLine("Speed : " + speed);
                Console.WriteLine("Color : " + color);
                Console.WriteLine("Radius : " + radius);
            }
            else
            {
                Console.WriteLine("Fan is off");
                Console.WriteLine("Color : " + color);
                Console.WriteLine("Radius : " + radius);
            }
            Console.WriteLine("========================");
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            Fan fan1 = new Fan(true, 10, Fan.fast, "yellow");
            Fan fan2 = new Fan(false, 5, Fan.medium, "blue");
            fan1.Infor();
            fan2.Infor();
        }
    }
}