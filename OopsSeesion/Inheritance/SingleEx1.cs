using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Inheritance
{
    class Bird
    {
        public string color="Green" ;
      
    }
    class Parrot : Bird
    {
        public void show()
        {
            Console.WriteLine(color);
        }
    }
    class SingleEx1
    {
        static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.show();

        }
    }
}
