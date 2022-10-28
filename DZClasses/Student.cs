

using DZClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

/// <summary>
/// Class LackOfGradesException.
/// Implements the <see cref="ApplicationException" />
/// </summary>
/// <seealso cref="ApplicationException" />
class LackOfGradesException : ApplicationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LackOfGradesException"/> class.
    /// </summary>
    public LackOfGradesException() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LackOfGradesException"/> class.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    public LackOfGradesException(string message) : base(message) { }
}

//internal class StudentEventProspal
//{
//    public string ReasonAbsence { get; set; }

//    public StudentEventProspal(string r)
//    {
//        this.ReasonAbsence = r;
//    }

//    public string ReasonForAbsence()
//    {
//        Console.WriteLine(ReasonAbsence);
//        return ReasonAbsence;
//    }
//}

//internal class StudentEventAvtomat
//{
//    public int Exam { get; set; }
//    public StudentEventAvtomat(int e)
//    {
//        this.Exam = e;
//    }

//    public int GetAvtomat()
//    {
//        return Exam;
//    }

//}

namespace DZClasses
{
    /// <summary>
    /// Класс студента для группы.
    /// </summary>
    internal class Student : Person, ICloneable, IComparable<Student>
    {
        /// <summary>
        /// Лист Домашек/Зачётов
        /// </summary>
        protected ArrayList OffSet = new ArrayList();

        /// <summary>
        /// Лист Экзаменов
        /// </summary>
        protected ArrayList Exams = new ArrayList();

        /// <summary>
        /// Лист Лабораторных работ
        /// </summary>
        protected ArrayList TermPapers = new ArrayList();

        // public delegate void StudentHandlerAvtomat(Person p, StudentEventAvtomat args);
        // public delegate void StudentHandlerProspal(Person p, StudentEventProspal args);
        //  public event StudentHandlerAvtomat Avtomat;
        //public event StudentHandlerProspal WerentInPairs;

        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="some_another_student">Some another student.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(Student some_another_student) // реализация интерфейса
        {
            if (this.GetAverageRateOffSet() > some_another_student.GetAverageRateOffSet()) return 1; 
            if (this.GetAverageRateOffSet() < some_another_student.GetAverageRateOffSet()) return -1;
            return 0; 
        }
        /// <summary>
        /// Поверхностная копия - не идеальное копирование
        /// </summary>
        /// <returns>Student.</returns>
        public Student ShallowClone() // поверхностная копия
        {
            return (Student)this.MemberwiseClone();
        }

        /// <summary>
        /// Пользовательская копия - полностью копирует обьект
        /// </summary>
        /// <returns>Новый объект, являющийся копией этого экземпляра.</returns>
        public object Clone() // пользовательская копия
        {
            return new Student(this.Name, this.Surname, this.Lastname, this.Age, this.HomeAddress, this.NumberOfPhone, this.OffSet, this.Exams, this.TermPapers);
        }

        /// <summary>
        /// Оператор сравнения - сравнивает обьекты
        /// </summary>
        /// <param name="obj1">Первый обьект сравнения</param>
        /// <param name="obj2">Второй обьект сравнения</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateOffSet() == obj2.GetAverageRateOffSet() && obj1.Name == obj2.Name)
                return true;
            return false;
        }

