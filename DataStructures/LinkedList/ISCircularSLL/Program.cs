using System;

namespace ISCircularSLL
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
        static void loopHere(Node head, Node tail, int x)
        {
            if (x == 0)
            {
                return;
            }
            Node walk = head;

            for (int i = 1; i < x; i++)
            {
                walk = walk.next;
            }
            tail.next = walk;
        }

        static bool ISCircular(Node head)
        {
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of nodes in the Line 1 \nInt values in each node separated by space in line 2 \nInteger nth node where the loop is formed in line 3");
            int n = Convert.ToInt32(Console.ReadLine());
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
            loopHere(head, tail, x);
            
            bool res = ISCircular(head);
            if (res)
            {
                Console.Write("True\n");
            }
            else
            {
                Console.Write("False\n");
            }
        }
    }
}
