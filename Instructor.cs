using System;



namespace Assignment3

{

    class Instructor

    {

        private string Name;

        private string CourseName;



        public Instructor(string name, string courseName)

        {

            this.Name = name;

            this.CourseName = courseName;

        }



        public void SetStudentGrade(Student student, int grade)

        {

            student.SetGrade(grade);

        }

        public void Print()

        {

            Console.WriteLine("\nEnrolled in: {0}", this.CourseName);

            Console.WriteLine("Instructor: {0}\n", this.Name);

        }

    }

}
