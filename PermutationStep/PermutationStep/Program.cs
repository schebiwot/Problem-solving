using System;

class MainClass
{
    //Have the function PermutationStep(num) take the num parameter being 
    //    passed and return the next number greater than num using the same digits.
    //For example: if num is 123 return 132, if it's 12453 return 12534. If a number has no greater permutations, return -1 (ie. 999).

    public static int PermutationStep(int num)
    {

        char[] numchr = num.ToString().ToCharArray();
        int nextGreater = findNextGreater(numchr);
        return nextGreater;

    }


    public static int findNextGreater(char[] numchr)
    {
        int len = numchr.Length;
        int i;
        // find the first digit tha is smaller than the next digit
        for (i = len - 1; i > 0; i--)
        {
            if (numchr[i] > numchr[i - 1])
            {
                break;
            }

        }
        //if a number has no greator permutation
        if (i == 0)
        {
            return -1;
        }
        else
        {
            int x = numchr[i - 1];
            int min = i;

            for (int k = i + 1; k < len; k++)
            {
                if (numchr[k] > x && numchr[k] < numchr[min])
                {
                    min = k;
                }
            }
            // swap the smaller digit with numchr[i-1]
            swap(numchr, i - 1, min);
            //sorting the digits after i-1 
            Array.Sort(numchr, i, len - i);
            string nextGreater = "";

            for (i = 0; i < len; i++)
                nextGreater += numchr[i];

            return Convert.ToInt32(nextGreater);

        }
    }

    public static void swap(char[] numchr, int i, int k)
    {
        char temp = numchr[i];
        numchr[i] = numchr[k];
        numchr[k] = temp;
    }


    static void Main()
    {
        // keep this function call here
        int test = 112;
        Console.WriteLine(PermutationStep(test));
    }

}