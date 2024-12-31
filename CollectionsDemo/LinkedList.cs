using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinkedList
    {
        public void LinkedListDemo()
        {
            var names = new LinkedList<string>();
            names.AddLast("a");
            names.AddLast("b");
            names.AddFirst("c");
            names.AddFirst("d");
            foreach (var name in names) { Console.WriteLine(name); }
            LinkedListNode<string> node = names.Find("c");
            names.AddBefore(node, "Rupesh");
            Console.WriteLine("After adding");
            foreach (var name in names) { Console.WriteLine(name); }
            Console.WriteLine(names.LastOrDefault());
            names.Order();
            Console.WriteLine("-------------------------");
            foreach (var name in names) { Console.WriteLine(name); }

        }
    }
}
