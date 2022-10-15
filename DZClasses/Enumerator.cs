using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    class MyEnumerator : IEnumerator
    {
        ArrayList ar; // поле, которое сможет выдать доступ к коллекции в любой части класса-перечислителя

        // конструктор нужен для того, чтобы подружить коллекцию с перечислителем, чтобы перечислитель "увидел" что он собирается перебирать
        public MyEnumerator(ArrayList ar)
        {
            this.ar = ar;
        }

        public object Current
        {
            get;
            private set;
        }

        int index; // коллекцию (её инкапсулированный массив) будем перебирать начиная от индекса 0

        public bool MoveNext()
        {
            if (index >= ar.Count)
                return false;

            Current = ar[index++]; // 5 15 47 28 37
            return true;
        }

        public void Reset()
        {
            index = 0;
        }
    }

}
