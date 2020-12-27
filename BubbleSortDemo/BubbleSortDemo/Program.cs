using System;

namespace BubbleSortDemo
{


    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 5, 1, 4, 2, 8 };
        int[] ans = Bubbling(arr1);
        foreach (var item in ans)
        {
            Console.Write(item);
        }
    }
    public static int[] Bubbling(int[] arr)
    {
        //size = arr.Length;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }

}
