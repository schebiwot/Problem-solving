using System;
using System.Collections.Generic;
class MainClass
{

    public static int LongestConsecutive(int[] arr)
    {
        int n = 0;
        int count = 0;

        if (arr.Length < 2)
        {
            return 1;
        }
        //sort the array
        //check if consecutive numbers differ by 1
        //if they differ by one addto s string 
        //compare the lengths and take the maximum

        // 11,6,6,5,7,10,1,2,3,12,9,8
        // 5,6,7,8,9,10,11,12=9

        Array.Sort(arr);

        HashSet<int> store = new HashSet<int>();



        for (int i = 0; i < arr.Length - 1; i++)
        {


            if (arr[i + 1] - arr[i] == 1 || arr[i + 1] == arr[i])
            {

                store.Add(arr[i]);

                store.Add(arr[i + 1]);

                n = store.Count;


            }
            else
            {

                store.Clear();

            }
            count = Math.Max(count, n);

        }

        return count;

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(LongestConsecutive(Console.ReadLine()));
    }

}

Have the function LongestConsecutive(arr) take the array of positive integers stored in arr and return the length of the longest consecutive subsequence(LCS). An LCS is a subset of the original list where the numbers are in sorted order, from lowest to highest, and are in a consecutive, increasing order.The sequence does not need to be contiguous and there can be several different subsequences.For example: if arr is [4, 3, 8, 1, 2, 6, 100, 9] then a few consecutive sequences are[1, 2, 3, 4], and[8, 9]. For this input, your program should return 4 because that is the length of the longest consecutive subsequence.