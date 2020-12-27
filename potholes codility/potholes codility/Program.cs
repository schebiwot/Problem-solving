using System;

namespace potholes_codility
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {0,3,6,5};
            int[] B = {0,3,2,4};
            Console.WriteLine(findnumberofroller(A,B,1));
        }
        public static int findnumberofroller(int[] A, int[] B,int W)
        {
            //sort array A
            Array.Sort(A);

            int max = A.Length;
            int len = 0;
            int count = 1;
            int rolercount = 0;

            for (int i = 0; i < A.Length; i+=count)
            {
               
                len = A[i] + W;
               int res= findElements(A, len);
                Console.WriteLine(res);

                //if (A[i]<len)
                //{
                //    count ++;
                //}
                count++;
                max = max - res;
                count = len + 1;
                if(max==0)
                {
                    break;
                }


         

            }
     


            return rolercount;
        }
        public static int findElements(int[] arr,
                               int key)
        {
            int n = arr.Length;
            int left = arr[0];
            int right = key;

            int count = 0;

            while (left <=right)
            {
                int mid = (right + left) / 2;

                // Check if middle element is 
                // less than or equal to key 
                if (arr[mid] <key)
                {

                    // At least (mid + 1) elements are there 
                    // whose values are less than 
                    // or equal to key 
                    count = mid + 1;
                    left = mid + 1;
                }

                // If key is smaller,  
                // ignore right half 
                else
                    right = mid - 1;
            }
            return count;
        }
    }
   
}
