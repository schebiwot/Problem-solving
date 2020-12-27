using System;

namespace OffLineMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = { "2", "2", "5", "E", "6", "1" };
            findminimumOffline(test);
            foreach(var i in test)
            {
               // Console.WriteLine(i);
            }
      
        }
        public static string findminimumOffline(string []w)

        {

            //find the index of E
            //loop from start to the index of e
            //find the minimum in that loop
            //remove minimum and E
            //repeat the samae process

            //string word = w.ToString();
            int indE = w.IndexOf('5');
            Console.WriteLine(indE);

            Math.su

            return "kkkk";
        }
    }
}
//List<string> Minstr = new List<string>();