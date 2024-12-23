using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class TraversalWithEnumerator
    {
        public static void ListDemo()
        {
            List<string> l = new List<string>();
            l.Add("a");
            l.Add("b");
            l.Add("c");
            l.Add("d");
            l.Add("e");

            IEnumerator<string> e = l.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
        }
    }
}
