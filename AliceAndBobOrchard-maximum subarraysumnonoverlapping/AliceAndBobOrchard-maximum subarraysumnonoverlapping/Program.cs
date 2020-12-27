using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(findmaxsum(new int[] { 6, 1, 4, 6, 3, 2, 7, 4 }, 3, 2));
    }
    public static int findmaxsum(int[] A, int L, int M)
    {
        return Math.Max(help(A, L, M), help(A, M, L));
    }
    public static int help(int[] A, int L, int M)
    {
        int n = A.Length;
        //int sMMax = 0;
        int maxSum = 0;
        //int sL = 0, sM = 0;
        int Lsum = 0;
        int Msum = 0;

        int result = 0;
        for (int i = 0; i < n; i++)
        {
            // sL += A[i];
            Lsum += A[i];
            Console.WriteLine(Lsum + " the left sum  at {0} A[i]", i);

            if (i >= L)
            {
                Lsum -= A[i - L];
                Console.WriteLine(Lsum + " the left sum  at {0} A[i-L", i);
                Msum += A[i - L];
                Console.WriteLine(Msum + "  mSum");
            }
            if (i - L >= M)
            {
                Msum -= A[i - L - M];
            }
            maxSum = Math.Max(maxSum, Msum);
            result = Math.Max(result, Lsum + maxSum);
        }

        return result;
    }
}
