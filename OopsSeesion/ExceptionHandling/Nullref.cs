using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class Student
    {
        int rno;
        string name;

        public Student(int rno, string name)
        {
            this.Rno = rno;
            this.Name = name;
        }

        public int Rno { get => rno; set => rno = value; }
        public string Name { get => name; set => name = value; }
    }
    class Nullref
    {
        static void Main(string[] args)
        {
            Student[] sarr = new Student[3];
            sarr[0] = new Student(1, "rohan");
            Console.WriteLine(sarr[0].Name);
            try
            {
               
                Console.WriteLine(sarr[1].Name);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
