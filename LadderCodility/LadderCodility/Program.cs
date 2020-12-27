using System;

namespace LadderCodility
{
   

    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] A = { 4, 4, 50000, 5, 1 };
            int[] B = { 3, 2, 4, 3, 1 };
            int[] result = findWays(A, B);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

        }
        public static int[] findWays(int[] A, int[] B)
        {
            int n = A.Length;
            int[] fib = new int[n];
            // fib[0]=1;
            // fib[1]=1;
            for (int i = 0; i < n; i++)
            {

                int stepresult = findStep(A[i],B[i]);
                //Console.WriteLine(stepresult);
                //Console.WriteLine(" ............");
               
                fib[i] = stepresult;
            }
            // foreach(var r in fib)
            // {
            //   Console.WriteLine(r);
            // }
            return fib;
        }
        public static int findStep(int n,int r)
        {
            //memoization

            int result = 0;
            if (n == 1 || n == 0)
                return 1;
            else if (n == 2)
                return 2;

            else
                
                    result = (findStep(n - 2,r) + findStep(n - 1,r) )% (int)Math.Pow(2, r); 
                
                
            return result;

        }

    }
}
