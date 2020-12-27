using System;

namespace gamblesjohn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N, int K)
    {
        if (N == 2)
        {
            return 1;
        }
        if (K == 0)
        {
            return N - 1;
        }
        int remainderN = 0;
        int minimumrounds = 0;
        int result = 0;
        while (K > 0)
        {
            //Console.WriteLine(minimumrounds);

            if (N % 2 == 0)
            {

                if (N <= 2)
                {
                    break;
                }

                remainderN = N - (N / 2);
                minimumrounds++;

                K = K - 1;
                N = remainderN;


            }
            else
            {
                //  Console.WriteLine(minimumrounds);

                minimumrounds++;
                remainderN = N - 1;
                // Console.WriteLine(minimumrounds);


                N = remainderN;
            }
           



        }
        result = minimumrounds + N - 1;
        //Console.WriteLine(minimumrounds+N);

        return result;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}
