using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindReverse("hello"));
        }

       static string FindReverse(string str)
        {
            string ReversedString = "";

            for (int i = str.Length -1; i >=0; i--)
            {
                ReversedString += str[i];

            }
            return ReversedString;

        }
    }
}
