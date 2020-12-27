using System;
using System.Collections;
using System.Collections.Generic;

namespace RemoveBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countImproperBrackets("((()((()"));
        }

        public static int countImproperBrackets(string str)
        {
            //Stack<char> stk = new Stack<char>();
         
   

            int ccount = 0;
            int ocount = 0;
            int diff = 0;

            foreach (var s in str)
            {
                if (s == ')')
                {
                    ccount++;
                }
                else
                {
                    ocount++;
                   
                 

                }
              

            }
            if (ocount > ccount)
            {
                diff = ocount - ccount;
            }
            else
            {
                diff = ccount - ocount;
            }


            return diff;
        }
    }
}

