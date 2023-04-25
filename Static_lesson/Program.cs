using System;
namespace Static_lesson
{
    class Student
    {
        private int number;
        private string name;
        private static string college = "PTIT";

        public Student(int x, string s)
        {
            number = x;
            name = s;
        }
        public void Display()
        {
            Console.WriteLine(number + " " + name + " " + college);
        }
        public static void Change()
        {
            college = "CodeGym";
        }
    }
    class TestStaticMethod
    {
        public static void Test()
        {
             Student.Change();
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            TestStaticMethod.Test();
            Student s1 = new Student(111, "Hoang");
            s1.Display();
        }
    }
}