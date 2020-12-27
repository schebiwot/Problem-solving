using System;
using System.Collections.Generic;

namespace rome
{
    class Program
    {
               

            public static void MaxOccurrence(int[] numbers)
            {
                var counts = new Dictionary<int, int>();
                foreach (int number in numbers)
                {
                    int count;
                    counts.TryGetValue(number, out count);
                    count++;
                    //Automatically replaces the entry if it exists;
                    //no need to use 'Contains'
                    counts[number] = count;
                }
                int mostCommonNumber = 0, occurrences = 0;
                foreach (var pair in counts)
                {
                    if (pair.Value > occurrences)
                    {
                        occurrences = pair.Value;
                        mostCommonNumber = pair.Key;
                    }
                }
                Console.WriteLine("The most common number is {0} and it appears {1} times",
                    mostCommonNumber, occurrences);
            }

            public static void Main(string[] args)
            {

                int[] array = new int[] {1,1,0,0 };
                MaxOccurrence(array);

            }
        }
}
