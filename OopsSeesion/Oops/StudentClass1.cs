using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class StudentClass1
    {
        int id;
        string name = null;
        double marks;
        static void Main(string[] args)
        {
            StudentClass1 stu = new StudentClass1();
            stu.id = 101;
            stu.name = "Amit";
            stu.marks = 78.62;
            Console.WriteLine(stu.id + " " + stu.name + " " + stu.marks);


            StudentClass1 std = new StudentClass1();
            std.id = 200;
            std.name = "Neha";
            std.marks = 98.25;
            Console.WriteLine(std.id + " " + std.name + " " + std.marks);

        }
    }
}
