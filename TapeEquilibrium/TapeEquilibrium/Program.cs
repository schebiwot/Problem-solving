using System;
using System.Collections.Generic;


namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3, 1, 2, 4, 3 };
            Console.WriteLine(findEquilibrium(test));
        }
        public static int findEquilibrium(int[] A)
        {
           
            int currentdiff = 0;
            int el = A[0];
            int result = 0;
            List<int> diff = new List<int>();

            for (int i=1;i<A.Length; i++)
            {
              currentdiff =Math.Abs(el - (A.Sum() - el));
                diff.Add(currentdiff);
               
                el += A[i];
                
           result=diff.Min();

            }

            return result;

        }
    }
}
