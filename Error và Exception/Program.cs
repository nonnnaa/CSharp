using System;
namespace ErrorAndException
{
    class Program
    {
        static void Main()
        {
            Random random  = new Random();
            int[] numbers = new int[5];
            for(int i=0 ;i<numbers.Length ; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            Console.WriteLine(numbers[numbers.Length]);
            try{
                Console.WriteLine(numbers[numbers.Length]);
            }
            catch(IndexOutOfRangeException ex){
                Console.WriteLine(ex);
            }
        }

    }
}