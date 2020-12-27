using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("Sharon");
            stk.Push(26);
            stk.Push("me");
            stk.Push(22);
            stk.Push("Sheila");
            stk.Push(16);
            stk.Push("kiki");
            stk.Push(21);
            //check if ther is anything in the stack
            foreach(var item in stk)
            {

                Console.WriteLine(item);
            }

            stk.Pop();
            foreach (var item in stk)
            {

                Console.WriteLine(item);
            }

                        Console.WriteLine($"the peek is :{ stk.Peek()}");
            Console.WriteLine(stk.Contains("Sharon"));

            Console.WriteLine(stk.Contains("ann"));
        }
    }
}
