using System;
using System.Collections.Generic;

namespace Stackwith2Queue
{
    class Program
    {
        public class MyStack
        {
            private Queue<int> q1, q2;

            public MyStack()
            {
                q1 = new Queue<int>();
                q2 = new Queue<int>();


            }

            public void Push(int x)
            {
                //just enqueue it to the q1;
                q1.Enqueue(x);
            }

            public int Pop()
            {
                //pop is last in first out - so should return the last element in the queue;
                //copy the rest of the elements into the other queue till we reach the last element;

                if (q1.Count > 0)
                {
                    while (q1.Count > 1)
                    {
                        //dequeue and copy theme to the other queue;
                        //int temp = ;
                        q2.Enqueue(q1.Dequeue());
                    }
                    //got the last element
                    int retval = q1.Dequeue();
                    //copy elements back to the first queue now
                    while (q2.Count > 0)
                    {
                        q1.Enqueue(q2.Dequeue());
                    }
                    return retval;
                }
                else
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                //return null;
            }
            public int Top()
            {
                if (q1.Count > 0)
                {
                    int temp = 0;
                    foreach (int i in q1)
                    {
                        temp = i;
                    }
                    return temp;
                }
                else
                {
                    throw new InvalidOperationException("Stack is empty");
                }
            }

            public bool Empty()
            {

                if (q1.Count > 0) return false;
                return true;
            }

        }

        public class MyStack1
        {
            private Queue<int> q1, q2;

            public MyStack1()
            {
                q1 = new Queue<int>();
                q2 = new Queue<int>();


            }

            public void Push(int x)
            {

                q1.Enqueue(x);
                //now need to maintain q
                while(q2.Count > 0)
                {
                    q1.Enqueue(q2.Dequeue());
                }
                //swap q1 and q2
                Queue<int> temp = q1;
                q1 = q2;
                q2 = temp;
            }

            public int Pop()
            {
                //pop is last in first out - so should return the last element in the queue;
                //copy the rest of the elements into the other queue till we reach the last element;

                return q2.Dequeue();
            }
            public int Top()
            {
                return q2.Peek();
                
            }

            public bool Empty()
            {

                return q2.Count == 0;
            }

        }

        public class MyStack2
        {
            private Queue<int> q1, q2;

            public MyStack2()
            {
                q1 = new Queue<int>();
                q2 = new Queue<int>();


            }

            public void Push(int x)
            {

                q1.Enqueue(x);
               
            }

            public int Pop()
            {
               while( q1.Count > 1){
                    q2.Enqueue(q1.Dequeue());

                }
                int retval = q1.Dequeue();
                Queue<int> temp = q1;
                q1 = q2;
                q2 = temp;
                return retval;
            }
            public int Top()
            {
                while (q1.Count > 1)
                {
                    q2.Enqueue(q1.Dequeue());

                }
                int retval = q1.Dequeue();
                q2.Enqueue(retval);
                Queue<int> temp = q1;
                q1 = q2;
                q2 = temp;
                return retval;

            }

            public bool Empty()
            {

                return q2.Count == 0;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ["MyStack","push","push","push","pop","pop","pop","empty"]
            // ["MyStack","push","push","push","pop","pop","pop","empty"]
            //[[],[1],[2],[3],[],[],[],[]]
            MyStack s1 = new MyStack();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine("Pushed elements 1,2,3");
            Console.WriteLine("Output for the first POP ");
            Console.WriteLine(s1.Pop());
            Console.WriteLine("Output for the isempty call ");
            Console.WriteLine(s1.Empty());
            Console.WriteLine("Output for the second POP ");
            Console.WriteLine(s1.Pop());
            Console.WriteLine("Output for the third POP ");
            Console.WriteLine(s1.Pop());
            Console.WriteLine("Output for the isempty call ");
            Console.WriteLine(s1.Empty());
            Console.ReadLine();

        }
    }
}
