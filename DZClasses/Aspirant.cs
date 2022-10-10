using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    internal class Aspirant : Student
    {
        public string Worktheme;

        public string WorkTheme
        {
            get { return Worktheme; }
            set { Worktheme = value; }
        }

        public Aspirant() : base()
        {
            WorkTheme = "Программирование на природе";
        }

        public Aspirant(string name,string surname,string lastname,DateTime age,string worktheme) : base(name, surname, lastname, age)
        {
            WorkTheme = worktheme;
        }

        public Aspirant(string name, string surname, string lastname, DateTime age, string HomeAddress, string NumberOfPhone,string worktheme) : base(name, surname, lastname, age, HomeAddress, NumberOfPhone) 
        {
            WorkTheme = worktheme;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Тема работы: " + WorkTheme);
        }
    }
}
