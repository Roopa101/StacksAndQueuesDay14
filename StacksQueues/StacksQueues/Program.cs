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
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);

           // linkedListQueue.Display();// this.top=this.top.next
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
            Console.ReadKey();
        }
    }
}
