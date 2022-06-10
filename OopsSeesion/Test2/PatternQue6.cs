using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    /*
1
22
333
4444
55555
    */

    class PatternQue6
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
               for(int j=1;j<=i;j++)
               {
                    Console.Write(i);
               }
                Console.WriteLine();
            }
            
        }
    }
}
