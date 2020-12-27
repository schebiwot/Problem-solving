using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryPollutionCodility
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(filters(new int[] { 3, 70000, 5000, 4500, 30000 }));
            // Console.WriteLine(filters(new int[] { 75, 23, 44 }));
            //Console.WriteLine(filters(new int[] { 10,10 }));
        }
        public static int filters(int[] A)
        {
            double sum = A.Sum();
            Console.WriteLine(sum);
            double halfSum = sum / 2;
            Console.WriteLine(halfSum);

            double currSum = 0;
            int filters = 0;
            // double sumafterpollution = 0;

            double maxpollution = 0;

            List<int> pollution = new List<int>(A);
            for (int i = 0; i < pollution.Count; i++)
            {

                maxpollution = pollution.Max();


                currSum = maxpollution / 2;
                Console.WriteLine(maxpollution + " " + i);
                sum = sum - currSum;
                Console.WriteLine(sum + "  sum after");
                filters++;
                if (sum < halfSum)
                {
                    break;
                }


                if (pollution[i] == maxpollution)
                {
                    pollution[i] = (int)currSum;

                }


                foreach (var t in pollution)
                {
                    Console.WriteLine(t + " elel");
                }
            }

                return filters;
            }




        
    }
}

