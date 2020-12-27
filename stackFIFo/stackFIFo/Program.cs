using System;
using System.Collections;
using System.Security.Cryptography;

namespace stackFIFo
{
    class Program
    {
       
       static Stack s1 = new Stack();
       static Stack s2 = new Stack();


        static void Main(string[] args)
        {
            enQueue(30);
            enQueue(20);
            enQueue(50);
            deQueue();

            Console.WriteLine(s1.Peek());

           
            
        }
        public static void enQueue(int number)
        {
            // check if there is an element in the stack
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());

            }
            s1.Push(number);

            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());

            }
        }
      public static void deQueue()
        {
            if (s1.Count == 0)
            {
                Console.WriteLine("the list is empty");
            }
            else
            {
                s1.Pop();
            }
        }
    }
}
