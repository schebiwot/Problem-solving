using System;

namespace Linearcongruence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findSolutions("32x = 8(mod 4)"));
        }
        public static int findSolutions(string str)

        {
            string word = str.Replace("x =", " ");

            string sentence = word.Replace("(mod", " ").Replace(")"," ");
         

            //split on spaces
            string[] strarr = sentence.Split(' ');
            //find gcd of the first element and the last
            //32 and 4
          
            int a = int.Parse(strarr[0]);
            int b = int.Parse(strarr[4]);
            int c = int.Parse(strarr[2]);
            int gcd = GetGCD(a, b);
         

            int result = 0;
            //find gcd
            //if the is gcd of a and b is divisible by c return gcd else return 0

            if (c%gcd == 0)
            {
                result= gcd;
            }
            else
            {
               return result;
            }

            Console.WriteLine(strarr[1]);

            //32x = 8(mod 4);



            return result;
        }
        static int GetGCD(int num1, int num2)
        {
            int diff = 0;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    diff = num1 - num2;
                    num1 = diff;
                }


                if (num2 > num1)
                {
                    diff = num2 - num1;
                    num2 = diff;
                }

            }
            return num1;
        }
    }
}
