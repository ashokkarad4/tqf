using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.DelegatesDemo
{
    public delegate void mydel(int x, int y);
    public delegate void mydel2(string b);
    class DelegatesDeclaration
    {
        static void add(int a,int b)
        {
            Console.WriteLine("Addition="+(a+b));
        }


        void greet(string nm)
        {
            Console.WriteLine("Welcome  "+nm);
        }
        
        static void product(int a,int b)
        {
            Console.WriteLine("Product="+(a*b));
        }
        static void Main(string[] args)
        {
            DelegatesDeclaration d = new DelegatesDeclaration();
            //Single Cast Delegate
            /*  mydel d1 = DelegatesDeclaration.product;
             // d1.Invoke(10, 20);
              d1(20, 20); */

            //MUltiCast Delwegate
            mydel d1 = DelegatesDeclaration.product;
            d1 += add;
            d1(10, 20);

            mydel2 d2 = d.greet;
            d2("Ashok");
        }
    }
}
