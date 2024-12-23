using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class QueueD
    {
        public static void QueueDemo()
        {
            Queue<char> c = new Queue<char>();
            c.Enqueue('C');
            c.Enqueue('T');
            c.Enqueue('A');
            c.Enqueue('P');
            //FIFO / LILO order
            foreach(char i in c)
            {
                Console.WriteLine(i);
            }
        }
    }
}
