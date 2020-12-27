using System;

namespace min_window_substring
{
    /// <summary>
    /// Min Window Substring
    /// Have the function MinWindowSubstring(strArr) take the array of strings stored in strArr, which will contain only two strings, the first parameter being the string N and the second parameter being a string K of some characters, and your goal is to determine the smallest substring of N that contains all the characters in K.For example: if strArr is ["aaabaaddae", "aed"] then the smallest substring of N that contains the characters a, e, and d is "dae" located at the end of the string. So for this example your program should return the string dae.
    /// Another example: if strArr is ["aabdccdbcacd", "aad"] then the smallest substring of N that contains all of the characters in K is "aabd" which is located at the beginning of the string. Both parameters will be strings ranging in length from 1 to 50 characters and all of K's characters will exist somewhere in the string N. Both strings will only contains lowercase alphabetic characters.
    /// Examples
    /// Input: new string[] {"ahffaksfajeeubsne", "jefaa"}
    /// Output: aksfaje
    /// Input: new string[] {"aaffhkksemckelloe", "fhea"}
    /// Output: affhkkse
    /// </summary>

    class Program
    {

        public static string MinWindowSubstring(string[] strArr)
        {

            string N = strArr[0];
            string K = strArr[1];

            int len = N.Length;
            int klen = K.Length;
            int count = 0;
            //store characters in arrays
            int[] initial = new int[256];

            int[] target = new int[256];
            //loop through k and store characters in array target
            for (int k = 0; k < klen; k++)
            {
                target[K[k]]++;

            }
            // define parameters to extract substring
            int startAt = 0;
            int startAtIndx = -1;
            int minWndLen = int.MaxValue;
            //iterate through N and store values in array initial
            for (int j = 0; j < len; j++)
            {
                initial[N[j]]++;

                if (target[N[j]] != 0 && initial[N[j]] <= target[N[j]])
                {
                    count++;
                }
                //  if all characters are matching
                if (count == klen)
                {
                    // find the minimum window
                    // by shifting the starting point
                    while (initial[N[startAt]] > target[N[startAt]] || target[N[startAt]] == 0)
                    {
                        if (initial[N[startAt]] > target[N[startAt]])
                        {
                            initial[N[startAt]]--;
                        }
                        startAt++;
                    }
                    int lenWnd = j - startAt + 1;

                    if (minWndLen > lenWnd)
                    {
                        minWndLen = lenWnd;
                        startAtIndx = startAt;
                    }

                }
            }
            return N.Substring(startAtIndx, minWndLen);
        }

        static void Main(string[] args)
        {
            String[] str = new string[] { "ahffaksfajeeubsne", "jefaa" };
            Console.WriteLine(MinWindowSubstring(str));
        }

    }
}
