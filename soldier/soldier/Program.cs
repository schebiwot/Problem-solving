using System;

namespace soldier
{//loop through the array checking if element at j is equal to element at j+1
    //increment count
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 4,3,3,0,2,2,3,0,0 };
            int[] test1 = { 4,4,3,3,1,0 };

            Console.WriteLine(SoldierReport(test1));
        }
        public static int SoldierReport(int[] ranks)
        {
            int count = 0;
            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = i + 1; j < ranks.Length; j++)
                {
                    if (ranks[j] == ranks[i] + 1|| ranks[i]==ranks[j]+1)
                    {
                        count++;
                        break;
                    }
                }

            }
            return count;

        }
    }
}