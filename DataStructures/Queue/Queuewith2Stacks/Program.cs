using System;
using System.Collections.Generic;

namespace Queuewith2Stacks
{
    class Program
    {
        public class MyQueue
        {
            private Stack<int> s1;
            private Stack<int> s2;
            public MyQueue()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();

            }

            public void Enqueue(int x)
            {
                
                //always push new elements to the bottom of the stack
                
                while(s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                s1.Push(x);
                //now copy all the elements back
                while(s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
                // now the stack s1 will mimic a queue behaviour
                
            }

            public int Dequeue()
            {
                return s1.Pop();
            }

            public int Peek()
            {
                return s1.Peek();
            }
            public bool Empty()
            {
                return s1.Count == 0;
            }

        }

        

       
        public class MyQueue2
        {
            private Stack<int> s1;
            private Stack<int> s2;
            public MyQueue2()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();

            }

            public void Enqueue(int x)
            {

                s1.Push(x);
            }

            public int Dequeue()
            {
                if(s2.Count == 0)
                {
                    while(s1.Count > 0)
                    {
                        s2.Push(s1.Pop());
                    }
                }
                return s2.Pop();
            }

            public int Peek()
            {
                if (s2.Count == 0)
                {
                    while (s1.Count > 0)
                    {
                        s2.Push(s1.Pop());
                    }
                }
                return s2.Peek();
            }
            public bool Empty()
            {
                return s1.Count +s2.Count == 0;
            }

        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(1); // queue is: [1]
            myQueue.Enqueue(2); // queue is: [1, 2] (leftmost is front of the queue)
            
            Console.Write("Enqueued elements 1,2");
            Console.WriteLine();
            int peek = myQueue.Peek(); // return 1
            Console.Write("Output for the Peek - this should always be the first element - 1 is {0} ", peek);
            Console.WriteLine();
            Console.WriteLine("Output for the Dequeue - this should alose be the first element - 1 is {0} ", myQueue.Dequeue()); // return 1, queue is [2]
            Console.WriteLine("Output for the Isempty call -  {0} ",myQueue.Empty()); // return false
            Console.Read();
        }
    }
}
