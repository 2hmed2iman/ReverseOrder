using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace ReversedLinkedList
{
    class program
    {
        static void Main(string[] args)
        {
            //Type A

            Console.Write("Enter The Number Of Elements: ");

            var ElementNum = int.Parse(Console.ReadLine());

            LinkedList<string> xXI6O9IXx = new LinkedList<string>();

            Console.WriteLine();

            for (int i = 1; i <= ElementNum; i++)
            {
                Console.Write($"Enter Element {i} : ");

                var LinkedListElements = Console.ReadLine();

                xXI6O9IXx.AddLast(LinkedListElements);

                Console.WriteLine();
            }

            Console.Write("The linked List Before Reversing: \n\n => ");

            foreach (var item in xXI6O9IXx)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine("\n");

            Console.Write("The linked List After Reversing: \n\n => ");

            foreach (var item in xXI6O9IXx.Reverse())
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");


            //Type B

            //LinkedList<string> xX6O9Xx = new LinkedList<string>();

            ////LinkedListNode<string> xXOOXx = new LinkedListNode<string>("Aiman");
            ////xX6O9Xx.AddFirst(xXOOXx);

            ////LinkedListNode<string> xXOOXx = new LinkedListNode<string>("");
            ////xXOOXx.Value = "Aiman";
            ////xX6O9Xx.AddFirst(xXOOXx);

            ////var xXOOXx = xX6O9Xx.AddFirst("Aiman");

            //LinkedListNode<string> xXOOXx = xX6O9Xx.AddFirst("Aiman");

            //xX6O9Xx.AddLast("Hafez");
            //xX6O9Xx.AddAfter(xXOOXx, "Mohamed");
            //xX6O9Xx.AddBefore(xXOOXx, "Ahmed");
            //xX6O9Xx.AddLast("Mohamed");

            //Console.WriteLine("The linked List Before Reversing: \n ");
            ////Console.WriteLine();

            //foreach (var item in xX6O9Xx)
            //{
            //    //Console.Write("{0} \n", item);
            //    //Console.WriteLine(item);

            //    //Console.Write("{0} \t", item);
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n\n");
            ////Console.WriteLine("================================");

            //Console.WriteLine("The linked List After Reversing: \n ");
            ////Console.WriteLine();

            //foreach (var item in xX6O9Xx.Reverse())
            //{
            //    //Console.Write("{0} \n", item);
            //    //Console.WriteLine(item);

            //    //Console.Write("{0} \t", item);
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();
            ////Console.WriteLine("================================");

            Console.ReadKey();
        }

    }
}
