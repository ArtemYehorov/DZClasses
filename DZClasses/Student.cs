
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DZClasses
{
    /// <summary>
    /// Класс студента для группы.
    /// </summary>
    internal class Student
    {
        private string name;
        private string surname;
        private string lastname;
        private DateTime age;
        private string HomeAddress;
        private string NumberOfPhone;

        private ArrayList OffSet = new ArrayList();
        private ArrayList Exams = new ArrayList();
        private ArrayList TermPapers = new ArrayList();

        private string[] NameList = new string[22] 
        { 
            "Сергей","Артём","Назар","Андрей","Никита","Марк","Ярослав","Максим","Игорь","Давид","Владимир",
            "Анастасия","Ксения","Владислава","Валерия","Валентина","Ирина","Елена","Дарья","Алима","Инна","Анна"
        };

        private string[] SurnameList = new string[33] 
        {
           "Опара","Егоров","Коваль","Соловьёв","Попов","Зеленский","Путин","Кузнецов","Петухов","Миронов", "Кузьмин", "Гусев", "Савчук", "Ильин", "Баранов", "Алексеев", "Борисов",
           "Егорова", "Коваль", "Соловьёва", "Попова", "Зеленская", "Путина", "Кузнецова", "Петухова", "Миронова", "Кузьмина", "Гусева", "Савчук", "Ильина", "Баранова", "Алексеева", "Борисова"
        };

        private string[] LastnameList = new string[22] 
        {
            "Сергеевич","Артемович","Назарович","Андреевич","Никитович","Маркович","Ярославович","Максимович","Игоревич","Давидович","Владимирович",
            "Сергеевна","Артемовна","Назаровна","Андреевна","Марковна","Максимовна" ,"Игоревна","Давидовна","Владимировна","Ярославовна","Никитична" 
        };

        private string[] AddressList = new string[10]
        {
            "Дерибасовская улица 12","Малая Арнаутская улица 42А","Большая Арнаутская улица 11","Ланжероновская улица 8","Пушкинская улица 23","Екатерининская улица А1","Приморский бульвар 56","Маразлиевская улица 2К","Французский бульвар Ф44","Греческая улица 66"
        };

        private string[] NumberList = new string[35]
        {
            "+380929398000","+380929398001","+380929398002","+380929398003","+380929398004","+380929398005","+380929398006","+380929398007","+380929398008","+380929398009","+380929398010","+380929398011","+380929398012","+380639398813","+380922398914","+380925398015","+380929398236","+380929398917",
             "+380929398018","+380929398019","+380929398020","+380929398021","+380929398022","+380929398023","+380929398024","+380929398025","+380929398026","+380929398027","+380929398028","+380929398029","+380929398030","+380929398031","+380929398032","+380929398033","+380929398034"
        };

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

                    SetName(NameList[nMIndex]);
                    SetSurname(SurnameList[sMIndex]);
                    SetLastname(LastnameList[lMIndex]);
                    SetHomeAddress(AddressList[MAddressIndex]);
                    SetNumberOfPhone(NumberList[MNumberIndex]);
                    age = age.AddDays(rnd.Next(1, 31));
                    age = age.AddMonths(rnd.Next(1, 13));
                    age = age.AddYears(rnd.Next(1970, 2004));
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

                    SetName(NameList[nFIndex]);
                    SetSurname(SurnameList[sFIndex]);
                    SetLastname(LastnameList[lFIndex]);
                    SetHomeAddress(AddressList[FAddressIndex]);
                    SetNumberOfPhone(NumberList[FNumberIndex]);

                    age = age.AddDays(rnd.Next(1, 31));
                    age = age.AddMonths(rnd.Next(1, 13));
                    age = age.AddYears(rnd.Next(1970, 2004));
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
        public Student(string name, string surname, string lastname, DateTime age)
        {
            Random rnd = new Random();
            SetName(name);
            SetSurname(surname);
            SetLastname(lastname);
            SetAge(age);
            int AddressIndex = rnd.Next(11);
            System.Threading.Thread.Sleep(1);
            int NumberIndex = rnd.Next(36);
            System.Threading.Thread.Sleep(1);
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
        public Student(string name, string surname, string lastname, DateTime age, string HomeAddress, string NumberOfPhone)
        {
            SetName(name);
            SetSurname(surname);
            SetLastname(lastname);
            SetAge(age);
            SetHomeAddress(HomeAddress);
            SetNumberOfPhone(NumberOfPhone);
        }


        /// <summary>
        /// Задаёт имя стдента
        /// </summary>
        /// <param name="name">Новое имя</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Возращает имя студента
        /// </summary>
        /// <returns>Имя студента</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Задаёт фамилию стдента
        /// </summary>
        /// <param name="name">Новоя фамилия</param>
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        /// <summary>
        /// Возращает фамилию студента
        /// </summary>
        /// <returns>Фамилия студента</returns>
        public string GetSurname()
        {
            return surname;
        }

        /// <summary>
        /// Задаёт отчество стдента
        /// </summary>
        /// <param name="name">Новое отчество</param>
        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        /// <summary>
        /// Возращает отчество студента
        /// </summary>
        /// <returns>Отчество студента</returns>
        public string GetLastname()
        {
            return lastname;
        }

        /// <summary>
        /// Задаёт Возраст стдента
        /// </summary>
        /// <param name="name">Новый возраст</param>
        public void SetAge(DateTime age)
        {
            this.age = age.AddDays(20 - 1);
            this.age = age.AddMonths(1 - 1);
            this.age = age.AddYears(2003 - 1);
        }

        /// <summary>
        /// Возращает возраст студента
        /// </summary>
        /// <returns>Возраст студента</returns>
        public DateTime GetAge()
        {
            return age;
        }

        /// <summary>
        /// Задаёт адресс стдента
        /// </summary>
        /// <param name="name">Новый адресс</param>
        public void SetHomeAddress(string HomeAddress)
        {
            this.HomeAddress = HomeAddress;
        }

        /// <summary>
        /// Возращает Адресс студента
        /// </summary>
        /// <returns>Адресс студента</returns>
        public string GetHomeAddress()
        {
            return HomeAddress;
        }

        /// <summary>
        /// Задаёт номер телефона стдента
        /// </summary>
        /// <param name="name">Новый номер телефона</param>
        public void SetNumberOfPhone(string NumberOfPhone)
        {
            this.NumberOfPhone = NumberOfPhone;
        }

        /// <summary>
        /// Возращает номер телефона студента
        /// </summary>
        /// <returns>Номер телефона студента</returns>
        public string GetNumberOfPhone()
        {
            return NumberOfPhone;
        }

        /// <summary>
        /// Выводит в консоль информацию о студенте.
        /// </summary>
        public void Print()
        {
            try
            {
                Console.WriteLine("Name : " + GetName());
                Console.WriteLine("SurName : " + GetSurname());
                Console.WriteLine("LastName : " + GetLastname());
                Console.WriteLine("Date of Birthday : " + GetAge());
                Console.WriteLine("Home Address : " + GetHomeAddress());
                Console.WriteLine("Phone Number : " + GetNumberOfPhone());
                Console.Write("\nЗачёты : ");
                for (int i = 0; i < OffSet.Count; i++)
                {
                    Console.Write(OffSet[i] + ", ");
                }
                Console.Write("\nЭкзамены : ");
                for (int i = 0; i < Exams.Count; i++)
                {
                    Console.Write(Exams[i] + ", ");
                }
                Console.Write("\nКурсовые работы : ");
                for (int i = 0; i < TermPapers.Count; i++)
                {
                    Console.Write(TermPapers[i] + ", ");
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