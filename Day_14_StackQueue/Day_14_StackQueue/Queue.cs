using Day14_StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_StackQueue
{
    internal class Queue : LinkedListStack
    {

        public Queue()
        {
            Console.WriteLine("welcome to Data structures Queue: ");
        }
        public void Enqueu(int value)
        {
            base.Append(value);
        }
        public void Display()
        {
            base.Display();
        }
    }
}



