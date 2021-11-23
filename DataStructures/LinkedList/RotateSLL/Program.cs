using System;

namespace RotateSLL
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;

            public Node(int a)
            {
                this.data = a;
                this.next = null;
            }

        }
        static void printList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
                
            }
            Console.Write("\n");
        }

        static Node rotate(Node head, int k)
        {
            //Your code here
            int i = 1;
            Node current  = head;
            
            while (i < k && current != null)
            {
                current = current.next;
                i++;
            }
            Node KthNode = current;
            if (current == null) return head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = head;
            head = KthNode.next;
            KthNode.next = null; 
            return head;
        }
        static Node Rotate( Node head, int k)
        {
            int i = 0;
            Node rotatenode = head;
            Node movepointer = head;
            while(i<k && head != null){
                head = head.next;
                movepointer = movepointer.next;
                i++;
            }
            movepointer = null;
            Node newhead = head;
            while(head != null){
                head = head.next;
            }
            head = rotatenode;
            return newhead;
        }

        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                string[] element = Console.ReadLine().Trim().Split(' ');
                int n = Convert.ToInt32(element[0]);
                string elements = Console.ReadLine().Trim();
                string[] s = elements.Split(' ');
                int[] arr1 = new int[n];
                arr1 = Array.ConvertAll(elements.Split(), int.Parse);

                Node head = new Node(arr1[0]);
                Node tail = head;

                for (int i = 1; i < n; i++)
                {
                    tail.next = new Node(arr1[i]);
                    tail = tail.next;
                }
                int x = Convert.ToInt32(Console.ReadLine());

                Node res = rotate(head, x);
                printList(res);

            }
        }
    }
}
        