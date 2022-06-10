using System;
using System.Collections;

namespace OopsSeesion.Collection
{
    class Stud
    {
        int id;
        string name;

        public Stud(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return id + " " + name + " ";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
    class Hashtable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Ketki", 90);
            ht.Add("sonam", 94);
            ht.Add(23, "tatt");
            ht.Add(new Stud(1, "priya"), "priya@gmail.com");
            Console.WriteLine(ht[23]);
            ht["sonam"] = 95;
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+"=>"+d.Value);
            }
            Console.WriteLine("********************");
            foreach(var k in ht.Keys)
            {
                Console.WriteLine(k+" --->"+ht[k]);
            }
            Console.WriteLine(ht.ContainsKey(584));
            Console.WriteLine(ht.ContainsValue("sonam"));
        }
    }
}
