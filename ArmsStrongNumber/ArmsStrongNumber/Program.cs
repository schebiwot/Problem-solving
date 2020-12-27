using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ArmsStrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            checkifarmstrong(153);
        }

            public static void checkifarmstrong(int num)

            {
            int remainder, sum = 0;
                Console.Write("enter the Number");
                num = int.Parse(Console.ReadLine());
                for (int i = num; i > 0; i = i / 10)
                {
                    remainder = i % 10;
                    sum = sum + remainder * remainder * remainder;

                }
                if (sum == num)
                {
                    Console.Write("Entered Number is an Armstrong Number");
                }
                else
                    Console.Write("Entered Number is not an Armstrong Number");
                Console.ReadLine();
            }
        }

    }

