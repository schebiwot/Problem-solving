using System;
using System.Collections.Generic;

namespace RomanToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (RomanToInt("XXVI"));
        }
        public static int RomanToInt(string s)
        {
            var romanSymbols = new Dictionary<char, int>();
            romanSymbols.Add('I', 1);
            romanSymbols.Add('V', 5);
            romanSymbols.Add('X', 10);
            romanSymbols.Add('L', 50);
            romanSymbols.Add('C', 100);
            romanSymbols.Add('D', 500);
            romanSymbols.Add('M', 1000);

            int totalvalue = 0;
            for (var i = s.Length -1; i >=0; i--)
            {
                if (i<s.Length-i && romanSymbols[s[i]]<romanSymbols[s[i+1]])
                {
                    totalvalue -= romanSymbols[s[i]];
                }
                else
                {
                    totalvalue += romanSymbols[s[i]];
                }
            }
            return totalvalue;
        }
    }
}
