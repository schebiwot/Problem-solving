using System;

namespace MinimunDeletions
{
  

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(solution("BAABB"));
        }
        public static int solution(string S)
        {

            int n = S.Length;

            if (n > 100000)
            {
                return 0;
            }

            int countA = 0;
            int countB = 0;
            //BAAABAB

            int Remove = 0;

            for (int i = 0; i < n; i++)
            {
                char ch = S[i];
                if (ch == 'A')
                {
                    //increment count of A
                    countA++;
                    //Console.WriteLine(countB + "BBBB");
                    //Console.WriteLine(countA + "AAA");

                    if (countB > Remove)
                    {
                        Remove++;
                        Console.WriteLine(Remove + "remove");
                    }

                }
                else
                {
                    countB++;
                    if (countA == 0)
                    {
                        Remove++;
                        // Console.WriteLine(Remove);
                        //Console.WriteLine(Remove + "remove");

                    }

                }

            }
            int min = Math.Min(countB, Remove);

            return Math.Min(min, countA);
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }

}
