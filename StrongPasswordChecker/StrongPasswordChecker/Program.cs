using System;
using System.Collections.Generic;
using System.Linq;

namespace StrongPasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countMinimumChanges("todaeee"));  
        }
        static int countMinimumChanges(string s)

        {
            int countChanges = 0;
            int len = s.Length;

            bool  capitalresult;
            bool lowerresult;
            bool digitresult;

            int capitalcount=0;
            int lowercount = 0;
            int digitcount = 0;
            
 

            if (len>=6 && len<=20)
            {

             

                for (int i = 0; i < s.Length; i++)
                {
                    //Console.WriteLine(s[i]);

                    capitalresult= char.IsUpper(s[i]);
                    lowerresult = char.IsLower(s[i]);
                    digitresult = char.IsDigit(s[i]);

                 

                    if (capitalresult==true)
                    {
                        capitalcount ++;

                    }

                    if (lowerresult == true)
                    {
                        lowercount ++;

                    }
                    if (digitresult == true)
                    {
                        digitcount ++;

                    }

                    if (capitalcount  < 1)
                    {
                        countChanges++;
                    }

                    if (lowercount < 1)
                    {
                        countChanges ++;
                    }

                    if (digitcount < 1)
                    {
                        countChanges++;
                    }
                    if (s[i] == s[i + 1] && s[i + 1] == s[i + 2])
                    {
                        countChanges++;
                    }

                }
            }
            else if(len<6 )
            {
                countChanges += (6 - len);
            }
            else
            {
                countChanges += (len - 20);
            }
            //if (countChanges == 0)
            //{
            //    return 0;
            //} 
            return countChanges;
        }
        static void changesCount()
        {
            if (((countUpper < 1 && countLower < 1) || (countUpper < 1 && countDigit < 1)) || (countLower < 1 && countDigit < 1))
            {

            }
        }
    }
}
