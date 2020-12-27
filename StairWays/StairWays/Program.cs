using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] possiblestep = { 1, 3, 5 };
        waysToClimbStairs(4, possiblestep);
    }
    static int waysToClimbStairs(int n, int[] steps)
    {
        //base case
        if (n == 0)
        {
            return 1;
        }

        int[] num = new int[n + 1];
        num[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            int totalways = 0;
            foreach (var j in steps)
            {
                if (i - j >= 0)
                {
                    totalways += num[i - j];

                }


            }
            num[i] = totalways;

        }
        Console.WriteLine(num[n]);
        return num[n];

    }
}