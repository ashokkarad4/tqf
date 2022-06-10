using System;
using System.Collections;

namespace OopsSeesion.ExceptionHandling
{
    class Que2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Ashok");
            al.Add("Rahul");
            al.Add("Rohit");
            al.Add("Java");
            al.Add("455");
            al.Add("45.25");

           al.Sort();
            foreach (string i in al)
            {
                Console.WriteLine(i+" ");
            }
            string reverse = " ";
            for(int i=al.Count-1;i>=0;i--)
            {
                reverse = reverse + al[i];
            }
            Console.WriteLine("reverse  "+reverse);
        }
    }
}
