using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class Recursion
    {
        static void bye()
        {
            Console.WriteLine("bye bye");
        }
        static void greet(int n)
        {
            Console.WriteLine("Good Morning");
            if(n<=1)
            {
                greet(n-1);

            }
            Console.WriteLine("Greet Ends");
        }
        static void Main(string[] args)
        {
            Recursion.greet(3);
            Console.WriteLine("Main ends");
        }
    }
}
