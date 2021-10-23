using System;

namespace ReverseSLL
{
    class Program
    {
        public class Node
        {
            public int val;
            public Node next;
        }
        public class SingleLinkedlist
        {
            public Node head;
            public Node tail;

            public SingleLinkedlist()
            {
                head = null;
                tail = null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
