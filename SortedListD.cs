using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class SortedListD
    {
        public static void SortedListDemo()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("Piyush", "java");
            sl.Add("Karan", "python");
            sl.Add("Anmol", "null");
            sl.Add("Raj", "Devops");
            sl.Add("Billy", "Kotlin");
            //sl.Add(null, "Kotlin");

            foreach (KeyValuePair<string, string> k in sl)
            {
                Console.WriteLine(k.Key+" "+k.Value);
            }

        }
    }
}
