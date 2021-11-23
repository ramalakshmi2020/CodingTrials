using System;
using System.Collections.Generic;

namespace FlattenSLL
{
    class Program
    {
		public class Node
		{
			public int data;
			public Node next;
			public Node bottom;

			public Node(int d)
			{
				data = d;
				next = null;
				bottom = null;
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
        static void printListBottom(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.bottom;
            }
            Console.Write("\n");
        }
        static Node mergeUtil(Node head1, Node head2)
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
                    Node next2 = start2.bottom;
                    current.next = start2;
                    start2.next = next;

                    start2 = next2;

                }

                current = current.next;

            }
            return head1;
        }

        static Node mergeUtilbottom(Node head1, Node head2)
        {
            Node current = head1;

            Node start2 = head2;

            while (current != null && start2 != null)
            {


                if (current.bottom == null)
                {
                    //add whatever remaining in the second list at this point
                    if (start2.data > current.data)
                    {
                        current.bottom = start2;
                    }

                }
                else if (start2.data >= current.data && start2.data <= current.bottom.data)
                {
                    Node next = current.bottom;
                    Node next2 = start2.bottom;
                    current.bottom = start2;
                    start2.bottom = next;

                    start2 = next2;

                }

                current = current.bottom;

            }
            return head1;
        }

        static Node FlattenListBottom(Node head1)

        {
            Node current = head1;
            
            while (current != null && current.next != null)
            {
                Node next = current.next;
                if (current.data <= current.next.data)
                {
                    current = mergeUtilbottom(current, current.next);
                }else
                    current = mergeUtilbottom(current.next, current);
                current.next = next.next;
            }


            return current;
        }

            static Node FlattenList(Node head1)

        {
            Node current = head1;
            var nodes = new List<Node>();
            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }
           
            foreach(Node temp in nodes)
            {
                
                mergeUtil(temp, temp.bottom);
                
            }
            return head1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer N denoting the number of head nodes connected to each other.");
			int n = Convert.ToInt32(Console.ReadLine());
			
			//while (t > 0)
			//{
				Console.WriteLine("Enter N space separated numbers (M1, M2...Mn) denoting number of elements in linked lists starting with each head.");
			string elements = Console.ReadLine().Trim();
			string[] s = elements.Split(' ');
			int[] arr1 = new int[n];
			arr1 = Array.ConvertAll(elements.Split(), int.Parse);
			int sum = 0;
			foreach (int i in arr1) sum += i;
			Node head = null;
			Console.WriteLine("Enter all the elements of the linked list starting with 1st head node and covering all the elements through its down pointer, then 2nd head node and covering all its elements through down pointer and so on till the last head node of the linked list.");
			string elements1 = Console.ReadLine().Trim();
			string[] s1 = elements1.Split(' ');
			int[] numbers = new int[sum];
			numbers = Array.ConvertAll(elements1.Split(), int.Parse);
			int arrayindex = 0;
			Node current = null;
			for(int i = 0; i <n; i++)
            {
				//create head node first
				Node newnode = new Node(numbers[arrayindex++]);
				if (current == null) head = newnode; else current.next = newnode;
				current = newnode;
				Node temp = current;
				for(int j=1; j<arr1[i]; j++)
                {
					Node bottomnode = new Node(numbers[arrayindex++]);
					temp.bottom = bottomnode;
                    temp = temp.bottom;
				}

            }

            Node output = FlattenList(head);
            printList(output);
            current = null;
            head = null;
            arrayindex = 0;
            for (int i = 0; i < n; i++)
            {
                //create head node first
                Node newnode = new Node(numbers[arrayindex++]);
                if (current == null) head = newnode; else current.next = newnode;
                current = newnode;
                Node temp = current;
                for (int j = 1; j < arr1[i]; j++)
                {
                    Node bottomnode = new Node(numbers[arrayindex++]);
                    temp.bottom = bottomnode;
                    temp = temp.bottom;
                }

            }
            output = FlattenListBottom(head);
                printListBottom(output);
            }
    }
}
