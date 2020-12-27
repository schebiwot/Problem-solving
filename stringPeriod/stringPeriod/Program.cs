using System;
using System.Linq;
using System.Collections.Generic;

namespace stringPeriod
{
    class Program
    {
    


        public static void Main(string[] args)
        {
            Console.WriteLine(FindSubstring("ABCABCABC"));
        }
        public static string FindSubstring(string str)
        {
            if (str.Length == 1)
            {
                return "-1";
            }

            string sub = "";
            string expected = "";
            var inputlist = str.ToList();

            for (int i = 0; i <= str.Length; i++)
            {

                for (int j = 1; j <= str.Length - i; j++)
                {
                    sub = str.Substring(i, j);
                    Console.WriteLine(sub);

                    //Console.WriteLine(h);

                    //  if(str.Length%sub.Length==0){
                    // Console.WriteLine("gfvhbnj");}
                }


            }
            int h = sub.Length;
            inputlist.Remove(sub);
            Console.WriteLine(sub);
            for (int k = 0; k < h; k++)
            {


                if (inputlist.Contains(sub[k]))
                {
                    expected = inputlist.Remove(sub);
                    if (inputlist.Count = 0)

                    {
                        foreach (var t in inputlist)
            {
                Console.WriteLine(t);
            }

            //   }
            //   }

            return sub;
        }
    }

}