        /// <summary>
        /// Оператор сравнения - сравнивает обьекты
        /// </summary>
        /// <param name="obj1">Первый обьект сравнения</param>
        /// <param name="obj2">Второй обьект сравнения</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateOffSet() != obj2.GetAverageRateOffSet())
                return true;
            return false;
        }

        /// <summary>
        /// Оператор сравнения - сравнивает обьекты
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator false(Student obj)
        {
            if (obj.OffSet.Count <= 0 && obj.Exams.Count <= 0 && obj.TermPapers.Count <= 0)
                return true;
            return false;
        }

        // Обязательно перегружаем оператор true
        /// <summary>
        /// Оператор сравнения - сравнивает обьекты
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator true(Student obj)
        {
            if (obj.OffSet.Count <= 0 && obj.Exams.Count <= 0 && obj.TermPapers.Count <= 0)
                return true;
            return false;
        }

        /// <summary>
        /// Оператор сравнения - сравнивает обьекты
        /// </summary>
        /// <param name="obj1">Первый обьект сравнения</param>
        /// <param name="obj2">Второй обьект сравнения</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateExams() + obj1.GetAverageRateTermPapers() + obj1.GetAverageRateOffSet() > obj2.GetAverageRateExams() + obj2.GetAverageRateTermPapers() + obj2.GetAverageRateOffSet())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Оператор сравнения - сравнивает обьекты
        /// </summary>
        /// <param name="obj1">Первый обьект сравнения</param>
        /// <param name="obj2">Второй обьект сравнения</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateExams() + obj1.GetAverageRateTermPapers() + obj1.GetAverageRateOffSet() > obj2.GetAverageRateExams() + obj2.GetAverageRateTermPapers() + obj2.GetAverageRateOffSet())
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="r">Название блока оценок</param>
        /// <param name="t">Переданная оценка</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.Exception">Ошибка! Не корректное название оценки</exception>
        public int this[string r, int t]
        {
            get 
            {
                if (r == "OffSet")
                {
                    return (int)OffSet[t];
                }
                else if (r == "Exams")
                {
                    return (int)Exams[t];
                }
                else if (r == "TermPapers")
                {
                    return (int)TermPapers[t];
                }
                else
                {
                    throw new Exception("Ошибка! Не корректное название оценки");
                }
            }
            set 
            {
                if (r == "OffSet")
                {
                    OffSet[t] = value;
                }
                else if (r == "Exams")
                {
                     Exams[t] = value;
                }
                else if (r == "TermPapers")
                {
                    TermPapers[t] = value;
                }
                else
                {
                    throw new Exception("Ошибка! Не корректное название оценки");
                }
            }
        }

        /// <summary>
        /// Добавить оценку за зачёт.
        /// </summary>
        /// <param name="number">Оценка зачёта</param>
        /// <exception cref="System.Exception">Оценка не может быть меньше одного или больше двенадцати!</exception>
        public void AddOffSet(int number)
        {
            //if (Avtomat != null)
            //{
            //    Avtomat(this, new StudentEventAvtomat((int)GetAverageRateOffSet()));
            //}

            try
            {
                if (number >= 1 && number <= 12)
                {
                    this.OffSet.Add(number);
                }
                else
                {
                    throw new Exception("Оценка не может быть меньше одного или больше двенадцати!");

                }
            }
            catch (Exception exe)
            {
                Console.WriteLine($"Ошибка: {exe.Message}");
            }
        }

        /// <summary>
        /// Добавить оценку за ЭКЗАМЕН.
        /// </summary>
        /// <param name="number">Оценка экзамена</param>
        /// <exception cref="System.Exception">Оценка не может быть меньше одного или больше двенадцати!</exception>
        public void AddExams(int number)
        {
            try
            {
                if (number >= 1 && number <= 12)
                {
                    this.Exams.Add(number);
                }
                else
                {
                    throw new Exception("Оценка не может быть меньше одного или больше двенадцати!");

                }
            }
            catch (Exception exe)
            {
                Console.WriteLine($"Ошибка: {exe.Message}");
            }
        }

        /// <summary>
        /// Добавить оценку за Курсовую работу
        /// </summary>
        /// <param name="number">Оценка Курсовой работы</param>
        /// <exception cref="System.Exception">Оценка не может быть меньше одного или больше двенадцати!</exception>
        public void AddTermPapers(int number)
        {
            try
            {
                if (number >= 1 && number <= 12)
                {
                    this.TermPapers.Add(number);
                }
                else
                {
                    throw new Exception("Оценка не может быть меньше одного или больше двенадцати!");

                }
            }
            catch (Exception exe)
            {
                Console.WriteLine($"Ошибка: {exe.Message}");
            }
        }

        /// <summary>
        /// Конструктор без параметров с генерацией рандомного студента.
        /// </summary>
        public Student()
        {
            Random rnd = new Random();
            try
            {
                int gender = rnd.Next(0, 2);
                System.Threading.Thread.Sleep(1);

                if (gender == 0)
                {
                    int nMIndex = rnd.Next(11);
                    System.Threading.Thread.Sleep(1);

                    int sMIndex = rnd.Next(17);
                    System.Threading.Thread.Sleep(1);

                    int lMIndex = rnd.Next(11);
                    System.Threading.Thread.Sleep(1);

                    int MAddressIndex = rnd.Next(10);
                    System.Threading.Thread.Sleep(3);

                    int MNumberIndex = rnd.Next(23);
                    System.Threading.Thread.Sleep(3);

                    //for (int i = 0; i < rnd.Next(10,15); i++)
                    //{
                    //    OffSet.Add(rnd.Next(1, 13));
                    //}

                    //for (int i = 0; i < 5; i++)
                    //{
                    //    Exams.Add(rnd.Next(1, 13));
                    //}

                    //for (int i = 0; i < 6; i++)
                    //{
                    //    TermPapers.Add(rnd.Next(1, 13));
                    //}


                }
                else if (gender == 1)
                {
                    int nFIndex = rnd.Next(12, 22);
                    System.Threading.Thread.Sleep(1);

                    int sFIndex = rnd.Next(18, 32);
                    System.Threading.Thread.Sleep(1);

                    int lFIndex = rnd.Next(12, 22);
                    System.Threading.Thread.Sleep(1);

                    int FAddressIndex = rnd.Next(10);
                    System.Threading.Thread.Sleep(1);

                    int FNumberIndex = rnd.Next(23,35);
                    System.Threading.Thread.Sleep(1);

                    //for (int i = 0; i < rnd.Next(10, 15); i++)
                    //{
                    //    OffSet.Add(rnd.Next(1, 13));
                    //}

                    //for (int i = 0; i < 5; i++)
                    //{
                    //    Exams.Add(rnd.Next(1, 13));
                    //}

                    //for (int i = 0; i < 6; i++)
                    //{
                    //    TermPapers.Add(rnd.Next(1, 13));
                    //}
                }

            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
        }

        /// <summary>
        /// Конструктор с параметрами имени, фамилии, отчества и возраста.
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        public Student(string name, string surname, string lastname, DateTime age) : base(name, surname, lastname, age) {}

        /// <summary>
        /// Конструктор с параметрами и Листами оценок
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        /// <param name="HomeAddress">Адресс студента</param>
        /// <param name="NumberOfPhone">Номер телефона студента</param>
        /// <param name="OS">Лист домашних задания/зачётов</param>
        /// <param name="E">Лист экзаменов</param>
        /// <param name="TP">Лист лабораторных работ</param>
        public Student(string name, string surname, string lastname, DateTime age, string HomeAddress, string NumberOfPhone, ArrayList OS, ArrayList E, ArrayList TP)
        {
            this.Name = name;
            this.Surname = surname;
            this.Lastname = lastname;
            this.Age = age;
            this.HomeAddress = HomeAddress;
            this.NumberOfPhone = NumberOfPhone;
            this.OffSet = OS;
            this.Exams = E;
            this.TermPapers = TP;
        }
        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        /// <param name="HomeAddress">Адресс студента</param>
        /// <param name="NumberOfPhone">Номер телефона студента</param>
        public Student(string name, string surname, string lastname, DateTime age, string HomeAddress, string NumberOfPhone) : base(name, surname, lastname, age, HomeAddress, NumberOfPhone) {}

        /// <summary>
        /// Gets the average rate off set.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double GetAverageRateOffSet()
        {
            double result = 0;
            for (int i = 0; i < OffSet.Count; i++)
            {
                result += (int)OffSet[i];
            }
            return result / OffSet.Count;
        }
        /// <summary>
        /// Возращает средний бал экзаменов
        /// </summary>
        /// <returns>System.Double.</returns>
        public double GetAverageRateExams()
        {
            double result = 0;
            for (int i = 0; i < Exams.Count; i++)
            {
                result += (int)Exams[i];
            }
            return result / Exams.Count;
        }

        /// <summary>
        /// Возвращает средний бал лабораторных работ
        /// </summary>
        /// <returns>System.Double.</returns>
        public double GetAverageRateTermPapers()
        {
            double result = 0;
            for (int i = 0; i < TermPapers.Count; i++)
            {
                result += (int)TermPapers[i];
            }
            return result / TermPapers.Count;
        }

        /// <summary>
        /// Выписывает студента с полной о нём информацией
        /// </summary>
        /// <exception cref="global.LackOfGradesException">Оценки отсутвуют!\n</exception>
        public override void Print()
        {
            try
            {
                base.Print();
                Exception OET = new LackOfGradesException("Оценки за зачёты отсутствуют!");
                if (OffSet.Count == 0 && Exams.Count == 0 && TermPapers.Count == 0)
                {
                    throw new LackOfGradesException("Оценки отсутвуют!\n");
                }
                if (OffSet.Count == 0)
                {
                    Console.WriteLine(OET);
                }
                else
                {
                    Console.Write("\nЗачёты : ");
                    for (int i = 0; i < OffSet.Count; i++)
                    {
                        Console.Write(OffSet[i] + ", ");
                    }
                    Console.Write("Средний был за зачёты: " + this.GetAverageRateOffSet());
                }
                if (Exams.Count == 0)
                {
                    OET = new LackOfGradesException("Оценки за экзамены отсутствуют!");
                    Console.WriteLine(OET);
                }
                else
                {
                    Console.Write("\nЭкзамены : ");
                    for (int i = 0; i < Exams.Count; i++)
                    {
                        Console.Write(Exams[i] + ", ");
                    }
                }
                if (TermPapers.Count == 0)
                {
                    OET = new LackOfGradesException("Оценки за курсовые работы отсутствуют!");
                    Console.WriteLine(OET);
                }
                else
                {
                    Console.Write("\nКурсовые работы : ");
                    for (int i = 0; i < TermPapers.Count; i++)
                    {
                        Console.Write(TermPapers[i] + ", ");
                    }
                }
                Console.WriteLine("\n\n");
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
        }


    }
}