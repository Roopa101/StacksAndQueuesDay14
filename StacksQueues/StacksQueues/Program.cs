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
            Queue linkedListQueue = new Queue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();// this.top=this.top.next
            Console.ReadKey();
        }
    }
}
