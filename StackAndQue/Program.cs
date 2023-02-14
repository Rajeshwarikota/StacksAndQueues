using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Stacks and queues....");
            Stack stack = new Stack();
            Queues Queues = new Queues();
           
                Console.WriteLine("Please Choose \n1.Stack \n2.Queue \n3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.Add(56);
                        stack.Add(30);
                        stack.Add(70);
                        stack.Display();
                        stack.isEmpty();
                        stack.Display();
                        break;
                    case 2:
                        Queues.Enqueue(56);
                        Queues.Enqueue(30);
                        Queues.Enqueue(70);
                        Queues.Display();
                        break;
                   
                    default:
                        Console.WriteLine("Choose the Correct Number !");
                        break;
               }
            Console.ReadLine();
        }
    }
}
