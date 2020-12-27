using System;

namespace LinkedListDemo
{
    class CreateLinkedList
    {

        Node first;

        class Node
        {
            public Node next;
            public int data;
            //create constructor
            public Node(int d)
            {
                //data in linked list
                data = d;
                next = null;
            }
        }

        static void Main(string[] args)
        {
            CreateLinkedList Llist = new CreateLinkedList();
            //creating all node as the same time
            Node first, second, third;

            //Add data to the nodes
            first = new Node(320);
            second = new Node(400);
            third = new Node(430);

            //creating the linked list

            CreateLinkedList theList = new CreateLinkedList();

            //Add nodes to the list
            theList.first = first;
            first.next = second;
            second.next = third;

            theList.AddNewNode(3000);
            theList.PrintLinkedList();
           


        }
        public void PrintLinkedList()
        {
            Node N = first;
            while (N != null)
           
                {
                Console.WriteLine(N.data);
                N = N.next;

            }
        }
        //adding a node to the beginning of a list
        public void AddNewNode(int new_data)
        {
            //creating the new node

            Node NewNode;
            //asssign data to new node
            NewNode = new Node(new_data);

            //Link the NewNode to the LinkedList
            NewNode.next = first;
            //make the NewNord the first element in the list
            first=NewNode;
            
        }
    }
}


