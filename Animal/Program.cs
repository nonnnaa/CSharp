using System;
namespace _Animal
{
    abstract class Animal
    {
        protected string weight {get; set;}
        protected string height {get; set;}
        public Animal(string weight, string height)
        {
            this.weight = weight;
            this.height = height;
        }

        public abstract void PrintInfor();
    }
    class Cat : Animal
    {
        private string Name {get; set;}
        public Cat(string weight, string height, string Name) : base (height, weight)
        {
            this.Name = Name;
        }
        public override void PrintInfor()
        {
            Console.WriteLine("Weight of this Cat: " + weight);
            Console.WriteLine("Height of this Cat: " + height);
            Console.WriteLine("Name of this Cat: " + Name);
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            Cat _cat = new Cat("10kg", "1.5m", "Tom");
            _cat.PrintInfor();
        }
    }
}