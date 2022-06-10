using System;
using System.Collections;

namespace OopsSeesion.Collection
{
    class ArraylistDeclaraton
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            
            al.Add(100);
            al.Add("rahul");
            al.Add(9.55);
            al.Add(900);
            al.Add(200);
            al.Add(87654);
            al.Insert(1, "ashok");
            al.Remove(900);
            al.RemoveAt(1);
            al.Reverse();
            al[2] = 1000;
            

            foreach (var i in al)
                Console.WriteLine(i);
            
            Console.WriteLine("...........................");
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
                    
        }
    }
}
