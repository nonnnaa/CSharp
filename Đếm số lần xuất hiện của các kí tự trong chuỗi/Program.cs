using System;
using System.Linq;
namespace Program
{
    class Solve
    {
        static void CountChar(string s)
        {
            int[] a = new int[127];
            for(int i=0 ; i<s.Length ; i++)
            {
                a[Convert.ToInt32(s[i])]++;
            }
            for(int i=0 ; i<127 ;i++)
            {
                if(a[i] > 0)
                {
                    Console.WriteLine(Convert.ToChar(i) + " : " + a[i]);
                }
            }
        }
        static void Main()
        {
            string s = (Console.ReadLine());
            CountChar(s);
        }
    }
}