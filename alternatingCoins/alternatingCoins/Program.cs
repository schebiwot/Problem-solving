using System;

namespace alternatingCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] {0,1,1,0 }));
            Console.WriteLine(solution(new int[] {1,0,1,1,0 }));
            Console.WriteLine(solution(new int[] {1,0,1,0 }));
            //Console.WriteLine(solution(new int[] {1,0,1,0,1,1 }));
            Console.WriteLine(solution(new int[] {1,1,1,1 }));
            //Console.WriteLine(solution(new int[] {0,0,0,0,0,0,0,0,0 }));
        }
        public static int solution(int []A)
        {
            int count0 = 0;
            int count1 = 0;
            for (int i = 0; i < A.Length ; i +=2)
            {
               
                if(A[i]==1)
                {

                    count0++;
                

               }
                else
                {
                    count1++;
                }


            }
            for (int j = 1; j < A.Length; j+=2)
            {
                if (A[j] == 1)
                {

                    count1++;


                }
                else
                {
                    count0++;
                }

            }
            int count = Math.Min(count0, count1);
            return count;
        }
    }
}
