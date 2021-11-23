using System;

namespace IsPalindromeSLL
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

        static Node Reverse(Node head)
        {
            Node prev = null;
            Node next = null;
            Node current = head;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
        static bool CompareLists(Node list1, Node list2)
        {
            Node head1 = list1;
            Node head2 = list2;
            while (head1 != null && head2 != null)
            {
                if (head1.data == head2.data)
                {
                    head1 = head1.next;
                    head2 = head2.next;
                }
                else
                {
                   return false;
                   
                }

            }
            if (head1 == null && head2 == null) return true;
            return false;
        }
        static bool isPalindrome(Node head)
        {
            bool retval = true; ;
            // find the middle node , reverse the latter half and compare with the first half
            Node slow = head;
            Node fast = head;
            Node prev_to_mid = null; ;
            while (fast != null && fast.next != null)
            {
                prev_to_mid = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            Node midnode = null ;
            if (fast != null)
            {
                //this is the odd number of nodes case - we need to save the middle node and the prev to middle is required to stop the comparison
                //prevtomid = slow;
                midnode = slow;
                slow = slow.next;
                
            }
            prev_to_mid.next = null;
            Node second_half = slow;
            second_half = Reverse(second_half);

            retval = CompareLists(head, second_half);
            
            second_half = Reverse(second_half);
            //reconstruct the list correctly now
            if(midnode != null)
            {
                prev_to_mid.next = midnode;
                midnode.next = second_half;
            } else prev_to_mid.next = second_half;
            return retval;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (N) of elements in the linked list");
            string[] element = Console.ReadLine().Trim().Split(' ');
            int n = Convert.ToInt32(element[0]);
            Console.WriteLine("Enter " + n + " integer elements in the linked list separated by space ");
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
            
            bool res = isPalindrome(head);
            if (res)
            {
                Console.Write(1 + "\n");
            }
            else
            {
                Console.Write(0 + "\n");
            }
        }
    }
}
