using System;

class MainClass
{
    /// <summary>
    /// Max Subarray
    //Have the function MaxSubarray(arr) take the array of numbers stored in arr and determine the largest sum that can be formed by any contiguous subarray in the array.For example, if arr is [-2, 5, -1, 7, -3] 
    //then your program should return 11 because the sum is formed by the subarray [5, -1, 7]. 
    //Adding any element before or after this subarray would make the sum smaller.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int MaxSubarray(int[] arr)
    {
        //loop through the array adding the elements 
        //store the sum 
        //if the sum of the current set is greator than the sum of the  maximum sum becomes the greater else sum remains unchanged

        int maxsum = arr[0];
        int currentsum = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            if ((currentsum + arr[i]) < arr[i])
            {
                currentsum = arr[i];
            }
            else
            {
                currentsum += arr[i];
            }

            if (currentsum > maxsum)
            {
                maxsum = currentsum;
            }


        }

        // code goes here  
        return maxsum;

    }

    static void Main()
    {
        int[] test = new int[] { 3, -1, -1, 4, 3, -1 };
//Output: 8
        // keep this function call here
        Console.WriteLine(MaxSubarray(test));
    }

}