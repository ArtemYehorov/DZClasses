using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZClasses
{
    internal class Group
    {
        private ArrayList group = new ArrayList();
        private string NameOfCourse;
        private string Groupspecialization;
        private string NumberOfCourse;
        public Group()
        {
            for (int i = 0; i < 12; i++)
            {
                group.Add(new Student());
            }
            NameOFCourse = "PU111";
            NumberOFCourse = "111";
            Groupspecialization = "Разработка програмного обеспечения";
        }

        public Group(Group g)
        {
            this.group = g.group;
            this.NumberOFCourse = g.NumberOFCourse;
            this.NameOFCourse = g.NameOFCourse;
            this.GroupSpecialization = g.GroupSpecialization;
        }

        public Group(int count)
        {
            for (int i = 0; i < count; i++)
            {
                group.Add(new Student());
            }
            NameOFCourse = "PU111";
            NumberOFCourse = "111";
            Groupspecialization = "Разработка програмного обеспечения";
        }

        public Group(ArrayList group)
        {
            for (int i = 0; i < group.Count; i++)
            {
                this.group.Add(group[i]);
            }
            NameOFCourse = "PU111";
            NumberOFCourse = "111";
            Groupspecialization = "Разработка програмного обеспечения";
        }

        public string NameOFCourse
        {
            get { return NameOfCourse; }
            set { NameOfCourse = value; }
        }

        public string GroupSpecialization
        {
            get { return Groupspecialization; }
            set { Groupspecialization = value; }
        }

        public string NumberOFCourse
        {
            get { return NumberOfCourse; }
            set { NumberOfCourse = value; }
        }

        public void RemoveStudent(string name, string surname)
        {
            for (int i = 0; i < group.Count; i++)
            {
                if ((group[i] as Student).GetName() == name && (group[i] as Student).GetSurname() == surname)
                {
                    group.Remove(i);
                }
            }
        }

        public void StudentTransfer(Group g, string name, string surname)
        {
            for (int i = 0; i < group.Count; i++)
            {
                if ((group[i] as Student).GetName() == name && (group[i] as Student).GetSurname() == surname)
                {
                    g.group.Add(this.group[i]);
                    this.group.Remove(i);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(NameOFCourse);
            Console.WriteLine(NumberOFCourse);
            Console.WriteLine(Groupspecialization);
            for (int i = 0; i < 12; i++)
            {
                Console.Write(i+1 + " ");
                (group[i] as Student).Print();
            }
        }

        //public void ExpulsionOfDoNotPassExam()
        //{

        //}

       //public void ExpulsionOfFailingStudent()
       //{

       //}
    }
}
