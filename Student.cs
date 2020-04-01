using System;



namespace Assignment3

{

    class Student

    {

        private string Name;

        private int Grade;

        private Instructor Teacher;



        public Student(string name, Instructor teacher)

        {

            this.Name = name;

            this.Teacher = teacher;

            this.Grade = 0;

        }

        public void SetGrade(int grade)

        {

            this.Grade = grade;

        }

        public void Print()

        {

            Console.WriteLine("+===================================+");

            Console.WriteLine("\nStudent Name: {0}", this.Name);

            Console.WriteLine("Student Grade: {0}", this.Grade);

            Teacher.Print();

        }

    }

}
