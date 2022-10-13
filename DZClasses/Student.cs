
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

class LackOfGradesException : ApplicationException
{
    public LackOfGradesException() { }
    public LackOfGradesException(string message) : base(message) { }
}


namespace DZClasses
{
    /// <summary>
    /// Класс студента для группы.
    /// </summary>
    internal class Student : Person
    {
        protected ArrayList OffSet = new ArrayList();
        protected ArrayList Exams = new ArrayList();
        protected ArrayList TermPapers = new ArrayList();

        public static bool operator ==(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateOffSet() == obj2.GetAverageRateOffSet() && obj1.Name == obj2.Name)
                return true;
            return false;
        }

        public static bool operator !=(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateOffSet() != obj2.GetAverageRateOffSet())
                return true;
            return false;
        }

        public static bool operator false(Student obj)
        {
            if (obj.OffSet.Count <= 0 && obj.Exams.Count <= 0 && obj.TermPapers.Count <= 0)
                return true;
            return false;
        }

        // Обязательно перегружаем оператор true
        public static bool operator true(Student obj)
        {
            if (obj.OffSet.Count <= 0 && obj.Exams.Count <= 0 && obj.TermPapers.Count <= 0)
                return true;
            return false;
        }

        public static bool operator >(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateExams() + obj1.GetAverageRateTermPapers() + obj1.GetAverageRateOffSet() > obj2.GetAverageRateExams() + obj2.GetAverageRateTermPapers() + obj2.GetAverageRateOffSet())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Student obj1, Student obj2)
        {
            if (obj1.GetAverageRateExams() + obj1.GetAverageRateTermPapers() + obj1.GetAverageRateOffSet() > obj2.GetAverageRateExams() + obj2.GetAverageRateTermPapers() + obj2.GetAverageRateOffSet())
            {
                return false;
            }
            return true;
        }

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
        public void AddOffSet(int number)
        {
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
        public  Student()
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
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        /// <param name="HomeAddress">Адресс студента</param>
        /// <param name="NumberOfPhone">Номер телефона студента</param>
        public Student(string name, string surname, string lastname, DateTime age, string HomeAddress, string NumberOfPhone) : base(name, surname, lastname, age, HomeAddress, NumberOfPhone) {}

        public double GetAverageRateOffSet()
        {
            double result = 0;
            for (int i = 0; i < OffSet.Count; i++)
            {
                result += (int)OffSet[i];
            }
            return result / OffSet.Count;
        }

        public double GetAverageRateExams()
        {
            double result = 0;
            for (int i = 0; i < Exams.Count; i++)
            {
                result += (int)Exams[i];
            }
            return result / Exams.Count;
        }

        public double GetAverageRateTermPapers()
        {
            double result = 0;
            for (int i = 0; i < TermPapers.Count; i++)
            {
                result += (int)TermPapers[i];
            }
            return result / TermPapers.Count;
        }

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
                    Console.Write("Средний был за зачёты: " + this.GetAverageRate());
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