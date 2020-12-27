using System;
using System.Linq;
using System.Collections.Generic;
namespace Subsetsum
{
    class Program
    {
        //check if the sum is odd or even ,if its odd return false because integers are whole numbers
        //else, check if the maximum number in the array is greator than half sum,return false.....no subset can match upto the sum

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] test = { 1, 2, 3, 4, 5, 7, 7, 8, 9 };
            Console.WriteLine(SubsetSum(test));
        }
        public static bool SubsetSum(int[] num)

        {
            int sum = num.Sum();
            int subset = sum / 2;
            int total_subset=0;
            if (sum % 2 != 0)
            {
                return false;
            }

            if (num.Max() >= subset)
            {
                return false;
            }

                // int[] result;
                Console.WriteLine(sum);
                Console.WriteLine(subset);


            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j < num.Length; j++)
                {
                    total_subset +=i + j ;
                    if (total_subset!=subset)
                    {
                        Console.WriteLine($"the sub array is: {total_subset}");
                    }
                }

            }
                return true;
            }

        }
 }
