using System;

namespace DecrementIncrement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int count = 3;
            int result;
            Console.WriteLine($"original counter value is : {count}");
            //increment
            //count++;
            result = count++;
            Console.WriteLine(result);
            
            Console.WriteLine($"Counter after increasing : {count}");
            //decrement
            count--;
            Console.WriteLine($"Counter after decreasing : {count}");
        }
       
    }
}
