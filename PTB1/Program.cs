using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("The solution is all x");
                }
                else
                {
                    Console.WriteLine("No solution");
                }
            }
            else
            {
                Console.WriteLine("The solution is : " + (-b / a));
            }
        }
    }
}