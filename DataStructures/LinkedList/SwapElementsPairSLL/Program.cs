using System;

namespace SwapElementsPairSLL
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
        static Node pairwiseSwap(Node head)
        {
            if (head == null || head.next == null) return head;
            
            Node ret = head.next;
            Node prev = null;
            Node current = head;
            Node next = null;
           
            while (current != null && current.next != null)
            {
                next = current.next;
                current.next = next.next;
                next.next = current;
                if (prev != null)
                    prev.next = next;
                prev = current;
                current = current.next;
                    
            }
                
            
            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements of linked list  in line1, the numbers in line 2 for pairwise swap");
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
            //int x = Convert.ToInt32(Console.ReadLine());

            Node res = pairwiseSwap(head);
            printList(res);
        }
    }
}
