using System;
using System.Collections;

namespace OopsSeesion.Collection
{
    class StudCustom
    {
        int sid;
        string nm;
        

        public StudCustom(int sid, string nm)
        {
            this.Sid = sid;
            this.Nm = nm;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Nm { get => nm; set => nm = value; }

        public override bool Equals(object obj)
        {
            return obj is StudCustom custom &&
                   sid == custom.sid &&
                   nm == custom.nm;
        }

        public override int GetHashCode()
        {
            return sid;
        }

        public override string ToString()
        {
            return sid + " " + nm + " ";
        }

    }
    class CustonKey
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(new StudCustom(1, "Rahul"), 45322452);
            ht.Add(new StudCustom(1, "Rahul"), 45322452);
            ht.Add(new StudCustom(1, "Rahul"), 45322452);
            ht.Add(new StudCustom(1, "Rahul"), 45322452);

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" ="+d.Value);
            }
        }
    }
}
