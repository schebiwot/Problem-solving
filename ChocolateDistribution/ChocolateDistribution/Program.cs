using System;

namespace ChocolateDistribution
{
    class Program
    {
        static int findMinDiff(int[] arr, int n,
                                    int m)
        {

            // if there are no chocolates or  
            // number of students is 0 
            if (m == 0 || n == 0)
                return 0;

            // Sort the given packets 
            Array.Sort(arr);
        


            // Number of students cannot be 
            // more than number of packets 
            if (n < m)
                return -1;

            // Largest number of chocolates 
            int min_diff = int.MaxValue;

            // Find the subarray of size m  
            // such that difference between  
            // last (maximum in case of  
            // sorted) and first (minimum in 
            // case of sorted) elements of  
            // subarray is minimum. 
            Console.WriteLine($"the sorted array is {arr}");
            for (int i = 0; i + m - 1 < n; i++)
            {
                int diff = arr[i + m - 1] - arr[i];
                // Console.WriteLine(arr[i + m - 1]);

                if (diff < min_diff)
                    min_diff = diff;
            }

            return min_diff;
        }

        /* Driver program to test above function */
        public static void Main()
        {
            int[] arr = {12, 4, 7, 9, 2, 23,
                    25, 41, 30, 40, 28,
                    42, 30, 44, 48, 43,
                                    50};

            int m = 7; // Number of students 

            int n = arr.Length;

            Console.WriteLine("Minimum difference is "
                       + findMinDiff(arr, n, m));

        }
    }
}


