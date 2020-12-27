using System;

namespace majorityElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
            FindMajorityElement(test);
        }

        public static void FindMajorityElement(int [] numbers)
        {
            int size = (numbers.Length / 2);
            int majority = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;

                    }
                }
                if (count > size)
                {
                    majority = numbers[i];

                }
            }
                if (!(majority == 0))
                {
                    Console.WriteLine(majority);
                }
                else
                {
                    Console.WriteLine("No majority element found");
                }

            
            
        }
    }
}
