using System;
using System.Collections.Generic;

namespace Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(divisors(5));
        }

        //if a is adivisor of n, then n/a is also a divisor of n there one of the divisors is less than sqrt of n
        public static int divisors(int n)
        {
            int result = 0;
            int i = 1;

            if (n == 1)
            {
                return 1;
            }

            while (i*i<n)
            {
                if (n % i == 0)
                {
                   
                    result += 2;
                   

                }
                i++;
                if (i * i == n)
                {
                    result += 1;
              
                }
               
            }
           
            return result;
        }
    }
}
