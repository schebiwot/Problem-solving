using System;
using System.Collections.Generic;


namespace LinkedList
{
    class LinkedList
    {

        Node head;
        
        class Node
        {
            public Node next;
            public int data;
            //create constructor
            public  Node(int d)
            {
                data = d;
                Node next = null;
            }
        }

        static void Main(string[] args)
        {
            LinkedList Llist = new LinkedList();
            //first node...always
            Llist.head = new Node(100);
            //Add second Node
            Node Second = new Node(40);
            Node third = new Node(410);
            Llist.head.next = Second;
            Second.next = third;
            Console.WriteLine(Llist.head.data);
            Console.WriteLine(Second.data);
            Console.WriteLine(third.data);

            Node n = Llist.head;

            while (n!= null)
            {
                Console.WriteLine(n.data);
                n = n.next;

            }

        }
    }
}
