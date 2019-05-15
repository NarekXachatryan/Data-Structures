﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedLists:IEnumerable,IEnumerator
    {
        public Node head;
        public Node tmpHead;

       

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write("[" + current.data + "] ");
                current = current.next;
            }
        }
        public void AddFirst(int data)
        {
            head = new Node(data, head);
        }
        public void AddLast(int data)
        {
            if (head == null)
            {
                AddFirst(data);
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data, null);
            }
        }
        public void InsertAfter(int data, int insert)
        {
            Node current = head;
            while (current != null && !current.data.Equals(data))
            {
                current = current.next;
            }
            if (current != null)
            {
                current.next = new Node(insert, current.next);
            }
            else
            {
                Console.WriteLine("The value, that you what to insert after, does not exist ");
            }
        }
        public void InsertBefore(int data, int insert)
        {
            if (head == null)
                return;
            if (head.data.Equals(data))
            {
                AddFirst(insert);
                return;
            }
            Node prev = null;
            Node cur = head;

            while (cur != null && !cur.data.Equals(data))
            {
                prev = cur;
                cur = cur.next;
            }
            if (cur != null)
            {
                prev.next = new Node(insert, cur);
            }
            else
            {
                Console.WriteLine("The value, that you what to insert before, does not exist ");
            }
        }

        public void Remove(int data)
        {
            int count = 0;
            if (head == null)
            {
                Console.WriteLine("Cannot delete");
            }

            if (head.data.Equals(data))
            {
                head = head.next;

                return;
            }


            Node prev = null;
            Node cur = head;

            while (cur != null && !cur.data.Equals(data))
            {
                prev = cur;
                cur = cur.next;
            }

            while (cur != null)
            {
                if (cur.data == data)
                {
                    count++;
                    break;
                }
                else
                {
                    cur = cur.next;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("The value, that you whant to remove, does not exist");
                return;
            }
            if (cur == null)
            {
                Console.WriteLine("Cannot deleted");
            }
            prev.next = cur.next;
        }
        
        
        
        //Foreach Implementacia
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        public object Current
        {
            get
            {
                return tmpHead.data;
            }
        }
        public bool MoveNext()
        {
            if (tmpHead == null)
            {
                tmpHead = head;
                return true;
            }   
            else if (tmpHead.next != null)
            {
                tmpHead = tmpHead.next;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            tmpHead = null;
        }
    }
}