using System;
using System.Linq;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            // nhap do lon ma tran cap n
            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            // nhap mang
            Console.WriteLine("Enter array : ");
            int[,] arr = new int[n,n];
            for(int i=0 ; i<n ; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j=0 ; j<n ; j++)
                {
                    arr[i,j] = Convert.ToInt32(input[j]);
                }
            }
            int ans = 0;
            for(int i=0 ; i<n ; i++)
            {
               ans += arr[i,i];
            }
            Console.WriteLine("The sum of the elements on the main diagonal of the matrix is : " + ans);
        }
    }
}