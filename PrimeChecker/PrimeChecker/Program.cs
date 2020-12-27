using System;
using System.Collections.Generic;

namespace PrimeChecker
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        findPermutation("123");
        }
//public static void findPermutation(string input)
//{
//    StringPermutation("", input);
//}
//private static void StringPermutation(string permutation, string input)
//{
//    if (input.Length == 0)
//    {
//        Console.WriteLine(permutation);

//    }
//    else
//    {
//        for (int i = 0; i <input.Length; i++)
//        {
//            string prm = permutation + input[i];
//            string inpt = input.Substring(0, i);// + input.Substring(i, input.Length);
//            StringPermutation(prm, inpt);
//        }
//    }
//}



public class Solution
{
    static void Main(string[] args)
    {

         permute("123");
    }
            List<IList<int>> solution = new List<IList<int>>();

            public IList<IList<int>> Permute(int[] nums)
            {
                List<int> unused = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    unused.Add(nums[i]);
                }

                findPermsRecursive(new List<int>(), unused);
                return solution;
            }

            public void findPermsRecursive(List<int> cur, List<int> unused)
            {
                if (unused.Count == 0)
                {
                    solution.Add(new List<int>(cur));
                    return;
                }

                for (int i = 0; i < unused.Count; i++)
                {
                    cur.Add(unused[i]);
                    unused.RemoveAt(i);
                    findPermsRecursive(cur, unused);
                    unused.Insert(i, cur[cur.Count - 1]);
                    cur.RemoveAt(cur.Count - 1);
                }
            }
        }
    
}
}
}