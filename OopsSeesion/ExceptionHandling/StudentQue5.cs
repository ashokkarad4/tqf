using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class ArrayList1
    {
        string hobbies;

        public ArrayList1(string hobbies)
        {
            this.Hobbies = hobbies;
        }

        public string Hobbies { get => hobbies; set => hobbies = value; }
        public void show()
        {
            Console.WriteLine(Hobbies+"  ");
        }
    }
    class Student3
    {
        int id;
        string name;
        ArrayList1 arr;

        public Student3(int id, string name, ArrayList1 arr)
        {
            this.Id = id;
            this.Name = name;
            this.Arr = arr;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal ArrayList1 Arr { get => arr; set => arr = value; }
        public void display()
        {
            Console.WriteLine(id+" "+name+" ");
            arr.show();
        }
    }
    class StudentQue5
    {
        static void Main(string[] args)
        {
            ArrayList1 a = new ArrayList1("Swimming");
            Student3 s = new Student3(1, "Ashok", a);
            Student3 s1 = new Student3(2, "Rahul", a);
            s.display();
            s1.display();



        }
    }
}
