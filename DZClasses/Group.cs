﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZClasses
{
    /// <summary>
    /// Это группа для массива студентов.
    /// </summary>
    internal class Group : ICloneable, IComparable<Group>, IEnumerable
    {
        private ArrayList group = new ArrayList();
        private string NameOfCourse;
        private string Groupspecialization;
        private string NumberOfCourse;

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(group);
        }

        public int CompareTo(Group some_another_group) // реализация интерфейса
        {
            if (this.group.Count > some_another_group.group.Count) return 1;
            if (this.group.Count < some_another_group.group.Count) return -1;
            return 0;
        }

        public Group ShallowClone() // поверхностная копия
        {
            return (Group)this.MemberwiseClone();
        }

        public object Clone() // пользовательская копия
        {
            return new Group(this.group,this.NameOFCourse,this.Groupspecialization,this.NumberOFCourse);
        }
        public static bool operator ==(Group obj1, Group obj2)
        {
            if (obj1.group.Count == obj2.group.Count)
                return true;
            return false;
        }

        public static bool operator !=(Group obj1, Group obj2)
        {
            if (obj1.group.Count == obj2.group.Count)
                return true;
            return false;
        }

        public Student this[int index]
        {
            get { return group[index] as Student; }
            set { group[index] = value; }
        }

        public Group(ArrayList g,string NameC,string Cpes,string NumberC)
        {
            this.group = g;
            NameOFCourse = NameC;
            NumberOFCourse = NumberC;
            Groupspecialization = Cpes;
        }

        /// <summary>
        /// Конструктор без параметров группы без оценок.
        /// </summary>
        public Group()
        {
            for (int i = 0; i < 11; i++)
            {
                group.Add(new Student());
            }
            NameOFCourse = "PU111";
            NumberOFCourse = "111";
            Groupspecialization = "Разработка програмного обеспечения";
        }

        /// <summary>
        /// Конструктор c параметром группы с оценками.
        /// </summary>
        public Group(bool t)
        {
            Random random = new Random();
            for (int i = 0; i < 11; i++)
            {
                int AP = random.Next(0, 3);
                System.Threading.Thread.Sleep(1);
                if (AP == 0)
                {
                    group.Add(new BadStudent());
                }
                else if (AP == 1)
                {
                    group.Add(new AverageStudent());
                }
                else if (AP == 2)
                {
                    group.Add(new GoodStudent());
                }
                else
                {
                    group.Add(new Student());
                }
            }
            NameOFCourse = "PU111";
            NumberOFCourse = "111";
            Groupspecialization = "Разработка програмного обеспечения";
        }

        /// <summary>
        /// Конструктор c параметрами группы int - количество студентов, bool - с оценками.
        /// </summary>
        public Group(bool t,int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int AP = random.Next(0, 3);
                System.Threading.Thread.Sleep(1);
                if (AP == 0)
                {
                    group.Add(new BadStudent());
                }
                else if (AP == 1)
                {
                    group.Add(new AverageStudent());
                }
                else if (AP == 2)
                {
                    group.Add(new GoodStudent());
                }
                else
                {
                    group.Add(new Student());
                }
            }
            NameOFCourse = "PU111";
            NumberOFCourse = "111";
            Groupspecialization = "Разработка програмного обеспечения";
        }

        /// <summary>
        /// Конструктор копировани. Создаёт группу, точную копию другой группы.
        /// </summary>
        /// <param name="g">Другая группа</param>
        public Group(Group g)
        {
            this.group = g.group;
            this.NumberOFCourse = g.NumberOFCourse;
            this.NameOFCourse = g.NameOFCourse;
            this.GroupSpecialization = g.GroupSpecialization;
        }

        /// <summary>
        /// Конструктор, создаёт группу с указанным количеством студентов.
        /// </summary>
        /// <param name="count">Количество студентов</param>
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

        /// <summary>
        /// конструктор, создаёт группу по указанному массиву студентов.
        /// </summary>
        /// <param name="group">Массив студентов</param>
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

        /// <summary>
        /// Свойство Названия Курса.
        /// </summary>
        public string NameOFCourse
        {
            get { return NameOfCourse; }
            set { NameOfCourse = value; }
        }

        /// <summary>
        /// Свойство Специализации Группы.
        /// </summary>
        public string GroupSpecialization
        {
            get { return Groupspecialization; }
            set { Groupspecialization = value; }
        }

        /// <summary>
        /// Свойство Номера Курса.
        /// </summary>
        public string NumberOFCourse
        {
            get { return NumberOfCourse; }
            set { NumberOfCourse = value; }
        }

        /// <summary>
        /// Удаление студента по Именни и Фамилиии
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        public void RemoveStudent(string name, string surname)
        {
            for (int i = 0; i < group.Count; i++)
            {
                if ((group[i] as Student).Name == name && (group[i] as Student).Surname == surname)
                {
                    group.Remove(i);
                }
            }
        }

        public void AddStudent(Student pe)
        {
            group.Add(pe);
        }

        /// <summary>
        /// Перенос студента из одной группы в другую, по имени и фамилии.
        /// </summary>
        /// <param name="g">Другая группа</param>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        public void StudentTransfer(Group g, string name, string surname)
        {
            for (int i = 0; i < group.Count; i++)
            {
                if ((group[i] as Student).Name == name && (group[i] as Student).Surname == surname)
                {
                    g.group.Add(this.group[i]);
                    this.group.Remove(i);
                }
            }
        }

        /// <summary>
        /// Вывод в консоль информации о группе.
        /// </summary>
        public void Print()
        {
            Console.WriteLine(NameOFCourse);
            Console.WriteLine(NumberOFCourse);
            Console.WriteLine(Groupspecialization);
            Console.WriteLine();
            for (int i = 0; i < group.Count; i++)
            {
                Console.Write(i+1 + "# ");
                (group[i] as Student).Print();
            }
        }

        //public void ExpulsionOfDoNotPassExam()
        //{

        //}

        public Student ExpulsionOfFailingStudent()
        {
            // делаем предположение, что у первого поавшегося студента группы - минимальнй средний балл
            double min_average = (group[0] as Student).GetAverageRateOffSet();
            int current_index = 0; // на каком номере студента из группы мы находимся сейчас (перебор начинается с начала группы)
            Student bad = (group[0] as Student); // ссылка на студента у которого средний балл - минимальный
            for (int i = 0; i < group.Count; i++)
            {
                double current_avg = (group[i] as Student).GetAverageRateOffSet();
                if (current_avg < min_average)
                {
                    min_average = current_avg;
                    bad = (group[i] as Student);
                }
                current_index++;
            }

            group.Remove(bad);
            return bad;
        }
    }
}
