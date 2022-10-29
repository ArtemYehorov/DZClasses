﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Delegate WorkWithGroup
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="index">The index.</param>
        public delegate void WorkWithGroup(Group a, int index);
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        static void Main()
        {
            //Group g = new Group(true, 3);
            //g.Print();
            Student a = new AverageStudent();
            Group e = new Group(true,3);
            // a.Avtomat += AvtomatExams;
            FileSaver r = new FileSaver();
            r.SaveStudent(a);
            r.SaveGroup(e);
            //Student bq = new BadStudent();
            //Student bw = new BadStudent();
            //Student be = new BadStudent();
            //Student br = new BadStudent();

            //Student c = new GoodStudent();
            //g.AddStudent(a);
            //g.AddStudent(c);
            //g.AddStudent(bq);
            //g.AddStudent(bw);
            //g.AddStudent(be);
            //g.AddStudent(br);

            //g.Print();
            Console.ReadLine();

        }

        //static void AvtomatExams(Student sendler, StudentEventAvtomat t)
        //{
        //    sendler.AddExams(t.GetAvtomat());
        //}

        //static void AvtomatExams(Student sendler, StudentEventProspal t)
        //{
        //  Console.WriteLine("Причина отсутствия: " + t.ReasonAbsence)
        //}
    }
}

//WorkWithGroup r = AddStudentForDelegate;

//void AddStudentForDelegate(Group a, int index)
//{
//    a.AddStudent(new Student(),0);
//}

//void RemoveStudentForDelegate(Group a, int index)
//{
//   a.RemoveStudent(index);
//}

//void PrintGroup(Group a, int index)
//{
//    foreach (Student item in a)
//    {
//        item.Print();
//    }
//}

//void Exit(Group a, int index)
//{
//    Environment.Exit(0);
//}

//while (true)
//{
//    Console.WriteLine("Выберите действие: \n1 - добавить студента \n2 - удалить студента \n3 - показать список студентов \n4 - выход из приложения");
//    string num = Console.ReadLine();
//    if (num == "1")
//    {
//        r -= RemoveStudentForDelegate;
//        r -= PrintGroup;
//        r -= Exit;
//        r += AddStudentForDelegate;
//        r(g, 2);
//    }
//    else if (num == "2")
//    {
//        r += RemoveStudentForDelegate;
//        r -= PrintGroup;
//        r -= Exit;
//        r -= AddStudentForDelegate;
//        r(g, 1);
//    }
//    else if (num == "3")
//    {
//        r -= RemoveStudentForDelegate;
//        r += PrintGroup;
//        r -= Exit;
//        r -= AddStudentForDelegate;
//        r(g, 1);
//    }
//    else if (num == "4")
//    {
//        r -= RemoveStudentForDelegate;
//        r -= PrintGroup;
//        r += Exit;
//        r -= AddStudentForDelegate;
//        r(g, 1);
//    }
//}
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
