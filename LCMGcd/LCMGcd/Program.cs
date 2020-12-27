using System;


namespace LCMGcd
{
    class Program
    {
        
 
        
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

            static int GetLCM(int num1, int num2)
            {
                return (num1 * num2) / GetGCD(num1, num2);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("C# Program for LCM and GCD");

                Console.Write("Enter First Number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                int gcd = GetGCD(a, b);
                int lcm = GetLCM(a, b);

                Console.WriteLine("\nGCD({0,4},{1,4}) = {2,6}", a, b, gcd);
                Console.WriteLine("\nLCM({0,4},{1,4}) = {2,6}", a, b, lcm);

            }
        }
    }

