using System;
//append each psign to each integer and find the sum, if the sum is equal to S the youve found the ways

namespace Target__Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TargetSum(34,3,0));
        }
        public static int  TargetSum(int num,int sum, int total){
            string n= num.ToString();
            sum=0;
            total=0;
           int len=n.Length;
            Console.WriteLine(  len  );

return 1;
        }
    }
}


// You are given a list of non-negative integers, a1, a2, ..., an, and a target, S.
// Now you have 2 symbols + and -. For each integer, you should choose one from + and - as its new symbol.

// Find out how many ways to assign symbols to make sum of integers equal to target S.