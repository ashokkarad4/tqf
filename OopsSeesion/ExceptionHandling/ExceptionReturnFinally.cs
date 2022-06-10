using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class ExceptionReturnFinally
    {
        static int divide(int a,int b)
        {
            try
            {
                Console.WriteLine("In division");
                return a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            int result = divide(10, 0);
            Console.WriteLine("Answer="+result);
            Console.WriteLine("Main ends");
        }
    }
}
