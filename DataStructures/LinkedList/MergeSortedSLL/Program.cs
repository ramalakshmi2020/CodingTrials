using System;

namespace MergeSortedSLL
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
        static Node sortedMerge(Node head1, Node head2)
        {
            //Your code here
            if (head1 == null) return head2;
            if (head2 == null) return head1;
            if (head1.data <= head2.data) return merge(head1, head2);
            else  return merge(head2, head1);
        }

        static Node merge(Node head1, Node head2)
        {
            Node current = head1;
            
            Node start2 = head2;
            
            while (current != null && start2 != null)
            {


                if (current.next == null)
                {
                    //add whatever remaining in the second list at this point
                    if (start2.data > current.data)
                    {
                        current.next = start2;
                    }
                    
                }
                else if (start2.data >= current.data && start2.data <= current.next.data)
                {
                    Node next = current.next;
                    Node next2 = start2.next;
                    current.next = start2;
                    start2.next = next;
                    
                    start2 = next2;

                }
                
                    current = current.next;
                        
            }
            return head1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the 2 lists to be merged separated by space");
            string[] element = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(element[0]);
            int m = Convert.ToInt32(element[1]);
            Console.WriteLine("Enter the integer elements in the first list to be merged separated by space");
            string elements = Console.ReadLine().Trim();
            string[] s = elements.Split(' ');
            int[] arr1 = new int[n];
            arr1 = Array.ConvertAll(elements.Split(), int.Parse);

            Node head1 = new Node(arr1[0]);
            Node tail = head1;

            for (int i = 1; i < n; i++)
            {
                tail.next = new Node(arr1[i]);
                tail = tail.next;
            }
            Console.WriteLine("Enter the integer elements in the second list to be merged separated by space");
            elements = Console.ReadLine().Trim();
            string[] s1 = elements.Split(' ');
            int[] arr2 = new int[m];
            arr2 = Array.ConvertAll(elements.Split(), int.Parse);

            Node head2 = new Node(arr2[0]);
            tail = head2;
            for (int i = 1; i < m; i++)
            {
                tail.next = new Node(arr2[i]);
                tail = tail.next;
            }
            // printList(head1);
            // printList(head2);

            
            Node res = sortedMerge(head1, head2);

            printList(res);

        }
    
    }
}
