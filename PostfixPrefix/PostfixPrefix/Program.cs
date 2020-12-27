using System;

namespace PostfixPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            int num1 = 3;
            int num2 = 9;
            int answer = num1++ * (num1++ + 2);
            Console.WriteLine(answer);

            //Console.WriteLine(num1++);//3
            ////num1=4
            //Console.WriteLine(num2++);//9
            ////num2=10
            ////val = num1++ + num2++;//14
            ////val will be 12, num1=4,num2=10

            //val = ++num1 + ++num2;
       
            //Console.WriteLine(val);
            //int i;
            //for (i = 0; i < 10; ++i)
            //{
            //    Console.WriteLine( $"Sharon{i}");
            //}
            //Console.WriteLine($" i++ the value of i after the  loop is:{i}");
        }
    }
}
