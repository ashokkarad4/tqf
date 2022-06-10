using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class UniqueElements
    {
        static void Main(string[] args)
        {
            int[] a = { 4,3,2,4,9,2 };
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if(isVisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if(a[i]==a[j])
                        {
                            count++;
                        }
                    }
                   // if(count==1)
                        if(count>1) //DuplicateElements
                    {
                        Console.WriteLine(a[i]+" ");
                    }
                }
            }
        }
    }
}
