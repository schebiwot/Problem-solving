using System;
using System.Linq;

namespace Alphabet
{
 
   
    //Program to take a string,return it in reversed alphabetical order
    class MainClass
    {

        public static string ReverseAlphabet(string str)
        {
            //convert the string to charArray
            //sort the array in alphabetical order
            //reverse the array
            //Convert back to string


            char[] strArr = str.ToCharArray();
            Array.Sort(strArr);

            //char []ArrResult=Array.Sort(strArr);
            string result = new string(strArr);
            Console.WriteLine(result);
            //char [] ArrResult=result.ToCharArray();
            foreach (char c in strArr)
            {

                Console.WriteLine(c);
            }

            int size = result.Length - 1;
            string reverse = "";

            while (size >= 0)
            {
                reverse = reverse + result[size];
                size--;


            }
            return reverse;

            // Console.WriteLine(reverse);

            //}
        }

        static void Main(string[] args)
        {
            string test = "Hello";
            Console.WriteLine(ReverseAlphabet(test));

        }


    }
}
