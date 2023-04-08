using System;
using System.Linq;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            // nhap so hang
            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            // nhap so cot
            Console.Write("Enter m : ");
            int m = Int32.Parse(Console.ReadLine());
            // nhap mang
            Console.WriteLine("Enter array : ");
            int[,] arr = new int[n,m];
            for(int i=0 ; i<n ; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j=0 ; j<m ; j++)
                {
                    arr[i,j] = Convert.ToInt32(input[j]);
                }
            }
            //Console.WriteLine(arr.Max());
            int ans = int.MinValue;
            for(int i=0 ; i<n ; i++)
            {
                for(int j=0 ; j<m ; j++)
                {
                    ans = Math.Max(ans, arr[i,j]);
                }
            }
            Console.WriteLine("Max of array is : " + ans);
        }
    }
}