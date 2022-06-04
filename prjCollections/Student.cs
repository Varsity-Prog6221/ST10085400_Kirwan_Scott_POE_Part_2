using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCollections
{
    class Student
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Mark { get; set; }

        public Student(string studentNumber, string name, string surname, int mark)
        {
            StudentNumber = studentNumber;
            Name = name;
            Surname = surname;
            Mark = mark;

        }
        public override string ToString()
        {
            return "You Failed";
        }
    }
}
