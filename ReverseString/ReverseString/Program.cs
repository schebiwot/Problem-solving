using System;
using System.Collections.Generic;

//Write a function that reverses a string. The input string is given as an array of characters char[].


namespace ReverseString
{
    class Program
    {
        public void ReverseString(char[] s)
        {
            Stack<char> reverseStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
                reverseStack.Push(s[i]);
            Console.WriteLine($"reverseStack");


            for (int i = 0; i < s.Length; i++)
            {
                s[i] = reverseStack.Peek();
                reverseStack.Pop();
               
            }
            
            //convert array char to string
            String.Join("", s);
            Console.WriteLine($"{s}");
        }

public static void Main(string[] args)

        {
            String s = "Hello";
            s = ReverseString(s.ToCharArray());
            Console.WriteLine(s);


        }
    }
}
//public class Solution
//{
//    public void ReverseString(char[] s)
//    {
//        Stack<char> reverseStack = new Stack<char>();

//        for (int i = 0; i < s.Length; i++)
//            reverseStack.Push(s[i]);
//        Console.WriteLine($"reverseStack");


//        for (int i = 0; i < s.Length; i++)
//        {
//            s[i] = reverseStack.Peek();
//            reverseStack.Pop();
//        }
//        //convert array char to string
//        String.Join("", s);
//        Console.WriteLine($"{s}");
//    }
//}