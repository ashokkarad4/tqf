using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class AutoBoxUnboxing
    {
        static void Main(string[] args)
        {
            int a = 10;
            object ob = a;//Autoboxing Converting primitive to object automatically
            int d = (int)ob;//Unboxing object to primitive
        }
    }
}
