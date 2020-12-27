using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
           findPrime(9) ;
        }
        /*
 * C# Program to Check Whether the Given Number is a Prime number if so then 
 * Display its Largest Factor
 */

            public static void findPrime(int num)
            {
            
                int count=0;
            
                for (int i = 1; i <= num ; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("Entered Number is a Prime Number and the Largest Factor is {0}", num);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
         
            }
        }
    }

