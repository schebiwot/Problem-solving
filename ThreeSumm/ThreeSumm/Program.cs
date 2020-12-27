using System;
using System.Collections.Generic;

namespace ThreeSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 4, 45, 6, 10, 8 };
            Console.WriteLine(findCombination(test,22));
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static string findCombination(int [] nums,int sum)
        {
            HashSet<int> storenum = new HashSet<int>();
            string result = "";
            
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                int currentsum = sum - nums[i];

                storenum.Add(nums[i]);

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (storenum.Contains(currentsum - nums[j]))
                    {
                        result += nums[i].ToString();
                        //Console.WriteLine(result);
                        result += nums[j].ToString();
                       // Console.WriteLine(result);
                        result += (currentsum - nums[j]).ToString();
                        result = string.Join(",", result);
                    }
                    storenum.Add(nums[j]);
                }

            }

            return result;
        }
    }
}
