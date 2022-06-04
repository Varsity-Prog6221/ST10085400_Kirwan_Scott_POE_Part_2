using System;
using System.Collections.Generic;
using System.Text;

namespace prjOOPExample
{
    class Student
    {
        public const string INSTITUTION = "Varsity College";
        private string studentNum;
        public string StudentNum
        {
            get
            {
                return this.studentNum;
            }
            set
            {
                studentNum = value;
            }
        }
        //private string name;
        //private string surname;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string studentNum)
        {
            this.StudentNum = studentNum;
        }
        public Student(string studentNumber, string Name, string Surname)
        {
            this.StudentNum = studentNumber;
            this.Name = Name;
            this.Surname = Surname;
        }
        public Student()
        {

        }
        public string Writes()
        {
            return StudentNum + "\t" + Name + "\t" + Surname;
        }

        public string Speak()
        {
            return "I speak when asked a question";
        }
        
        public string Listen()
        {
            return "I listen when I am in class";
        }
    }
}
