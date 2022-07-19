using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Collection
{
    class StackQ7
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("KGF");
            s.Push("Pushpa");
            s.Push("Bharat");
            s.Push("Pandu");
            s.Push("Panchayat");
            Console.WriteLine(s.Pop());
            Console.WriteLine("////////////");
            //Console.WriteLine(s.Peek());
            foreach(string d in s)
            {
                Console.WriteLine(d);
               
            }
           // Console.WriteLine("//////////////////");
           // Console.WriteLine(s.Pop());
        }
    }
}
