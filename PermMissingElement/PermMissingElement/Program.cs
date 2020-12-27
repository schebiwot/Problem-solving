using System;

namespace PermMissingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 5 };
            Console.WriteLine(findMissingNumber(test));
        }
        public static int findMissingNumber(int [] nums)
        {
            int sum = 0;
            int currentsum = 0;
            int missing = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentsum += nums[i];
            }
            Array.Sort(nums);
            int last = nums[nums.Length - 1];
          
            int[] a = new int[last];
            for (int j = 0; j <=last; j++)
            {
                sum += j;
              
            }
            missing = sum - currentsum;

            return missing;
                    }
    }
}
  