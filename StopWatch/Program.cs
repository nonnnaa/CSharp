using System;
namespace _StopWatch
{
    class StopWatch
    {
        private DateTime startTime{get; set;}
        private DateTime endTime{get; set;}
        public StopWatch()
        {
            startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void End()
        {
            endTime = DateTime.Now;
        }
        public double GetElapsedTime()
        {
            return (double)(endTime - startTime).TotalMilliseconds;
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            int[] arr = new int[100000];
            Random random = new Random();
            for(int i=0 ;i<100000 ; i++)
            {
                arr[i] = random.Next(0, 100000);
            }
            StopWatch watch = new StopWatch();
            watch.Start();
            SelectionSort(arr);
            watch.End();
            Console.Write(watch.GetElapsedTime());
        }
        static void SelectionSort(int[] arr)
        {
            for(int i=0 ;i<arr.Length-1 ; i++)
            {
                int min_pos = i;
                for(int j = i + 1 ; j<arr.Length ; j++)
                {
                    if(arr[j] < arr[min_pos])
                    {
                        min_pos = j;
                    }
                }
                swap(ref arr[i],ref arr[min_pos]);
            }
        }
        static void swap(ref int a,ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}