using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{
    class Deque<T>
    {

        public class DoublyNode<T>
        {
            public T data;
            public DoublyNode<T> next;
            public DoublyNode<T> prev;
            public DoublyNode(T data)
            {
                this.data = data;
            }
        }

        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count = 0;
        public int Count { get => count; }
        public bool IsEmpty { get => count == 0; }

        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            node.next = head;
            if (head != null)
            {
                head.prev = node;
            }         
            else 
            {
                tail = node;
            }
            head = node;
            count++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new NullReferenceException();
            }
            T tmp = head.data;
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
            return tmp;
        }

        public T RemoveLast()
        {
            if (IsEmpty)
            {
                throw new NullReferenceException();
            }
            T tmp = tail.data;
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
            return tmp;
        }

        public T First
        {
            get
            {
                if (IsEmpty)
                {
                    throw new NullReferenceException();
                }
                return head.data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                {
                    throw new NullReferenceException();
                }
                return tail.data;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoublyNode<T> node = head;
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
    }
}
