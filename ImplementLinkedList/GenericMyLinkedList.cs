using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLinkedList

//Doubly Linked List
{
    class GenericMyLinkedList<T> : IEnumerable<T>
    {
        public class Node
        {
            private T _value;
            private Node next;
            private Node previous;

            public Node(T value)
            {
                this._value = value;
                next = null;
                previous = null;
            }

            public T Value
            {
                get { return _value; }
                set { this._value = value; }
            }

            public Node Next
            {
                get { return next; }
                set { this.next = value; }
            }
            public Node Previous
            {
                get { return previous; }
                set { this.previous = value; }
            }
        }

        Node head;
        private int count;
        //private Node current;
        Node first;
        Node last;

        public Node First
        {
            get { return first; }
        }
        public Node Last
        {
            get { return last; }
        }
        public int Count
        {
            get { return count;}
        }
        public Node Next
        {
            get { return head.Next; }
        }
        public Node Previous
        {
            get { return head.Previous; }
        }

        public Node Head
        {
            get { return head; }
        }
        //public void AddAfter(Node _node,T _current)
        //{

        //}
        public void AddFirst(T _current)
        {
            Node newNode = new Node(_current);
            first = newNode;
            if (head == null)
                last = first;
            newNode.Next = head;
            newNode.Previous = null;
            head = newNode;
            count++;
            
        }

        public void AddLast(T _current)
        {
            //secend solution
            Node newNode = new Node(_current);

            if (head == null)
            {
                head = newNode;
                last = head;
                count++;
                first = head;
                return;
            }
            newNode.Previous = last;
            last.Next = newNode;
            last = last.Next;
            count++;
            
            //first solution
            //Node end=head;

            //if (!end.Equals(null))
            //{
            //    while (end.Next != null)
            //        end = end.Next;

            //    end.Next = new Node(current);
            //    count++;
            //}
            //else
            //{
            //    head = new Node(current);
            //    count++;
            //}
        }


        public IEnumerator<T> GetEnumerator()
        {
            Node currentHead = head;
            while (currentHead != null)
            {
                
                yield return currentHead.Value;
                currentHead = currentHead.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
