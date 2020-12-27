using System;

namespace LinearSearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {10,39,44,55,88,23,22 };
           LinearSearch(numbers,04);
        }
        public static void LinearSearch(int [] numbers,int searchElement)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (searchElement==numbers[i])
                {
                    Console.WriteLine($"the position of the element to be searched is: {i}");
                }
               
            }
             
                Console.WriteLine("the element doesnt exist");
        
        }
    }
}
