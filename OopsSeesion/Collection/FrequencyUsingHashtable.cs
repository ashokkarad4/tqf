using System;
using System.Collections;

namespace OopsSeesion.Collection
{
    class FrequencyUsingHashtable
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "sun","mon","tue","sun","tue","sat"
            };
            string s="Ashokkard";
            char[] carr = s.ToCharArray();
            Hashtable ht = new Hashtable();

            foreach(dynamic data in al)
            {
                if(ht.ContainsKey(data))
                {
                    int value = (int)ht[data];
                    ht[data] = value + 1;
                }
                else
                {
                    ht.Add(data, 1);
                }
            }
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" ="+d.Value);
            }
        }
    }
}
