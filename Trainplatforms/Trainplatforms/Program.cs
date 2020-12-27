using System;

namespace Trainplatforms
{
    class Program
    {
        static void Main(string[] args)
                {
            int [] arr = { 900, 940, 950, 1100, 1500, 1800 };
            int[] dept = { 910, 1200, 1120, 1130, 1900, 2000 };
            Console.WriteLine(findPlatformsRequired(arr,dept));
            
           // int n = 6;
        }
        public static int findPlatformsRequired(int[] arrival, int[] departure)
        {
            //sort the arrays
            Array.Sort(arrival);
            Array.Sort(departure);
            int platform = 0;
            int min_platform = 0;
            int i = 1;
            int j = 0;
            int n = arrival.Length;

            while (i< n && j<n)
            {
                if (arrival[i] < departure[j])
                {
                    platform += 1;
                    i ++;
                }
                else if(arrival[i] > departure[j])
                {
                    platform -= 1;
                    j--;
                }
                if (platform > min_platform)
                {
                    min_platform = platform;
                }
                Console.WriteLine(min_platform);

            }


            //traverse tHROUGH THE arrays checking if arrival time is less than departure,
            //then add platform by one, else reduce platform by one
            return 1;
        }

    }

    /*
        * Given two arrays of arrival times and departure times for trains
        * Return the maximum number of platforms needed to support
        * those trains (e.g. max trains at station at one time)
        *
        * Assume the train station is open between 9:00 and 20:00
        * and the minimum stop is 10 minutes (departure - arrival)
        *
        * O(n^2)
        */

}
