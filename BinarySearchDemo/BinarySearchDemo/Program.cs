using System;

namespace BinarySearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3, 5, 8, 9, 11, 16, 33 };
            Console.WriteLine(BinarySearch(test,16));
        }
        public static int BinarySearch(int [] arr, int searchElement)
        {
            int start = 0;
            int end = arr.Length - 1;
           

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == searchElement)
                {
                    return mid;
                }
                else if (arr[mid] < searchElement)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
