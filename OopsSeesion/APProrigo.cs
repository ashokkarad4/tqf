using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class APA
    {
        public static void airthProgression(int a2,int a3,int n)
        {
            int diff = a3 -a2;
            for(int i=4;i<=n;i++)
            {
                a3 = a3 + diff;
            }
            Console.WriteLine(3);
        }
    }
    class APProrigo
    {
        static void Main(string[] args)
        {
            APA.airthProgression(1, 2, 4);
        }
    }
}
