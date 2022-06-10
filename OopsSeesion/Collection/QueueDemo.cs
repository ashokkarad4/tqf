using System;
using System.Collections;
using System.Text;

namespace OopsSeesion.Collection
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            //First in first out
            //Metthods are Enqueue,Dequeue,Peek
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(50);
            q.Enqueue(90);
            foreach (object ob in q)
            {
                Console.WriteLine(ob);
            }
            int d = (int)q.Dequeue();
            Console.WriteLine("Remove="+d);

            Console.WriteLine("/////////////////////////");
            Console.WriteLine("peek=" + q.Peek());
            foreach (object ob in q)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
