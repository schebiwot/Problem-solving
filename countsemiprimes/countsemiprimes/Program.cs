using System;
using System.Collections.Generic;
using System.Linq;

namespace countsemiprimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(findprimes(100));
            int[] P = { 1, 4, 16 };
            int[] Q = { 26, 10, 20 };
           findsemiprimecount(P,Q);
        }
        public static int[] findsemiprimecount(int [] P, int [] Q)
        {
            int max = Q.Max();
            int product = 0;
           // Console.WriteLine(max);
            List<int> primes = findprimes(max);
            HashSet<int> products = new HashSet<int>();
            HashSet<int> semicount = new HashSet<int>();
            HashSet<int> semiprimes = new HashSet<int>();


            //foreach (var it in primes) 
            //{
            //    Console.Write(it +" ");
            //}
            //traverse through the list geting the products
            for (int i = 0; i < primes.Count-1; i++)
            {
                for (int j = 0; j < primes.Count; j++)
                {
                    product = primes[i] * primes[j];

                    if (product<=max)
                    {
                        products.Add(product);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
           
            int[] productsarr = products.ToArray();
            Array.Sort(productsarr);
          
                for (int i = 0; i < Q.Length; i++)
                {
                    for (int k = 0; k < productsarr.Length; k++)
                    {
                        

                        if (productsarr[k] >= P[i] && productsarr[k] <= Q[i])
                        {
                            semiprimes.Add(productsarr[k]);

                        }
                        
                    }

                    semicount.Add(semiprimes.Count);
                    semiprimes.Clear();
                }
           
            int [] result= semicount.ToArray();

            foreach (var it in result)
            {
                Console.WriteLine(it);
            }
            return result;
            
        }
        public static List<int> findprimes(int n)
        {
            List<int> hs = new List<int>();
                int [] prime = new int[n + 1];

            for (int i = 0; i < n; i++)
                prime[i] = i;

            for (int i = 2; i * i <= n; i++)
            {
                if (prime[i] ==i)
                {
                    // Update all multiples of p 
                    for (int p = i * i; p <= n; p += i)
                        prime[p] = 0;
                }
            }

            // Print all prime numbers 
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == i)
                {
                    hs.Add(i);
                }
                
                   
            }
            
            return hs;
        }
    }
}
//A prime is a positive integer X that has exactly two distinct divisors: 1 and X.The first few prime integers are 2, 3, 5, 7, 11 and 13.

//A semiprime is a natural number that is the product of two (not necessarily distinct) prime numbers.The first few semiprimes are 4, 6, 9, 10, 14, 15, 21, 22, 25, 26.

//You are given two non-empty arrays P and Q, each consisting of M integers.These arrays represent queries about the number of semiprimes within specified ranges.

//Query K requires you to find the number of semiprimes within the range (P[K], Q[K]), where 1 ≤ P[K] ≤ Q[K] ≤ N.

//For example, consider an integer N = 26 and arrays P, Q such that:

//    P[0] = 1    Q[0] = 26
//    P[1] = 4    Q[1] = 10
//    P[2] = 16   Q[2] = 20
//The number of semiprimes within each of these ranges is as follows:

//(1, 26) is 10,
//(4, 10) is 4,
//(16, 20) is 0.
//Write a function:

//class Solution { public int[] solution(int N, int[] P, int[] Q); }

//that, given an integer N and two non-empty arrays P and Q consisting of M integers, returns an array consisting of M elements specifying the consecutive answers to all the queries.

//For example, given an integer N = 26 and arrays P, Q such that:

//    P[0] = 1    Q[0] = 26
//    P[1] = 4    Q[1] = 10
//    P[2] = 16   Q[2] = 20
//the function should return the values[10, 4, 0], as explained above.

//Write an efficient algorithm for the following assumptions: