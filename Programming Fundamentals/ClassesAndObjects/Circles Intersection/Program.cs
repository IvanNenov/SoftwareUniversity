using System;
using System.Collections.Generic;

namespace Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Pesho";
            student.Age = 5;
            student.Grade = 6;

            List<Student> st = new List<Student>();
            st.Add(student);

            st.Add(new Student("Gosho"));
            st.Add(new Student("Misho", 25));


            foreach (var stud in st)
            {
                Console.WriteLine(stud);
            }
        }
    }

    class Student
    {
        public string Name;
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student()
        {

        }

        public Student(string name, int age = 20, int grade = 6)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return Name + " -> " + Age + " - Grade: " + Grade;
        }
    }
}
