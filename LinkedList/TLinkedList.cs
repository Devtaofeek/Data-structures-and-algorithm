using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm.LinkedList
{
    public class TLinkedList
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }
        private Node Head { get; set; }
        private Node Tail { get; set; }


        public void AddLast(int value)
        {
            var newNode = new Node(value);
            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddFirst(int value)
        {
            var newNode = new Node(value);
            if (isEmpty())
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        private bool isEmpty()
        {
            return Head != null;
        }

        public int IndexOf(int value)
        {
            var index = 0;
            var current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return index;
                }

                index++;

                current = current.Next;
            }

            return -1;
        }

        public bool Contains(int value)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (isEmpty())
            {
                return;
            }

            if (Head == Tail)
            {
                Head = Tail = null;
            }
            var second = Head.Next;
            Head.Next = null;
            Head = second;

        }

        public void RemoveLast()
        {
            if (!isEmpty())
            {
                return;
            }

            if (Head == Tail)
            {
                Head = Tail = null;
            }

            var current = Head;
            var secondLast = current;
            while (current != null)
            {
                if (current.Next == null)
                {
                    secondLast.Next = null;
                    Tail = secondLast;
                }
                else
                {
                    secondLast = current;
                }
                current = current.Next;
            }
        }

        public void ReverseLinkedList()
        {
            if (!isEmpty())
            {
                return;
            }
            if (Head.Next == null)
            {
                return;
            }
            else
            {
                var current = Head.Next; // this is the node to be updated in the loop. so the first one will be head.next
                var previous = Head; // this one here will hold the newly manipulated node so that it will be available to the current to point to
                while (current != null)
                {
                    var next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }
                Head.Next = null;
                Tail = Head;
                Head = previous;
            }
        }

        public int KthNodeFromTheEnd(int k)
        {
            // find k4
            // 10 -> 20 -> 30 -> 40 -> 50 -> 60
            // k 1 = 60
            //k 2 = 50
            //k 3 = 40

            // k3  2 pointers from the first
            // k2 1 pointer from the first 
            // k1 = 0 pointer from the first 
            // k4 = 3 node 
            // k5 = 4 node 

            var current = Head;
            var previous = Head;
            var count = 0;
            while (current != null)
            {
                if (count > k - 1)
                {
                    previous = previous.Next;
                }
                count++;
                current = current.Next;
            }

            if (k > count || Head == null)
            {
                return 0;
            }
            return previous.Value;

        }


        public int KthNodeFromTheEndMosh(int K)
        {
            var a = Head;
            var b = Head;

            if (isEmpty())
            {
                return 0;
            }

            for (var i = 0; i < K - 1; i++)
            {
                b = b.Next;
                if (b == null)
                {
                    return 0;
                }
            }

            while (b != Tail)
            {
                a = a.Next;
                b = b.Next;
            }

            if (K == 0)
            {
                return 0;
            }

            return a.Value;
        }


    }
}
