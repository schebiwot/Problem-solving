using System;
using System.Collections.Generic;

namespace PairString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "abc", "bca", "dbe" };
           int [] d= findnumber(s);
            foreach (var item in d)
            {
                Console.WriteLine(item);
            }

            
        }
        public static int [] findnumber(string []S)
        {
            int letterindex1 = 0;
            //int letterindex2 = 0;
            int string1index = 0;
            int string2index = 0;

            int[] result = new int[3];

            HashSet<char> store = new HashSet<char>();

            for (int i = 0; i < S.Length; i++)
            {
           
                
                string str = S[i];
                for (int j= 0; i < str.Length; i++)
                     {//abc bca dbe
                            if(!store.Contains(str[j]))
                            {
                                store.Add(str[j]);
                                string1index = i;
                                letterindex1 = j;
                                Console.WriteLine(string1index +" let 1");
                                Console.WriteLine(string2index +" let 2");

                            }
                    else if(store.Contains(str[j])&&letterindex1==j)
                    {
                        
               
                            string2index = i;
                           // letterindex2 = j;

                        result[0] = string1index;
                        result[1] = string2index;
                        result[2] = j;



                        Console.WriteLine(string1index + " let 99");
                        Console.WriteLine(string2index + " let 2");

                        break;
                    }
                    ////get the first occurence of the letter
                    //if (letterindex1 == letterindex2)
                    //{
                    //}
                    else
                    {
                        continue;
                    }

                }
                


            }
          

            return result;
        }
    }
}
