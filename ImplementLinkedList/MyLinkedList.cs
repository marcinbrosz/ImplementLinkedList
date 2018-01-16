using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLinkedList
{
    class MyLinkedList
    {
        private class Node
        {
            private int current;
            private Node next;

            public Node(int current)
            {
                this.current = current;
                next = null;
            }

            public int Current
            {
                get { return current; }
                set { this.current = value; }
            }

            public Node Next
            {
                get { return next; }
                set { this.next = value; }
            }
        }

        Node head;

        public MyLinkedList()
        {
            head = null;
        }

        public void Add(int current)
        {
            if (head == null)
            {
                head = new Node(current);
            }
            else
            {
                Node end=head;
                while (end.Next!=null)
                {
                    end = end.Next;
                }

                end.Next = new Node(current);
            }

        }

        public IEnumerator<int> GetEnumerator()
        {
            Node currentHead = head;
            while (currentHead != null)
            {
                
                yield return currentHead.Current;
                currentHead = currentHead.Next;
            }
        }

    }
}
