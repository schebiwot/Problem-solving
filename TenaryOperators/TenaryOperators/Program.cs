using System;
using System.Dynamic;

namespace TenaryOperators
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter person's Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(IsStudent(age));
        }
        public static string IsStudent(int age)
        {
            string result = "";
            if (age > 30)
            {
                result = "Not Student";
            }
            else
            {
                result = "Student";
            }
            return result;
        }
        public static streing TeneryOperator()
        {
            string result1="";
            string result=(age>30)? "Not student": "Student";
            

        }
    }
}
