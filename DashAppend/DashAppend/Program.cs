using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DashAppend
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3, 4, 5, 7, 8 };
           appendDashes(test);
        }
        public static void  appendDashes(int[ ] arr)

        {
            string strarr = arr.ToString();

            var ls = new List<string>(strarr);

            Console.WriteLine(ls.Count);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0)
                {
                    ls.Add(arr[i]);
                    


                    Console.WriteLine(ls[i]);
                    //ls.ToString();
                    ls.Insert(i+1,"-");   //append dash to the array
                    //Console.WriteLine(ls);
               

                }
               



            }

            //Console.WriteLine(string.Join(",", ls));
            

            // return ;
        }
    }
}
