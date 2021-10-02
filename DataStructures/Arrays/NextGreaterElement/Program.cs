using System;
using System.Collections.Generic;

namespace NextGreaterElement
{
    class Program
    {
        static int[] NextGreaterElement(int[] a)
        {
            int[] nge = new int[a.Length];
            Stack<int> s = new Stack<int>(a.Length);
            //push the first element to the stack
            s.Push(0);
            for(int i=1; i< a.Length; i++)
            {
                while (s.Count > 0)
                {
                    //compare this with the rest of the elemnents to decide its position
                    if (a[s.Peek()] <= a[i])
                        nge[s.Pop()] = a[i];
                    else break;
                }
                s.Push(i);
                
            }
            while (s.Count > 0) nge[s.Pop()] = -1;

            return nge;
        }

        static int[] NextGreaterElementSol2(int[] a)
        {
            //int[] nge = new int[a.Length];
            Stack<int> s = new Stack<int>(a.Length);
           
            for (int i = a.Length-1; i >= 0; i--)
            {
                int num = a[i];
                while (s.Count > 0)
                {
                    //compare this with the rest of the elemnents to decide its position
                    if (s.Peek() <= num)
                        s.Pop();
                    else break;
                }
                a[i] = s.Count == 0 ? -1 : s.Peek();
                s.Push(num);

            }
            

            return a;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 4, 5, 2, 25 };
            int[] nge = NextGreaterElementSol2(a);
            Console.Write("NExt greater elements for the array [4, 5, 2, 25]  is ");
            foreach (int i in nge) Console.Write("{0} ", i);
            int[] b ={13, 7, 6, 12};
            Console.WriteLine();
            nge = NextGreaterElement(b);
            Console.Write("NExt greater elements for the array [13, 7, 6, 12]  is ");
            foreach (int i in nge) Console.Write("{0} ", i);
            int[] c = {1,2, 3, 4 };
            Console.WriteLine();
            nge = NextGreaterElement(c);
            Console.Write("NExt greater elements for the array [1,2, 3, 4 ]  is ");
            foreach (int i in nge) Console.Write("{0} ", i);
            int[] d = { 4,3,2,1};
            Console.WriteLine();
            nge = NextGreaterElement(d);
            Console.Write("NExt greater elements for the array [ 4,3,2,1 ]  is ");
            foreach (int i in nge) Console.Write("{0} ", i);
            Console.Read();

        }
    }
}
