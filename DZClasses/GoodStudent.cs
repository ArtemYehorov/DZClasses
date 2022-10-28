
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZClasses
{
    /// <summary>
    /// Class GoodStudent.
    /// Implements the <see cref="DZClasses.Student" />
    /// </summary>
    /// <seealso cref="DZClasses.Student" />
    internal class GoodStudent : Student
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public GoodStudent()
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

                    for (int i = 0; i < rnd.Next(10, 15); i++)
                    {
                        OffSet.Add(rnd.Next(10, 12));
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Exams.Add(rnd.Next(10, 12));
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        TermPapers.Add(rnd.Next(10, 12));
                    }


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

                    for (int i = 0; i < rnd.Next(10, 15); i++)
                    {
                        OffSet.Add(rnd.Next(10, 12));
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Exams.Add(rnd.Next(10, 12));
                    }

                    for (int i = 0; i < 6; i++)
                    {
                        TermPapers.Add(rnd.Next(10, 12));
                    }
                }

            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
        }
    }
}
