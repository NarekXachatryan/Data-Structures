using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_And_Reduce
{
   static class MapReduce
    {
        public static List<T> Map<T,Q>(this List<Q> list,Func<Q,T> func)
        {
            List<T> result = new List<T>();
            foreach( Q item in list)
            {
                result.Add(func(item));
            }
            return result;
        }

        
        public static Q Reduce<T, Q>(this List<T> list,Q initial, Func<T, Q , Q> r)
        {
            Q result = initial;
            foreach (T item in list)
            {
                result = r(item, result);
            }

            return result;
        }
    }
}
