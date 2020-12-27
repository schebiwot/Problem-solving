using System;


namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            findfactors(27);
        }
        public static int findfactors(int num)

        {
            int i;

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            return i;

        }
       
        }

}