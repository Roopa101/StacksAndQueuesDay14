using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class Program
    {
        //entry point of the execution
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            //linkedListStack.Peek(); top.data
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            Console.ReadKey();
        }
    }
}
