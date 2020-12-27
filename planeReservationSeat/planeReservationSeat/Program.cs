using System;
//using System.Text;
using System.Linq;

namespace planeReservationSeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findFamilynumberToSeat(2,"1A 2F 1C"));
        }

        public static int findFamilynumberToSeat(int N,string S)
        {
            string[] strarr = S.Split(" ");
          
            int count = 0;

            Console.WriteLine(strarr.Length);

           // StringBuilder str = new StringBuilder();

            //foreach (var t in strarr)
            //{
            //    str.Append(t);
            //    Console.WriteLine(t);
            //}
            
            strarr.Contains("A");

            for(int i=1;i<=N;i++)
            {
                if (!strarr.Contains(i + "B") && !strarr.Contains(i + "C")&& !strarr.Contains(i + "D") && !strarr.Contains(i + "E") && !strarr.Contains(i + "F") && !strarr.Contains(i + "G") 
                    && !strarr.Contains(i + "H") && !strarr.Contains(i + "J"))
                {
                    count += 2;
                }
                else if(strarr.Contains(i + "C") && (!strarr.Contains(i + "D") || !strarr.Contains(i + "E") ||!strarr.Contains(i + "F") ||!strarr.Contains(i + "G")))
                    Console.WriteLine(i);
            }
            //2     1a,2f 1c
            return 22;
        }
    }
}
