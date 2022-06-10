using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    class Student
    {
        int id;
        string name;
        int age;
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
     
        public Student(int i, string n, int a)
        {
            id = i;
            name = n;
            age = a;

        }
        public void display()
        {
            Console.WriteLine("Id " + id + "Name " + name + "Age " + age);
        }
    }
    class ConstructorOver
    {
        static void Main(string[] args)
        {
            Student s = new Student(101, "Sagar");
            Student s1 = new Student(102, "Rahul", 25);
            s.display();
            s1.display();
        }
    }
}
