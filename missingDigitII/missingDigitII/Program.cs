using System;
using System.Collections.Generic;


namespace missingDigitII
{
    class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine(findMissingNumber("38?5 * 3 = 1?595"));
        }
        //create a list, add elements into the list replacing each question mark with numbers from 0 to 9
        //separate the elements in the string
        public static int findMissingNumber(string str)
        {
            var splittedstr = str.Split(' ');
            var num1 = splittedstr[0];
            var num2 = splittedstr[4];

            var first = num1.IndexOf("?");
            var second = num2.LastIndexOf("?");//integer


            var question = str[first];
            //Console.WriteLine(second);

            var questionList = new List<string>();
            var answerList = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
               
                var replacer = (char)i;
                Console.WriteLine(replacer);

                num1 = num1.Replace(num1[first],replacer);
                //Console.WriteLine(num1);

                // str[second]=(char)i;
                questionList.Add(num1);
                // }
                foreach (var t in questionList)
                {
                   // Console.WriteLine(t);
                }
            }
                return 2324;

            }
        }
    }



