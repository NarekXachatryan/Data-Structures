using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        
        static void Main(string[] args)
            {
                LinkedLists list = new LinkedLists();

                list.AddFirst(11);
               
                list.AddFirst(10);
                list.AddLast(12);
                list.AddLast(13);
                list.InsertBefore(11, 7);
                list.InsertAfter(10, 5);
                list.Remove(13);
                list.Print();
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
              

                Console.ReadLine();
            }
        
    }
}
