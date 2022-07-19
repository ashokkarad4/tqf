using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Collection
{
    class DictionaryQ6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> d = new Dictionary<string, float>();
            d.Add("Rahul", 63.58f);
            d.Add("Ashok", 78.55f);
            d.Add("ROhit", 65.78f);
            d.Add("Raj", 85.36f);

            foreach(KeyValuePair<string,float>k in d)
            {
                Console.WriteLine(k.Key+" =>"+k.Value);
            }
        }
    }
}
