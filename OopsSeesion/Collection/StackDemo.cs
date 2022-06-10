using System;
using System.Collections;
using System.Text;

namespace OopsSeesion.Collection
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            //Last in first out
            //Methods are Push,Pop,Peek.
            Stack st = new Stack();
            st.Push("om");
            st.Push("onkar");
            st.Push("karan");
            foreach(object ob in st)
            {
                Console.WriteLine(ob);
            }
            string d = (string)st.Pop();
            Console.WriteLine("Removed=="+d);

            Console.WriteLine("peek="+st.Peek());

            foreach(object ob in st)
            {
                Console.WriteLine(ob);
            }

        }
    }
}
