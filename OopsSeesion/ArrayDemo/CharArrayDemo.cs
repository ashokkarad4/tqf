using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'd', 't', 'r' };
            foreach(char c in ch)
            {
                Console.WriteLine(c+" ");
            }
            Console.WriteLine("//////////////////////");
            Console.WriteLine(String.Join(" ", ch));
        }
    }
}
