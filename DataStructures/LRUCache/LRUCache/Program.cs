using System;
using System.Collections.Generic;

namespace LRUCache
{
    class Program
    {
        public class LRUCache
        {
            private int size;
            private Dictionary<int, Node> map;
            private Node head;
            private Node tail;

            public class Node
            {
                public int key;
                public int val;
                public Node prev;
                public Node next;
            }
            public LRUCache(int Size)
            {

                size = Size;
                map = new Dictionary<int, Node>(Size);
                head = new Node{ key = -1, val = -1};
                tail = new Node { key = -1, val = -1 };
                head.next = tail;
                tail.prev = head;
            }

            public int Get(int key)
            {
                if (map.ContainsKey(key))
                {
                    //make this most recently used
                    DeleteNode(map[key]);
                    AddNode(map[key]);
                    return map[key].val;

                }
                return -1;
            }

            public void Set(int key, int val)
            {
                if (map.ContainsKey(key))
                {
                    //make this most recently used
                    map[key].val = val;
                    DeleteNode(map[key]);
                    AddNode(map[key]);
                    
                }
                else
                {
                    //else wee need to check if the map has place 
                    if (map.Count == size)
                    {
                        //Evict the LRU
                        map.Remove(tail.prev.key);
                        DeleteNode(tail.prev);
                       

                    }
                    AddNode(new Node { key = key, val = val });
                    map[key] = head.next;
                    
                }

            }
           

            private void DeleteNode(Node node)
            {
                node.prev.next = node.next;
                node.next.prev = node.prev;

            }

            private void AddNode(Node newNode)
            {

                
                newNode.prev = head;
                newNode.next = head.next;
                head.next = newNode;
                newNode.next.prev = newNode;
                return;
            }

        }

        public class LRUCachewithoutDummyHeadandTail
        {
            private int size;
            private Dictionary<int, Node> map;
            private Node HEadMRU;
            private Node TailLRU;

            public class Node
            {
                public int key;
                public int val;
                public Node prev;
                public Node next;
            }
            public LRUCachewithoutDummyHeadandTail(int Size)
            {

                size = Size;
                map = new Dictionary<int, Node>(Size);
            }

            public int Get(int key)
            {
                if (map.ContainsKey(key))
                {
                    //make this most recently used
                    MakeMRU(map[key]);
                    return map[key].val;

                }
                    return -1;
            }

            public void Set(int key, int val)
            {
                if (map.ContainsKey(key))
                {
                    //make this most recently used
                    map[key].val = val;
                    MakeMRU(map[key]);
                }
                else
                {
                    //else wee need to check if the map has place 
                    if (map.Count == size)
                    {
                        //Evict the LRU
                        map.Remove(TailLRU.key);
                        EvictLRU();

                    }
                    AddNode(new Node { key = key, val = val });
                    map[key] = HEadMRU;
                    //set the tailnode to this if it is null - meaning this is the first item so head and tail will be same
                    if (TailLRU == null)
                    {
                        TailLRU = HEadMRU;
                    }
                    //this will always be the head of the list
                }

            }
            private void MakeMRU(Node node)
            {
                if(node == HEadMRU)
                {
                    return;
                }
                
                if(node == TailLRU)
                {
                    EvictLRU();
                    

                }
                else
                {
                    node.prev.next = node.next; 
                    node.next.prev = node.prev;
                    
                }
                AddNode(node);

                

            }

            private void EvictLRU()
            {
                //simply remove the element from the tail.
                //remove it from the map
                
                //if there are no nodes then taillru needs to be set to nu,,
                //if this is the only node in the list
                if(TailLRU == HEadMRU)
                {
                    TailLRU = HEadMRU = null;
                } else
                if (TailLRU.prev != null)
                {
                    var tempnode = TailLRU;

                    TailLRU = tempnode.prev;
                    TailLRU.next = null;
                }
                
            }

            private void AddNode(Node newNode)
            {

                newNode.next = HEadMRU;
                newNode.prev = null;
                if (HEadMRU != null)
                {
                    HEadMRU.prev = newNode;
                }
                HEadMRU = newNode; 

                return ;
            }




        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // ["LRUCache","put","put","get","put","get","put","get","get","get"]
            //[[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]
            LRUCache cache = new LRUCache(3);
            cache.Set(1,1);
            cache.Set(2, 2);
            Console.WriteLine("Result of Get(1) after setting [1,1],[2,2] is {0} ", cache.Get(1));
            cache.Set(3, 3);
            Console.WriteLine("Result of Get(2) after setting [1,1],[2,2][3,3] is {0} ", cache.Get(2));
            cache.Set(4, 4);
            Console.WriteLine("Result of Get(1) (it got evicted  already) is {0} ", cache.Get(1));
            Console.WriteLine("Result of Get(3) is {0} ", cache.Get(3));
            Console.WriteLine("Result of Get(3) is {0} ", cache.Get(4));

            LRUCache cache1 = new LRUCache(2);
            
            Console.WriteLine("Result of Get(1)  {0} ", cache1.Get(2));
            cache1.Set(2, 6);
            Console.WriteLine("Result of Get(2) after setting [2, 6] is {0} ", cache1.Get(2));
            cache1.Set(1, 5);
            cache1.Set(1, 2);
            Console.WriteLine("Result of Get(1) after  [1, 5][1,2] is {0} ", cache1.Get(1));
            Console.WriteLine("Result of Get(2) is {0} ", cache1.Get(2));
          


        }
    }
}
