using System;

namespace minimummoves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findMoves("baaaa"));
            Console.WriteLine(findMoves("baabab"));
            Console.WriteLine(findMoves("baaabbaabbba"));
        }
       public static int findMoves(string S)
        {

            int count = 0;
            int lettercount = 1;
            int n = S.Length;
            if(n<3)
            {
                return count;
            }

            for (int i = 1; i < n-1; i++)
            {
                if(S[i]==S[i+1])
                {
                    lettercount++;

                    if(lettercount==3)
                    {
                        count++;
                    }

                }
                else
                {
                    lettercount = 1;
                }
               
            }
            return count;
        }
    }
}
