using System;
using System.Collections;
using System.Collections.Generic;

namespace MinStack
{
    
    class Program
    {
        public struct Node
        {
            public int value;
            public int minval;

        }
        public class MinStack
        {
            private List<Node> minStack;
            private int min = int.MaxValue;
            public MinStack()
            {
                minStack = new List<Node>();
            }

            public void Push(int val)
            {
                min = Math.Min(min, val);
                minStack.Add(new Node { minval = min, value = val });

            }

            public int Pop()
            {
                Node n = minStack[minStack.Count - 1];
                minStack.RemoveAt(minStack.Count - 1);
                //reset minval 
                if (minStack.Count > 0)
                    min = (minStack[minStack.Count - 1]).minval;
                else min = int.MaxValue;
                
                return n.value;
            }

            public int Top()
            {
                return minStack[minStack.Count - 1].value;
            }

            public int GetMin()
            {
                return min;
            }
        }
        public class MinStack1
        {
            private Stack<int> minStack;
            private int min = int.MaxValue;
            public MinStack1()
            {
                minStack = new Stack<int>();
            }

            public void Push(int val)
            {
                if(val < min)
                {
                    minStack.Push(min);
                    min = val;
                }
                
                minStack.Push(val);

            }

            public int Pop()
            {
                int retval = minStack.Pop();
                if (retval == min)
                {
                    min = minStack.Pop();
                }
                return retval;
            }

            public int Top()
            {
                return minStack.Peek();
            }

            public int GetMin()
            {
                return min;
            }
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MinStack1 minStack = new MinStack1();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine("Pushed elements -2,0,-3");
            Console.WriteLine("The return value of get min now (should be -3) is {0} ", minStack.GetMin()); // return -3
            Console.WriteLine("The return value of Pop now (should be -3) is {0} ", minStack.Pop());
            Console.WriteLine("The return value of Top now (should be 0) is {0} ", minStack.Top());    // return 0
            Console.WriteLine("The return value of Getmin now (should be -2) is {0} ", minStack.GetMin()); // return -2
            Console.Read();
        }
    }
}
