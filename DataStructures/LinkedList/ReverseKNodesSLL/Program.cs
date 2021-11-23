using System;

namespace ReverseKNodesSLL
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

        static Node ReverseKNodes(Node head, int k)
        {
            Node prev = null;
            Node next = null;
            Node current = head;
            int i = 0;
           
            while(current != null && i < k)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                i++;
            }
            
            if (current != null)
            {
                head.next = ReverseKNodes(current, k);
            }
            return prev;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of nodes in the list");
            string[] element = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(element[0]);
            Console.WriteLine("Enter " +  n + " integer elements separated by space ");
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
            Console.WriteLine("Enter the number K denoting the size for reversing nodes");
            int x = Convert.ToInt32(Console.ReadLine());

            Node res = ReverseKNodes(head, x);
            printList(res);
        }
    }
}
