using System;

namespace prjOOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //student.StudentNum = "21006568";
            //student.Name = "Kirwan";
            //student.Surname = "Scott";


            //Console.Write(student.Name + "\n" + student.Surname + "\n" + student.StudentNum 
            //    + "\n" + student.Speak() + "\n" + student.Listen() 
            //    + "\n" + Student.INSTITUTION);

            Student[] studArr = new Student[2];

            Student studs = new Student();
            for (int i = 0; i < studArr.Length; i++)
            {
                studArr[0] = new Student("2100854", "Kirwan", "Scott");
                studArr[1] = new Student("1233565", "Aggie", "Wolkvyn");
            }
            studs = new Student();
            foreach (Student st in studArr)
            {
                Console.WriteLine(st.Writes());
            }
            Console.ReadKey();
        }
    }
}
