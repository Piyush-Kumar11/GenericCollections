using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class HashSetD
    {
        public static void HashSetDemo()
        {
            HashSet<int> d = new HashSet<int>();
            d.Add(9);
            d.Add(1);
            d.Add(6);
            d.Add(5);
            d.Add(12);

            foreach(int i in d)
            {
                Console.WriteLine(i);
            }
        }
    }
}
