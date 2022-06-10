using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class Exceotion2
    {
        static void divide(int a,int b)
        {
            Console.WriteLine("Division=" + a / b);

            /*  try
              {
                  Console.WriteLine("Division=" + a / b);
              }
              catch(DivideByZeroException e)
              {
                  Console.WriteLine(e.Message);
              }*/
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            try
            {
                divide(10, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main Ends");
        }
    }
}
