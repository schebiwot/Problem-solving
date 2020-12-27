using System;
using System.IO;

namespace QueueDemo
{
    class Queue
    {
        public int[] queueList;
        public int front;
        public int rear;
        public int size;

        //use constructor to initialize default values

        public Queue(int sizeMax)
        {
            queueList = new int[sizeMax];
            front = 0;
            rear = -1;
            size = sizeMax;
        }
        static void Main(string[] args)
        {
            Queue obj = new Queue(5);
            obj.enQueue(7000);
            obj.enQueue(099);
            obj.enQueue(10);

            obj.printQueue();
            Console.WriteLine("elements after removal");
            obj.dQueue();
            obj.printQueue();
        }

        public void enQueue(int queueElement)
        {
            //check if the queue is full
            if (rear==size -1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                queueList[++rear]=queueElement;
            }
     
        }

        public void printQueue()
        {
            //check if the queue is empty
            if (front==rear +1)
            {
                Console.WriteLine("The list is  empty");
                return;
            }
            else
            {
                //print queue list elements
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queueList[i]);
                }
            }
        }

        public void dQueue()
        {
            //check if the queue is empty
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {
                //remove element from the list
                front++;
                Console.WriteLine($"removing the front element{queueList[front]} from the list");



            }
        }
    }
}
