using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary
{
    class Group
    {
        public string No;
        public Student[] students;
        public int studentLimit;

        public Student[] AddStudent( Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            return students;
        }
    }
}
