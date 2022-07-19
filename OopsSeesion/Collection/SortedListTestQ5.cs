using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Collection
{
    class SortedListTestQ5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Rohit");
            sl.Add(5, "Rahul");
            sl.Add(8, "Onkar");
            sl.Add(7, "Ajay");
     
            foreach(KeyValuePair<int,string> k in sl )
            {
                Console.WriteLine(k.Key+" =>"+k.Value);
            }
        }
    }
}
