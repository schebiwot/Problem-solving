using System;

namespace TargetSum
{
    class Program
    {

        //You are given a list of non-negative integers, a1, a2, ..., an, and a target, S.
        //Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.

        //Find out how many ways to assign symbols to make sum of integers equal to target S.
        //Input: nums is [1, 1, 1, 1, 1], S is 3. 
         //Output: 5
        static void Main(string[] args)
        {
            int[] test = { 1, 1, 1, 1, 1 };
            Console.WriteLine(TargetSum(test));
        }
        public static int TargetSum(int []num)
        {
            int sum = 0;
            int total = 0;
              int len = num.Length;
            Console.WriteLine(len);


            return 1;
         }
    }
}

//append + and - signs to every 
//do the sum of the ju