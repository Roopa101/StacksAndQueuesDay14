﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksQueues
{
    class LinkedListQueue
    { 
          Node head;
          public void Enqueue(int data)
          {
              Node node = new Node(data);
              if (head == null)
              head = node;
              else
              {
                 Node temp = head;
                 while (temp.next != null)
                 {
                   temp = temp.next;
                 }
                 temp.next = node;

              }
              Console.WriteLine("Element {0} added to the Queue", node.data);
          }
          public Node Dequeue()
          {
               Node temp = head;
               if (temp == null)
               Console.WriteLine("Queue is empty");
               else
               {
               temp = temp.next;
               head = temp;
               }
               Console.WriteLine("First Element is deleted from queue", head.data);
               return head;
          }
          public void Display()
          {
           Node temp = this.head;
           if (temp == null)
           {
               Console.WriteLine("Queue is empty");
               return;

           }
           while (temp != null)
           {
             Console.Write(temp.data + " ");
             temp = temp.next;
           }
          }
    }
}




