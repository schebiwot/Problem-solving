using System;

namespace DiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int []{ 1, 5, 2, 1, 4, 0 }));
        }
        public static int solution(int[] A)
        {
            // get the edges of the disc (far left and far right) store in an array
            
            long[] lower = new long[A.Length];
            long[] upper = new long[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                //upper = center + A[i]
                upper[i] = i + (long)A[i]; 

                //lower = center- A[i]

                lower[i] = i - (long)A[i]; 
            }
            foreach (var item in upper)
            {
                Console.WriteLine(item);
            }

            // "sort" the "lower points" and "upper points"
            Array.Sort(upper);
            Array.Sort(lower);

            int intersection = 0; // number of intersections
            int j = 0; // for the lower points

            // scan the upper points
            for (int i = 0; i < A.Length; i++)
            {

                // for the curent "j" (lower point) 
                while (j < A.Length && upper[i] >= lower[j])
                {
                    //Console.WriteLine(j+" " +"here is chei");
                    //Console.WriteLine("...................................");
                    Console.WriteLine(  j);
                    intersection += j; // add j intersections
                   // Console.WriteLine(intersection + "  " +" before");
                    //Console.WriteLine("...................................");
                    intersection = intersection - i; // minus "i" (avoid double count) 
                    //Console.WriteLine(intersection +" " + "After");

                    j++;
                }
            }

            // for the overflow cases
            if (intersection > 10_000_000)
                return -1;

            return intersection;     
        }
    }
}
