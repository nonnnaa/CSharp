using System;
using System.Linq;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0 ; i<n ; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            //Console.WriteLine(arr.Max());
            int ans = int.MinValue;
            for(int i=0 ; i<n ; i++)
            {
                ans = Math.Max(ans, arr[i]);
            }
            Console.WriteLine("Max of array is : " + ans);
        }
    }
}