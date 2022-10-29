// ***********************************************************************
// Assembly         : DZClasses
// Author           : Dr
// Created          : 10-15-2022
//
// Last Modified By : Dr
// Last Modified On : 10-28-2022
// ***********************************************************************
// <copyright file="Enumerator.cs" company="">
//     Copyright ©  2022
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    /// <summary>
    /// Класс который позволяет пользоваться foreach
    /// </summary>
    class MyEnumerator
    {
        /// <summary>
        /// The ar
        /// </summary>
        SortedSet<Student> ar; // поле, которое сможет выдать доступ к коллекции в любой части класса-перечислителя

        // конструктор нужен для того, чтобы подружить коллекцию с перечислителем, чтобы перечислитель "увидел" что он собирается перебирать
        /// <summary>
        /// Initializes a new instance of the <see cref="MyEnumerator"/> class.
        /// </summary>
        /// <param name="ar">The ar.</param>
        public MyEnumerator(SortedSet<Student> ar)
        {
            this.ar = ar;
        }

        /// <summary>
        /// Gets the current.
        /// </summary>
        /// <value>The current.</value>
        public object Current
        {
            get;
            private set;
        }

        /// <summary>
        /// The index
        /// </summary>
        int index; // коллекцию (её инкапсулированный массив) будем перебирать начиная от индекса 0

        /// <summary>
        /// Moves the next.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool MoveNext()
        {
            if (index >= ar.Count)
                return false;

            Current = ar.ElementAt<Student>(index++); // 5 15 47 28 37
            return true;
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            index = 0;
        }
    }

}
