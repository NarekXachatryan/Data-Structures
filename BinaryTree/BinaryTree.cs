using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class BinaryTree
    {
        public int? Root;     
        public BinaryTree RightNext;
        public BinaryTree LeftNext;
        
        public void Print(BinaryTree c) 
        {
            Console.Write(c.Root+"  ");
            if (c.LeftNext != null)
            {
                Print(c.LeftNext);
                
            }
            
            if (c.RightNext != null)
            {
                Print(c.RightNext);
               
            }
           
        }
        private void AddLeft(BinaryTree LeftNext, int x)
        {
            if (LeftNext.Root == null)
            {
                LeftNext.Root = x;
                return;
            }
            else
            {

                if (x <= LeftNext.Root)
                {
                    if (LeftNext.LeftNext == null)
                    {
                        LeftNext.LeftNext = new BinaryTree();
                    }
                    AddLeft(LeftNext.LeftNext, x);
                }
                else
                {
                    if (LeftNext.RightNext == null)
                    {
                        LeftNext.RightNext = new BinaryTree();
                    }
                    AddRight(LeftNext.RightNext, x);
                }
            }
        }
        private void AddRight(BinaryTree RightNext, int x)
        {
            if (RightNext.Root == null)
            {
                RightNext.Root = x;
                return;
            }
            else
            {

                if (x <= RightNext.Root)
                {
                    if (RightNext.LeftNext == null)
                    {
                        RightNext.LeftNext = new BinaryTree();
                    }
                    AddLeft(RightNext.LeftNext, x);
                }
                else
                {
                    if (RightNext.RightNext == null)
                    {
                        RightNext.RightNext = new BinaryTree();
                    }
                    AddRight(RightNext.RightNext, x);
                }
            }
        }
        public void Add(int x)
        {
            if (Root == null)
            {
                Root = x;
                return;
            }
            else
            {
                if (x <= Root)
                {
                    if (LeftNext == null)
                    {
                        LeftNext = new BinaryTree();
                        AddLeft(LeftNext, x);
                    }
                    else
                    {
                        AddLeft(LeftNext, x);
                    }
                    return;
                }
                else
                {
                    if (RightNext == null)
                    {
                        RightNext = new BinaryTree();
                        AddRight(RightNext, x);
                    }
                    else
                    {
                        AddRight(RightNext, x);
                    }
                    return;
                }
            }
        }
    }
}
