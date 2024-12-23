using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class DictionaryD
    {
        public static void DictionaryDemo() 
        { 
            Dictionary<int,string> di = new Dictionary<int,string>();
            //Maintains insertion order
            di.Add(2, "Hii");
            di.Add(9, "Piyush");
            di.Add(1, "null");
            di.Add(4, "Laptop");

            IEnumerator<KeyValuePair<int,string>> e = di.GetEnumerator();
            while (e.MoveNext())
            {
                KeyValuePair<int, string> k = e.Current;
                Console.WriteLine(k.Key+" "+k.Value);
            }

            //foreach(KeyValuePair<int,string> k in di)
            //{
            //    Console.WriteLine(k.Key + " " + k.Value);
            //}

        }
    }
}
