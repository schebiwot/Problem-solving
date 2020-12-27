using System;
using System.Collections.Generic;

namespace ChocalatesEaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PossibleEatCholates2(10,4));
        }
        public static int PossibleEatCholates(int N,int M)
        {

            //0 performance
            //50 score
            //100 correctness

            int count = 0;
            int i = 0;
            var stk = new HashSet<int>();
            for (int x=0; x< N; x++)
            {
                stk.Add(x);
            }
        
            while (stk.Contains(i))
            {

                count++;

                stk.Remove(i);
                i =( i + M) % N;
            


            }

            return count;
        }
        public static int PossibleEatCholates2(int N, int M)
        {
            //score 75
            //performance 50
            //correctness 100
            //failed large and extreme large testcases
            int i = 0;
            var stk = new HashSet<int>();

            while (i< N)
            {
                if (!stk.Contains(i))
                {
                    stk.Add(i);
                }
                else
                {
                    break;
                }

                i = (i + M) % N;
            }
            return stk.Count;
        }
    }
}
