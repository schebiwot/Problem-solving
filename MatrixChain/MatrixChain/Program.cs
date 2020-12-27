using System;

namespace MatrixChain
{
    /// <summary>
    /// Have the function MatrixChains(arr) read the array of positive integers stored in arr where every pair will represent an NxM matrix. 
    /// For example: if arr is [1, 2, 3, 4] this means you have a 1x2, 2x3, and a 3x4 matrix. So there are N-1 total matrices where N is the length of the array.
    /// Your goal is to determine the least number of multiplications possible after multiplying all the matrices. Matrix multiplication is associative so (A*B)*C is equal to A*(B*C).
    /// For the above example, let us assume the following letters represent the different matrices: A = 1x2, B = 2x3, and C = 3x4.
    /// Then we can multiply the matrices in the following orders: (AB) C or A(BC). The first ordering requires(1*2*3) = 6 then we multiply this new 1x3 matrix by the 3x4 matrix and we get(1*3*4) = 12.
    /// So in total, this ordering required 6 + 12 = 18 multiplications.Your program should therefore return 18 because the second ordering produces more multiplications.
    /// The input array will contain between 3 and 30 elements
    /// Use the Parameter Testing feature in the box below to test your code with different arguments. 
    /// </summary>
    class Program
    {
        public static int MatrixChains(int[] arr)
        {
            int n = arr.Length;
            //int leastMult=MatrixChainPairs(arr, 1, n - 1);
            int leastMultTraverseMatrix = TraverseMatrix(arr, 1, n - 1);
            // code goes here  
            return leastMultTraverseMatrix;

        }
        public static int TraverseMatrix(int[] arr, int startingPoint, int len)
        {
            if (startingPoint == len)
                return 0;

            int leastMultiple = int.MaxValue;
            //recursively
            //multiply to the right from the index, to extent possible and take the smallest value then
            //multiply to the left from the index, to extent possible and take the smallest value and add the result

            for (int j = startingPoint; j < len; j++)
            {
                int count = TraverseMatrix(arr, startingPoint, j) + TraverseMatrix(arr, j + 1, len) + arr[startingPoint - 1] * arr[j] * arr[len];

                if (count < leastMultiple)
                    leastMultiple = count;

            }
            return leastMultiple;
        }


       
       
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 5, 6, 8 };
            //int[] arr = new int[] { 2,3,4 };-'
            Console.WriteLine(MatrixChains(arr));
        }

    }
  
}
