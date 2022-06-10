using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class BoxArea
    {
        int l;
        static void Main(string[] args)
        {
            BoxArea b = new BoxArea();
            b.l = 20;
            float area;
            area = 6 * (b.l * b.l);
            Console.WriteLine(area);
        }
    }
}
