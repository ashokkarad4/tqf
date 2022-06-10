using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingnmentCondiStatement
{
    class GrossSalary
    {
        static void Main(string[] args)
        {
            int basicsal, grosssal, hra, da;
            Console.WriteLine("Enter the basic salary of the Employee");
            basicsal = int.Parse(Console.ReadLine());
            if (basicsal <= 10000)
            {
                hra = basicsal * 20 / 100;
                da = basicsal * 80 / 100;
                grosssal = basicsal + hra + da;
                Console.WriteLine("GrossSalary: " + grosssal);
            }
            else if (basicsal <= 20000)
            {
                hra = basicsal * 25 / 100;
                da = basicsal * 90 / 100;
                grosssal = basicsal + hra + da;
                Console.WriteLine("GrossSalary: " + grosssal);
            }
            else if (basicsal > 20000)
            {
                hra = basicsal * 30 / 100;
                da = basicsal * 95 / 100;
                grosssal = basicsal + hra + da;
                Console.WriteLine("GrossSalary: " + grosssal);
            }
            else
            {
                Console.WriteLine("No Gross Salary");
            }
        }
    }
}
