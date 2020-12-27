using System;

namespace LongestPalindromicsubstring
{
    class Program
    {

        //Time complexity-O(n2);
       // space(o(n))
        static void Main(string[] args)
        {
            Console.WriteLine(FindLongestPalindrome("toik"));
        }
        public static string FindLongestPalindrome(string word)
        {
            string wordsubstring = "";
            string LongestPalindrome = "";
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length - i; j++)
                {
                    wordsubstring = word.Substring(i, j + 1);

                  
                    if (IsPalindrome(wordsubstring))
                    {
                        if (wordsubstring.Length > LongestPalindrome.Length)
                        {
                            LongestPalindrome = wordsubstring;
                            result = LongestPalindrome;
                        }
                        else
                        {
                            result = "There is palindromic substring";
                        }
                    }


                }
            }


            return result;

        }

   
        public static bool IsPalindrome(string str)
        {
            char[] s = str.ToCharArray();
            Array.Reverse(s);
            string newstr = new string(s);
            if (str == newstr)
            {
                return true;
            }
        

            return false;
        }

    }

    //Write a program that finds the longest palindromic substring of a given string.

    //1001
    //greek
    //tone
}
   
