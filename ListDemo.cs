using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class ListD
    {
        public static void ListDemo()
        {
            List<int> list = new List<int>();   
            //insertion order is maintained
            list.Add(1);
            list.Add(5);
            list.Add(88);
            //list.Add(45.8);Only Int type data can be stored
            list.Add(8);
            list.Add(6);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //==========Or=============
            //foreach (var i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //==========Or=============
            foreach (object i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
