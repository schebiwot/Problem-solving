using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace pixwls
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "kkekenta 3232321";
            test=test.Trim('k');
            byte[] tesr = { 2, 5, 7, 1, 8, 9 };
            char test1 = 'g';
           // Console.WriteLine(test);
           Console.WriteLine(MD5Hash(test));

        }


        public static string findToda( String input, char target)
        {
            // craetes a string builderwith the same size as the input string(this string input)
            StringBuilder sb = new StringBuilder();
            //loop througth the input replacing each element in the input with target
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(target);
            }

            return sb.ToString();
        }
        public static String FromBase64( byte[] input)
        {
            return System.Text.Encoding.UTF8.GetString(input);
        }
        public static String FromWireData( String input)
        {
            input = Regex.Unescape(input);//.unescape removes backslash from input...unescape makes the string more readable...most rgex contains 
                                          // "//"escaped characters, sometimes you want to unescape to their original representation.
            input = input.Trim('"');
            // deletes either leading or trailing(first or last) elements in input eg kkenktak==enkta .Trim('K') removes 
            //the k's at the start and at the end' 
            return input;
        }
        public static string MD5Hash( string input)
        {

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();

        }

    }
}
