using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    interface ICircle
    {
        void CalculateArea(int r);
    }
    class ABC:ICircle
    {
        public void CalculateArea(int r)
        {
           double area = 3.14f * r * r;
            Console.WriteLine("Area of Circle="+area);
        }
    }
    class InterfaceImplementaion
    {
        static void Main(string[] args)
        {
            ICircle c = new ABC();
            c.CalculateArea(5);
        }
    }
}
