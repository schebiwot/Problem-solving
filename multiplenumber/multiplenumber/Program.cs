using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace multiplenumber
{
    class Program
    {
        public static int sum = 0;
        public static int dsum = 0;
        public static int[] intArr = new int[] {4,7,5,26,8,3 };
        public static int result;

        public  static void Total()

        {
            for (int i=0; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }

       
            dsum = sum * 2;
            
            Console.WriteLine($"the sum is {sum},{dsum}");
           
            for (int j = 0; j <intArr.Length; j++)
            {
                for(int k=j+1;k<intArr.Length; k++)
                {
                    result = intArr[j] * intArr[k];

                    if (result > dsum)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                  
                }
            }
            Console.WriteLine("false");



        }

        
        static void Main(string[] args)
        {
            
            Total();
        }
    }
}
