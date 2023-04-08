using System;
namespace Program
{
    class Solve
    {
        static double FahrenheitToCelsius(double F)
        {
            return (5.0 / 9) * (F - 32);
        }
        static double CelsiusToFahrenheit(double C)
        {
            return (C * 9 / 5.0) + 32;
        }
        static void Main()
        {
            bool check = true;
            while(check)
            {
                Console.WriteLine("---------------MENU---------------");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit ");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.Write("----------END PROGRAM-----------");
                        check = false;
                        break;
                    case 1:
                        Console.Write("Enter F : ");
                        double F = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(F + " degrees Fahrenheit equals " + FahrenheitToCelsius(F) + " degrees Celsius.");
                        break;
                    case 2:
                        Console.Write("Enter C : ");
                        double C = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(C + " degrees Celsius equals " + CelsiusToFahrenheit(C) + " degrees Fahrenheit.");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}