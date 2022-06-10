using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentInheritance
{
    
    class OverLoadMethodVolume
    {
        void volume(double r)
        {
            double ans = 4 / 3 * 22 / 7 * r * 3;
            Console.WriteLine("Volume of Sphere=" + ans);
        }
        void volume(double h, double r)
        {
            double ans = 22 / 7 * r * 2 * h;
            Console.WriteLine("Volume Of a cylinder=" + ans);
        }
        void volume(double l, double b, double h)
        {
            double ans = l * b * h;
            Console.WriteLine("Volume of cuboid="+ans);
        }
        static void Main(string[] args)
        {
            OverLoadMethodVolume v = new OverLoadMethodVolume();
            v.volume(2.5);
            v.volume(5.8, 4.2);
            v.volume(5.1, 7.8, 4.4);
        }
    }
}

