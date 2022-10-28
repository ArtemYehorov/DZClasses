using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    internal class Aspirant : Student
    {
        /// <summary>
        /// Тема работы
        /// </summary>
        public string Worktheme;

        /// <summary>
        /// Свойство темы работы
        /// </summary>
        public string WorkTheme
        {
            get { return Worktheme; }
            set { Worktheme = value; }
        }

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Aspirant() : base()
        {
            WorkTheme = "Программирование на природе";
        }

        /// <summary>
        /// конструктор с неполным списком параметров
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="lastname">Отчество</param>
        /// <param name="age">Возвраст</param>
        /// <param name="worktheme">Тема работы</param>
        public Aspirant(string name,string surname,string lastname,DateTime age,string worktheme) : base(name, surname, lastname, age)
        {
            WorkTheme = worktheme;
        }

        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="lastname">Отчество</param>
        /// <param name="age">Возвраст</param>
        /// <param name="HomeAddress">Адресс</param>
        /// <param name="NumberOfPhone">Номер телефона</param>
        /// <param name="worktheme">Тема работы</param>
        public Aspirant(string name, string surname, string lastname, DateTime age, string HomeAddress, string NumberOfPhone,string worktheme) : base(name, surname, lastname, age, HomeAddress, NumberOfPhone) 
        {
            WorkTheme = worktheme;
        }

        /// <summary>
        /// Вовод в консоль Аспиранта
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Тема работы: " + WorkTheme);
        }
    }
}
