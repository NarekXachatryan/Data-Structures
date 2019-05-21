using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Tree = new BinaryTree();
            Tree.Add(10);
            Tree.Add(9);
            Tree.Add(8);
            Tree.Add(7);
            Tree.Add(11);
            Tree.Add(6);
            Tree.Add(12);
            Tree.Print(Tree);
        }
    }
}
