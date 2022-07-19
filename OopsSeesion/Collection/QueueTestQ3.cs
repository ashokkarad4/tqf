using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Collection
{
    class QueueTestQ3
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("red");
            q.Enqueue("White");
            q.Enqueue("Green");
            q.Enqueue("Black");
            q.Enqueue("Violet");
            foreach (string dd in q)
            {
                Console.WriteLine(dd);
            }
            string d = (string)q.Dequeue();
            Console.WriteLine("Remove=" + d);

            Console.WriteLine("/////////////////////////");
            Console.WriteLine("peek=" + q.Peek());
            foreach (string dl  in q)
            {
                Console.WriteLine(dl);
            }
        }
    }
}
