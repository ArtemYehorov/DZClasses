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
        public delegate void WorkWithGroup(Group a, int index);
        static void Main()
        {
            Group g = new Group(true, 3);

            WorkWithGroup r = AddStudentForDelegate;

            void AddStudentForDelegate(Group a, int index)
            {
                a.AddStudent(new Student(),0);
            }

            void RemoveStudentForDelegate(Group a, int index)
            {
               a.RemoveStudent(index);
            }

            void PrintGroup(Group a, int index)
            {
                foreach (Student item in a)
                {
                    item.Print();
                }
            }

            void Exit(Group a, int index)
            {
                Environment.Exit(0);
            }

            while (true)
            {
                Console.WriteLine("Выберите действие: \n1 - добавить студента \n2 - удалить студента \n3 - показать список студентов \n4 - выход из приложения");
                string num = Console.ReadLine();
                if (num == "1")
                {
                    r -= RemoveStudentForDelegate;
                    r -= PrintGroup;
                    r -= Exit;
                    r += AddStudentForDelegate;
                    r(g, 2);
                }
                else if (num == "2")
                {
                    r += RemoveStudentForDelegate;
                    r -= PrintGroup;
                    r -= Exit;
                    r -= AddStudentForDelegate;
                    r(g, 1);
                }
                else if (num == "3")
                {
                    r -= RemoveStudentForDelegate;
                    r += PrintGroup;
                    r -= Exit;
                    r -= AddStudentForDelegate;
                    r(g, 1);
                }
                else if (num == "4")
                {
                    r -= RemoveStudentForDelegate;
                    r -= PrintGroup;
                    r += Exit;
                    r -= AddStudentForDelegate;
                    r(g, 1);
                }
            }
            //g.Print();
            //Console.WriteLine();

            //foreach (var item in g)
            //{
            //    (item as Student).Print();
            //}

            //Group w = new Group(true,10);
            //w.Print();
            //Console.WriteLine();

            //Student q = new BadStudent();
            //Student a = new BadStudent();
            //Student e = new AverageStudent();
            //Student y = new GoodStudent();

            //g.AddStudent(q);
            //g.AddStudent(y);
            //g.AddStudent(e);

            //g.Print();
            //Console.WriteLine(e["Exams", 0]);
            //Console.WriteLine(e["TermPapers", 1]);
            //Console.WriteLine(e["OffSet", 2]);
            //g[5] = a;
            //Console.WriteLine();

            //if (y > e)
            //{
            //    Console.WriteLine("Студент y");
            //    y.Print();
            //}
            //else
            //{
            //    Console.WriteLine("Студент е");
            //    e.Print();
            //}

            Console.ReadLine();
         
        }
    }
}