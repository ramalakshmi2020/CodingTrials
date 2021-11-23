using System;

namespace SumListSLL
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

        static Node Sumlist(Node head1, Node head2)
        {
            
            if (head2 == null) return head1;
            if (head1 == null) return head2;
            Node sumlist = null;
            Node start1 = head1;
            Node start2 = head2;
            int carry = 0;
            Node prev = null;
            while (start1 != null || start2 != null || carry==1)
            {

                
                int sum = carry + (start1 != null ? start1.data : 0)
                  + (start2 != null ? start2.data : 0);
                carry = (sum >= 10) ? 1 : 0;

                // update sum if it is greater than 10
                sum = sum % 10;
                Node newnode = new Node(sum);
                if (prev == null)
                {
                    sumlist = newnode;
                }
                else prev.next = newnode;
                prev = newnode;
                start1 = start1 != null ? start1.next  : null;
                start2 = start2 != null ? start2.next : null;

            }
            
            return sumlist;
        }
        static Node Reverse(Node head)
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;

            }
            return prev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the 2 lists to be added separated by space");
            string[] element = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(element[0]);
            int m = Convert.ToInt32(element[1]);
            Console.WriteLine("Enter the integer elements in the first list");
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
            Console.WriteLine("Enter the integer elements in the second list");
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


            Node res = Sumlist(head1, head2);

            printList(res);

            res = Sumlist(Reverse(head1), Reverse(head2));
            Console.WriteLine("Lists reversed and sum list of that");
            printList(Reverse(res));
        }
    }
}
