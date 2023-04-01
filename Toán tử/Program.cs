using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            Console.Write("Enter width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Area is: " + width  * height);
        }
    }
}