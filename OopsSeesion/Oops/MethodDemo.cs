using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class MethodDemo
    {
        public void showData()
        {
            Console.WriteLine("hi i am show");
        }
        public void addition(int a,int b)
        {
            Console.WriteLine("Addition Is="+(a+b));
        }
        public string myFoo()
        {
            return "Hello";
        }
        public int add()
        {
            return 10+30;
        }
        public float areaOfCircle(int r,float PI)
        {
            float area = PI * r * r;
            return area;
        }

        static void Main(string[] args)
        {
            MethodDemo m = new MethodDemo();
            m.showData();
            m.addition(5, 5);
            /* String str = m.myFoo();
             Console.WriteLine(m.myFoo());*/
            Console.WriteLine(m.myFoo());

            int ans = m.add();
            Console.WriteLine(ans);

            float a = m.areaOfCircle(4, 3.14f);
            Console.WriteLine("Area of Circle="+a);
        }
    }
}
