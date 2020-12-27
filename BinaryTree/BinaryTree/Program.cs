using System;
using System.Xml;

namespace BinaryTree
{
    public class Node {

     public Node left ,right;
       public int key;
        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
   public class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            root = null;
        }
        public static void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                InOrder(node.left);
                Console.WriteLine(node.key);
                InOrder(node.right);

            }
        }
        public static void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(node.key);
                PreOrder(node.left);
                 PreOrder(node.right);

            }
        }

        public static void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
            
                PostOrder(node.left);
                PostOrder(node.right);
                Console.WriteLine(node.key);

            }
        }
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(10);

            tree.root.left=new Node(20);
            tree.root.left.left = new Node(40);
             tree.root.right = new Node(30);
            tree.root.left.right = new Node(50);
            tree.root.right.right = new Node(60);

            InOrder(tree.root);
            Console.WriteLine("preoder ====================");
            PreOrder(tree.root);
            Console.WriteLine("postoder ====================");
            PostOrder(tree.root);

            //Console.WriteLine("Hello World!");
        }
    }
}
