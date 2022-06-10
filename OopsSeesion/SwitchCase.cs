using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class SwitchCase
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("1.Area of Circle");
            Console.WriteLine("2.Area of rectangle");
            Console.WriteLine("3.Ara of Square");
            Console.WriteLine("Enter Choice");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1: Console.WriteLine("Enter Radius");
                    int r = int.Parse(Console.ReadLine());
                    float C = 3.14f * r * r;
                    Console.WriteLine("Area of Circle ="+C);
                    break;
                case 2:
                    Console.WriteLine("Enter Length");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width");
                    int w = int.Parse(Console.ReadLine());
                    float R = l*w;
                    Console.WriteLine("Area of Rectangle =" + R);
                    break;
                case 3:
                    Console.WriteLine("Enter Side");
                    int s = int.Parse(Console.ReadLine());
                    int S= s*s;
                    Console.WriteLine("Area of Square =" + S);
                    break;
                default: Console.WriteLine("Invalid coice");
                    break;


            }
        }
    }
}
