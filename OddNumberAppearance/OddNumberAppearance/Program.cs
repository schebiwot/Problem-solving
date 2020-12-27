using System;
using System.Collections.Generic;


namespace OddNumberAppearance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {9,3,9,3,9};
            Console.WriteLine(solution(test));
        }

        //traverse through the array checking if each element is in the list, if not add if its there remove
      
            public static string solution(int[] A)
            {
            
                List<int> ht = new List<int>();
          

            for (int i = 0; i < A.Length; i++)
            {
         
                if (!ht.Contains(A[i]))
                {

                    ht.Add(A[i]);
                }
                else
                {
                    ht.Remove(A[i]);
                }
            }
            string news = "";
            foreach (int i in ht)
            {
                news += i;
                news +=",";
       
                Console.WriteLine(i);
            }

            return news.Substring(0, news.Length-1);


               
            }
        }

    }

