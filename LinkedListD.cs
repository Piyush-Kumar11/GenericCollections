using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class LinkedListD
    {
        public static void LinkedListDemo()
        {
            LinkedList<string> s = new LinkedList<string>();
            s.AddLast("Hii");
            s.AddLast("Piyush");
            s.AddLast("Karan");
            s.AddLast("Devil");
            s.AddLast("Ayush");
            
            foreach(string g in s)
            {
                Console.WriteLine(g);
            }

        }
    }
}
