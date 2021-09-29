using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q-1

            //Sidra10To100 sid = new Sidra10To100();
            //foreach (var item in sid)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q-2

            //Console.WriteLine("Enter number");
            //int num = int.Parse(Console.ReadLine());
            //Hazakot haz = new Hazakot(num);
            //foreach (var item in haz)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q-3

            Student s1 = new Student(8);
            Student s2 = new Student(10);
            Student s3 = new Student(13);
            Student s4 = new Student(5);
            Student s5 = new Student(20);
            StudentsWhoPracticeALot students = new StudentsWhoPracticeALot(s1, s2, s3, s4, s5);

            foreach (var item in students)
            {
                Console.WriteLine(item.Grade);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
