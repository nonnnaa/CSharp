using System;
namespace Program
{
    
    class Solve
    {
        static void Delete_arr(int[] a, int x)
        {
            int i = 0;
            while(i < a.Length && a[i] != x)
            {
                i++;
            }
            if(i == a.Length)
            {
                Console.WriteLine("Not find x in array");
            }
            else
            {
                for(int j=i; j<a.Length-1 ; j++)
                {
                    a[j] = a[j+1];
                }
            }
        }
        static void Main()
        {
            // nhap mang
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split();
            for(int i=0 ; i<n ; i++)
            {
                a[i] = Convert.ToInt32(input[i]);
            }
            // nhap phan tu can xoa
            int x = Convert.ToInt32(Console.ReadLine());
            Delete_arr(a, x);
            for(int i=0 ; i<n-1 ; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}