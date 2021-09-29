using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerables
{
    class StudentsWhoPracticeALot : IEnumerable<Student>
    {
        public Student[] Students { get; set; }

        public StudentsWhoPracticeALot(params Student[] students)
        {
            Students = students;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Grade >= 10)
                {
                    yield return Students[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int grade)
        {
            Grade = grade;
        }
    }
}
