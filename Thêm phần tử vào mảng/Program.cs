using System;
namespace Program
{
    class Solve
    {
        static void Main(string[] s)
        {
            Console.Write("Enter n : ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            Console.Write("Enter array : ");
            string[] input = Console.ReadLine().Split();
            for(int i=0 ; i<n ; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }
            arr[n] = 0;
            Console.Write("Enter x : ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x'position : ");
            int position = Int32.Parse(Console.ReadLine());
            if(position < 1 && position > n + 1)
            {
                Console.WriteLine("Cannot insert x into array.");
                return;
            }
            else
            {
                int j = n ;
                while(j > position - 1)
                {
                    arr[j] = arr[j - 1];
                    --j;
                }
                arr[position - 1] = x;
            }
            Console.Write("Array after inserting x is : ");
            for(int i=0 ;i<=n ; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}