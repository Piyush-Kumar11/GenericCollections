using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class SortedSetD
    {
        public static void SortedSetDemo()
        {
            SortedSet<string> s= new SortedSet<string>();
            s.Add("P");
            s.Add("D");
            s.Add("E");
            s.Add("A");
            s.Add("Z");

            foreach (string item in s)
            {
                Console.WriteLine(item);
        }   }
    }
}
