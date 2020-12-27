using System;


namespace BitWise
{
    
class MainClass
    {
        /// <summary>
        /// Have the function BitwiseOne(strArr) take the array of strings stored in strArr, which will only contain two strings of equal length that represent binary numbers,
        /// and return a final binary string that performed the bitwise OR operation on both strings. A bitwise OR operation places a 0 in the new string where there are zeroes in both binary strings, 
        /// otherwise it places a 1 in that spot. For example: if strArr is ["1001", "0100"] then your program should return the string "1101"
        /// </summary>
        /// <param name="strArr"></param>
        /// <returns></returns>

        public static string BitwiseOne(string[] strArr)
        {
            //split the string into two strings
            //check the the elements omn the same index if trhey are both zeros,then add zero to the string result otherwise add i
            string first = strArr[0];
            string second = strArr[1];
            string[] result = new string[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i].ToString() == "0" && second[i].ToString() == "0")
                {
                    result[i] = "0";
                }
                else
                {
                    result[i] = "1";
                }

            }

            // code goes here  
            return String.Join("", result);

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(BitwiseOne(Console.ReadLine()));
        }

    }
}
