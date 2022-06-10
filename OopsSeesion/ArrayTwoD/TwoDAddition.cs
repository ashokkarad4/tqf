using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayTwoD
{
    class TwoDAddition
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,]a= new int[2, 2];
            Console.WriteLine("Enter 1st Array Elements");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("/////////////////////////");
            Console.WriteLine("Enter 2nd Array Elements");
            int[,] b = new int[2, 2];

            for (int i=0;i<b.GetLength(0);i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("................................");
           
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i,j]+" ");               
                }
                Console.WriteLine();
            }
            Console.WriteLine("...........................");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = a[i, j] + b[i, j];
                    Console.Write(sum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
