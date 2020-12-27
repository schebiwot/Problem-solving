using System;
using System.Linq;

namespace Subset
{
  
    class Program
    {
    
        static void Main(string[] args)
        {
            int[] test = { 1, 2, 3, 5 };
            Console.WriteLine(getSubset(test)); 
           
           
         
           
            //subset sum should be 23

        }
        public static bool getSubset(int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            //Console.WriteLine(sum);
            int subsetsum = sum / 2;
            int maxi = arr.Max();

            //get all possible two subsets of the array
            //check if there is any element equal to subsetsum
            //loop through the array checking if sum of the elements of the subsets are equal
            //if they are equal return two subsets
            //else return false

            if (maxi>subsetsum)
            {
                return false;
            }
            if (sum%2!=0)
            {
                return false;
            }

            //int[] test = { 1, 5, 11, 5 };


            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] == subsetsum)
                {
                    return true;
                }

                for (int i = j+1; i < arr.Length; i++)
                {
                    arr[j] +=arr[i];
                   
                    //check if there is any elemnt greator than subset
                   

                    if (arr[j] == subsetsum)
                    {
                        return true;
                    }
                   
                }

            }
            return false;

        }
     
    }
}
