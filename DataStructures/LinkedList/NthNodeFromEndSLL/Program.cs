using System;

namespace NthNodeFromEndSLL
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
        static int getNthFromLast(Node head, int k)
        {
            if (k <= 0) return -1;
            //Your code here
            int count = 0;
            Node main = head;
            Node refnode = head;
            while (count < k)
            {
                if(refnode == null)
                {
                    Console.WriteLine(k + " is greater than the length of the list");
                    return -1;
                }
                refnode = refnode.next;
                count++;
            }
           
            while(refnode != null)
            {
                refnode = refnode.next;
                main = main.next;
               

            }
            return main.data;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of nodes in the list followed by the number Nth from end separated by space");
            string[] element = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(element[0]);
            int k = Convert.ToInt32(element[1]);
            Console.WriteLine("Enter the integers in each node separated by space");
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

            
            int res = getNthFromLast(head, k);
            Console.Write(res + "\n");
        }
    }
}
