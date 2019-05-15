using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {       
        public Node next;
        public int data;

        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
