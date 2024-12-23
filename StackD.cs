using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class StackD
    {
        public static void StackDemo()
        {
            Stack<string> s = new Stack<string>();
            s.Push("Hello");
            s.Push("Piyush");
            s.Push("Kumar");
            s.Push("Bye");
            s.Push("Java");
            //In LIFO / FILO order
            foreach(string ss in s)
            {
                Console.WriteLine(ss);
            }

        }
    }
}
