using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    internal class Program
    {
        static void Main()
        {
            Group g = new Group(3);
            g.Print();
            Console.WriteLine();

            Group w = new Group(true,10);
            w.Print();
            Console.WriteLine();

            Student q = new BadStudent();
            Student a = new BadStudent();
            Student e = new AverageStudent();
            Student y = new GoodStudent();
            g.AddStudent(q);
            g.AddStudent(y);
            g.AddStudent(e);
           
            g.Print();
            Console.WriteLine(e["Exams", 0]);
            Console.WriteLine(e["TermPapers", 1]);
            Console.WriteLine(e["OffSet", 2]);
            g[5] = a;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}