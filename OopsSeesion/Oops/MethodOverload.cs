using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    class MethodOverload
    {
        void calculate(float r)
        {
            float area = 3.14f * r * r;
            Console.WriteLine("Area Of Circle="+area);
        }
        void calculate(int l,int b)
        {
            int area = 2*(l * b);
            Console.WriteLine("Area of Rectangle="+area);
        }
        void calculate(double x,double y)
        {
            double area =(x*y)/2;
            Console.WriteLine("Arae of Triangle="+area);

        }
        void calculate(int a)
        {
            int area = a * a;
            Console.WriteLine("Area of Square="+area);
        }
        static void Main(string[] args)
        {
            MethodOverload m = new MethodOverload();
            m.calculate(3.8f);
            m.calculate(6, 4);
            m.calculate(4.5f, 3.5f);
            m.calculate(5);
        }
    }
}
