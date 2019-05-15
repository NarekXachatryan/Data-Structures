using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue<T>
    {
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            public Node(T data)
            {
                this.data = data;
            }
        }
        public Node<T> head;
        public Node<T> tail;
        private int count;
        public int Count
        {
            get => count;
        }
        public bool IsEmpty() => count == 0;

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (tail == null)
            {
                tail = node;
                head = tail;
            }
            else
            {
                tail.next = node;
                tail = node;
                count++;
            }
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new Exception();
            }
            T tmp = head.data;
            head = head.next;
            count--;
            return tmp;
        }

        public T First
        {
            get
            {
                if (count == 0)
                {
                   throw  new Exception();
                }

                return head.data;
            }
        }
        public T Last
        {
            get
            {
                if (count == 0)
                {
                    throw new Exception();
                }

                return tail.data;
            }
        }
        public bool Contains(T data)
        {
            Node<T> node = head;
            while (node != null)
            {
                if (node.data.Equals(data))
                {
                    return true;
                }
                node = node.next;
            }
            return false;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
}
