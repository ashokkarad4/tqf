using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayTwoD
{
    class ZerolLast
    {

        static void Main(string[] args)
        {
            int[] a = { 6, 0, 8, 2, 3, 0, 4, 0, 1 };
           
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]<a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]+" ");
            }
        }
    }
}
