using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack<T>
    {
        public class Node<T>
        {
            public T data;
            public Node<T> prev;

            public Node(T data)
            {
                this.data = data;
            }
        }
      
        public Node<T> head;
        private int count;

        public int Count
        {
            get => count;
        }

        public bool IsEmpty() => Count == 0;

        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            node.prev = head;
            head = node;
            count++;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new Exception();
            }
            Node<T> node = head;
            head = head.prev;
            count--;
            return node.data;

        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception();
            }

            return head.data;

        }

    }
}
