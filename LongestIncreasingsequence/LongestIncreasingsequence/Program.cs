using System;
using System.Collections.Generic;

namespace LongestIncreasingsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {4,3,2,5,1,1,6};
            Console.WriteLine(LongestSequence(test));
        }


        //Have the function LongestIncreasingSequence(arr) take the array of positive integers stored in arr and return the length of the longest increasing subsequence(LIS).

        //A LIS is a subset of the original list where the numbers are in sorted order, from lowest to highest, and are in increasing order.

        //The sequence does not need to be contiguous or unique, and there can be several different subsequences.For example: if arr is [4, 3, 5, 1, 6] then a possible LIS is [3, 5, 6], and another is [1, 6].

        //For this input, your program should return 3 because that is the length of the longest increasing subsequence.

        //456,356,56,16
        //count=0
        //3,3,6,2
        //count=6;


        public static int LongestSequence(int[] arr)
        {
            //traverse through the array
             int count = 0;
            int storecount = 0;

            List<int> store = new List<int>();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                store.Add(arr[i]);

                for (int j = i+1; j < arr.Length; j++)
                {
                    //compare arr[i] with arr[j]
                    //check if arr[i]>arr[j]
                    //add arr[j] to the list

                    if (arr[j] > arr[i] && arr[j]>arr[j-1])
                    {
                        store.Add(arr[j]);
                        
                        storecount = store.Count;
                       // Console.WriteLine(storecount);
                    }
                  
                }

                count = Math.Max(count, storecount);
                store.Clear();
            }

            return count;


        }



    }

}
