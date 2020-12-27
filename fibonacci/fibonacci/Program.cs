using System;
using System.Collections.Generic;

namespace fibonacci
{
    //Write a function that computes the list of the first 100 Fibonacci numbers.
    //    The first two Fibonacci numbers are 1 and 1. The n+1-st Fibonacci number can be computed by adding the n-th and the n-1-th Fibonacci number.
    //    The first few are therefore 1, 1, 1+1=2, 1+2=3, 2+3=5, 3+5=8.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findFibonacci(100));
        }
        public static int findFibonacci(int n)
        {

            int fib = 0;
            int fib1 = 1;


            // List<int> store = new List<int>();
            int nextelement = 0;

            //store.Add(fib1);
            for (int i = 1; i <= n; i++)
            {
                nextelement = fib + fib1;

                fib = fib1;

                fib1 = nextelement;

                //store.Add(nextelement);

                Console.WriteLine(nextelement);

            }

            return nextelement;
        }
           

        
    }
}
