using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class StackDemo
    {
        public void stackDemo()
        {
            Stack<string> stack = new Stack<string>();
            Stack<string> stack1 = new Stack<string>();
            string[] names = { };
            stack.Push("atul");
            stack.Push("ankit");
            stack.Push("anjali");
            stack1.Push("atul");
            stack1.Push("ankit");
            stack1.Push("bumrah");
            stack1.Push("banawar");
            Console.WriteLine("Loop is executing");
            foreach (var item in stack) { Console.WriteLine(item); }
            Console.WriteLine("Loop is Done");
            Console.WriteLine("Pop is:");
            stack.Pop();
            Console.WriteLine("Peek is:");
            Console.WriteLine("peekElement"+ stack.Peek());
            Console.WriteLine("Checking is:");
            Console.WriteLine(stack.Contains("atul"));
            stack.Append("alankruta");
            //stack.CopyTo(names, 0);
            Console.WriteLine(stack.ElementAt(0));
            Console.WriteLine(stack.Equals(stack1));
            Console.WriteLine(stack.Except(stack1));
        }
    }
}
