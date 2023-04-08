using System;
using System.Linq;
namespace Program
{
    class Solve
    {
        static int MinPosition(int[] arr)
        {
            int pos = 0;
            for(int i=1 ; i<arr.Length; i++)
            {
                if(arr[pos] > arr[i])
                {
                    pos = i;
                }
            }
            return pos;
        }
        static void Main(string[] s)
        {
            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            // nhap mang
            Console.WriteLine("Enter array : ");
            int[] arr = new int[n];
            string[] input = Console.ReadLine().Split();
            for(int i=0 ; i<n ; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
            Console.Write("The position of the smallest element in the array is : ");
            Console.WriteLine(MinPosition(arr) + 1);
        }
    }
}