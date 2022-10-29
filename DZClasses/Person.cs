
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
    /// Class Person.
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        /// <summary>
        /// The surname
        /// </summary>
        private string surname;
        /// <summary>
        /// The lastname
        /// </summary>
        private string lastname;
        /// <summary>
        /// The age
        /// </summary>
        protected DateTime age;
        /// <summary>
        /// The homeaddress
        /// </summary>
        private string Homeaddress;
        /// <summary>
        /// The numberof phone
        /// </summary>
        private string NumberofPhone;

        /// <summary>
        /// Свойство Name, возвращает и устанавливает значение
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство Surname, возвращает и устанавливает значение
        /// </summary>
        /// <value>The surname.</value>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        /// <summary>
        /// Свойство Lastname, возвращает и устанавливает значение
        /// </summary>
        /// <value>The lastname.</value>
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        /// <summary>
        /// Свойство HomeAddress, возвращает и устанавливает значение
        /// </summary>
        /// <value>The home address.</value>
        public string HomeAddress
        {
            get { return Homeaddress; }
            set { Homeaddress = value; }
        }

        /// <summary>
        /// Свойство Age, возвращает и устанавливает значение
        /// </summary>
        /// <value>The age.</value>
        public DateTime Age
        {
            get { return age; }
            set { age = value; }
        }


        /// <summary>
        /// Свойство NumberOfPhone, возвращает и устанавливает значение
        /// </summary>
        /// <value>The number of phone.</value>
        public string NumberOfPhone
        {
            get { return NumberofPhone; }
            set { NumberofPhone = value; }
        }

        /// <summary>
        /// The name list
        /// </summary>
        protected string[] NameList = new string[22]
        {
            "Сергей","Артём","Назар","Андрей","Никита","Марк","Ярослав","Максим","Игорь","Давид","Владимир",
            "Анастасия","Ксения","Владислава","Валерия","Валентина","Ирина","Елена","Дарья","Алима","Инна","Анна"
        };

        /// <summary>
        /// The surname list
        /// </summary>
        protected string[] SurnameList = new string[33]
        {
           "Опара","Егоров","Коваль","Соловьёв","Попов","Зеленский","Путин","Кузнецов","Петухов","Миронов", "Кузьмин", "Гусев", "Савчук", "Ильин", "Баранов", "Алексеев", "Борисов",
           "Егорова", "Коваль", "Соловьёва", "Попова", "Зеленская", "Путина", "Кузнецова", "Петухова", "Миронова", "Кузьмина", "Гусева", "Савчук", "Ильина", "Баранова", "Алексеева", "Борисова"
        };

        /// <summary>
        /// The lastname list
        /// </summary>
        protected string[] LastnameList = new string[22]
        {
            "Сергеевич","Артемович","Назарович","Андреевич","Никитович","Маркович","Ярославович","Максимович","Игоревич","Давидович","Владимирович",
            "Сергеевна","Артемовна","Назаровна","Андреевна","Марковна","Максимовна" ,"Игоревна","Давидовна","Владимировна","Ярославовна","Никитична"
        };

        /// <summary>
        /// The address list
        /// </summary>
        protected string[] AddressList = new string[10]
        {
            "Дерибасовская улица 12","Малая Арнаутская улица 42А","Большая Арнаутская улица 11","Ланжероновская улица 8","Пушкинская улица 23","Екатерининская улица А1","Приморский бульвар 56","Маразлиевская улица 2К","Французский бульвар Ф44","Греческая улица 66"
        };

        /// <summary>
        /// The number list
        /// </summary>
        protected string[] NumberList = new string[35]
        {
            "+380929398000","+380929398001","+380929398002","+380929398003","+380929398004","+380929398005","+380929398006","+380929398007","+380929398008","+380929398009","+380929398010","+380929398011","+380929398012","+380639398813","+380922398914","+380925398015","+380929398236","+380929398917",
             "+380929398018","+380929398019","+380929398020","+380929398021","+380929398022","+380929398023","+380929398024","+380929398025","+380929398026","+380929398027","+380929398028","+380929398029","+380929398030","+380929398031","+380929398032","+380929398033","+380929398034"
        };

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Person()
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

                    Name = NameList[nMIndex];
                    Surname = SurnameList[sMIndex];
                    Lastname = LastnameList[lMIndex];
                    HomeAddress = AddressList[MAddressIndex];
                    NumberOfPhone = NumberList[MNumberIndex];

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

                    int FNumberIndex = rnd.Next(23, 35);
                    System.Threading.Thread.Sleep(1);

                    Name = NameList[nFIndex];
                    Surname = SurnameList[sFIndex];
                    Lastname = LastnameList[lFIndex];
                    HomeAddress = AddressList[FAddressIndex];
                    NumberOfPhone = NumberList[FNumberIndex];

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
        public Person(string name, string surname, string lastname, DateTime age)
        {
            Random rnd = new Random();
            Name = name;
            Surname = surname;
            Lastname = lastname;
            Age = age;
            System.Threading.Thread.Sleep(1);
            HomeAddress = AddressList[rnd.Next(0,11)];
            System.Threading.Thread.Sleep(1);
            NumberOfPhone = NumberList[rnd.Next(0,36)];

        }

        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="name">Имя студента</param>
        /// <param name="surname">Фамилия студента</param>
        /// <param name="lastname">Отчество студента</param>
        /// <param name="age">Возраст студента</param>
        /// <param name="Homeaddress">Адресс студента</param>
        /// <param name="NumberofPhone">Номер телефона студента</param>
        public Person(string name, string surname, string lastname, DateTime age, string Homeaddress, string NumberofPhone)
        {
            Name = name;
            Surname = surname;
            Lastname = lastname;
            Age = age;
            HomeAddress = Homeaddress;
            NumberOfPhone = NumberofPhone;
        }

        /// <summary>
        /// Выводит персону в консоль
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("SurName : " + Surname);
            Console.WriteLine("LastName : " + Lastname);
            Console.WriteLine("Date of Birthday : " + Age);
            Console.WriteLine("Home Address : " + HomeAddress);
            Console.WriteLine("Phone Number : " + NumberOfPhone);
        }
    }
}
