using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class Coprime
    {
        static void Main(string[] args)
        {

            /*  int a = 15;
              int b = 8;
              //1,2,3,6
              int count = 0;
              for (int i = 1; i <= a && i <= b; i++)
              {
                  if (a % i == 0 && b % i == 0)
                  {
                      count++;

                  }
              }
              Console.WriteLine("Count=" + count);
              if (count == 1)
              {
                  Console.WriteLine("Co-Prime");
              }  */


            //Coprime pair

            int a = 15;
            //(5,24),(7,24)
            int j;
            for(int i=1;i<=a;i++)
            {
                int count = 0;
                for(j=1;j<=i;j++)
                {
                    if(a%j==0 && i%j==0)
                    {
                        count++;
                    }
                }
                if(count==1)
                {
                    Console.WriteLine($"Coprime pair is {i} {a}");
                }
            }

        }
    }
    
}
