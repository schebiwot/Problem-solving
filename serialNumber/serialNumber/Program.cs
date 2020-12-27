using System;
using System.Linq;

class MainClass
{

    public static string SerialNumber(string str)
    {

        // code goes here  

        //check the length of the string if itis less than 11 or greator than 11 return false
        //split the string using period delimeter

        int len = str.Length;
        if (len < 11 || len > 11)
        {
            return "false";
        }
        string[] srn = str.Split(".");

        string firstset = srn[0];
        string secondset = srn[1];
        string thirdset = srn[2];

        //check if the firstset adds upto an even number

        int sumfirst = firstset.Select(digit => Int32.Parse(digit.ToString())).Sum();

        // Console.WriteLine(sumfirst);

        if (sumfirst % 2 != 0)
        {
            return "false";
        }
        //check if the secondset adds upto an odd number
        int sumsecond = secondset.Select(digit => Int32.Parse(digit.ToString())).Sum();
        if (sumsecond % 2 == 0)
        {
            return "false";
        }

        for (int i = 0; i < firstset.Length; i++)
        {

            if (firstset[2] < firstset[1] && firstset[2] < firstset[0])
            {
                return "false";

            }
            if (secondset[2] < secondset[1] && secondset[2] < secondset[0])
            {
                return "false";

            }
            if (thirdset[2] < thirdset[1] && thirdset[2] < thirdset[0])
            {
                return "false";

            }

        }
        return "true";

    }
    /// <summary>
    /// Have the function SerialNumber(str) take the str parameter being passed and determine if it is a valid serial number with the following constraints:

//1. It needs to contain three sets each with three digits(1 through 9) separated by a period.
//2. The first set of digits must add up to an even number.
//3. The second set of digits must add up to an odd number.
//4. The last digit in each set must be larger than the two previous digits in the same set.

//If all the above constraints are met within the string, the your program should return the string true, otherwise your program should return the string false. For example: if str is "224.315.218" then your program should return "true".
//    /// </summary>
    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SerialNumber(Console.ReadLine()));
    }

}