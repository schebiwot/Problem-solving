using System;

namespace MoveZerosToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3,0,4,0,5,0,3,0,0,6,7,0,2 };
            moveZero(test);
         //   Console.WriteLine(moveZero(test));
         foreach (var t in test)
            {
                Console.WriteLine(t);
            }

        }
        public static int [] moveZero(int [] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]==0)
                {
                    MoveToEnd(nums, i);
                }
            }
            return nums;
        }

        public static void MoveToEnd(int []nums,int index )
        {
            for (int i = index; i < nums.Length-1; i++)
            {
                int temp = nums[i];
                nums[i] = nums[i + 1];
                nums[i + 1] = temp;
            }

        }
    }
}
