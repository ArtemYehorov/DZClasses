using System;
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
            Student a = new Student();
            a.AddExams(0);
            a.Print();

            //Group g = new Group();
            //g.Print();
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}