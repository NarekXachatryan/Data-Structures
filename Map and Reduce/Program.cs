using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_And_Reduce
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new[] { 1, 2, 3, 4 });


            List<string> listString = list.Map<string, int>((x) => x.ToString());


            string T = list.Reduce<int, string>("", (x, y) =>

             {
                 int z = 0;
                 foreach (var item in list)
                 {
                     z += item;
                 }
                 return z.ToString();
             });



        }
    }
}
