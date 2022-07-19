using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Collection
{
    class Emp
    {
        int id;
        string name;
        double sal;

        public Emp(int id, string name, double sal)
        {
            this.Id = id;
            this.Name = name;
            this.Sal = sal;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Sal { get => sal; set => sal = value; }

        public override bool Equals(object obj)
        {
            return obj is Emp emp &&
                   id == emp.id &&
                   name == emp.name &&
                   sal == emp.sal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, sal);
        }
    }
    class HashSetQ4
    {
        static void Main(string[] args)
        {
            HashSet<Emp> hs = new HashSet<Emp>();
            hs.Add(new Emp(101, "John", 45000));
            hs.Add(new Emp(102, "Abraham", 55000));
            hs.Add(new Emp(101, "John", 45000));
            hs.Add(new Emp(103, "Akshay", 800000));
            foreach(Emp e in hs)
            {
                Console.WriteLine(e.Id+" "+e.Name+" "+e.Sal+" ");
            }
        }
    }
}
