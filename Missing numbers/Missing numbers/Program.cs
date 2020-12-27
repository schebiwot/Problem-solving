using System;

namespace Missing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {2,5 };
            Console.WriteLine(missingNumbers(test));
        }
        public static int missingNumbers(int [] arr)
        {
            int[] newarr = new int[arr.Length];
            int result=0;

            for (int i = 0; i < arr.Length; i++)
                newarr[i] = 1;
            //foreach(int item in arr)
            //{
            //    newarr[item] = 1;
            //    Console.WriteLine(item);
            //}
            for (int j = 1; j < newarr.Length; j++)
            {
                //if (newarr[j] == 0)
                //{
                  //result += j;
                    Console.WriteLine(j);
                //}
            }

            return result;

        }
    }
}
