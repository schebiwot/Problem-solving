using System;
using System.Collections;
//using System.Collections.Generic.IEnumerable;
using System.Linq;

namespace MergeSortEliminateDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 4, 22, 5, 7, 34, 12 };
            int[] test2 = { 86, 22, 3, 45, 24, 99 };
            findSortedArray(test1, test2);
        }

        //copy two arrays,sort and eliminate duplicates
        public static int [] findSortedArray(int [] A, int [] B)
        {
            //merge the two arrays
            //sort the arrays
            //remove duplicates
            // traverse through the array,
            //add array elements in a queue if it does not exist
            int len = A.Length;// + B.Length;
            int[] C= new int [len];
            int pos = A.Length;
            /*
                        for (int i = 0; i < A.Length; i++)
                        {
                            C[i] = 1;
                        }
                        for (int i = 0; i < B.Length; i++)
                        {

                            C[pos] = B[i];
                            pos ++;
                        } */
            C = A.Concat(B).ToArray();
            
           // Array.Copy(A,C, len);
            Array.Sort(C);
          

            Queue queuearr = new Queue();
          
            for (int i = 0; i < C.Length; i++)
            {
                if ( !queuearr.Contains(C[i]))
                {
                    //enqueue the queue
                    queuearr.Enqueue(C[i]);
                }
            }
            while (queuearr.Count>0)
            {
                Console.WriteLine(queuearr.Dequeue());
               
            }



           

            return C;
        }
    }
}
