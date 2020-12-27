using System;
using System.Collections.Generic;
using System.Linq;

namespace offlineIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "5", "4", "6", "E", "1", "7", "E", "E", "3", "2" };
            Console.WriteLine(findMinimum(test));
        }
      

        public static string findMinimum(string []strArr)
        {
            List<string> storeMinimum = new List<string>();
            List<string> storeElements = new List<string>();

            for (int i = 0; i < strArr.Length; i++)
            {
                
                if (strArr[i]=="E")
                {
                   var min= storeElements.Min();
                    storeMinimum.Add(min);
                    storeElements.Remove(min);


                }
                else
                {
                    storeElements.Add(strArr[i]);     
                }
                
            }
            var result = string.Join(",", storeMinimum);

            return result;
        }
    }
}
