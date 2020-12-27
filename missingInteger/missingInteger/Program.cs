using System;

using System.Collections.Generic;
namespace missingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 5, 9, 3, 2, 5, 6, 7 };

            solution(test);
        }

        public static int[] solution(int[] A)
        {
            Array.Sort(A);
            List<int> B = new List<int>();
            // int [] B= new int[A[A.Length]];
            for (int i = 0; i < A[A.Length-1]; i++)
            {
                B.Add(i);
            }
            B.ToArray();
            HashSet<int> hs1 = new HashSet<int>(A);


            hs1.SymmetricExceptWith(B);
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }

            return A;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }
}