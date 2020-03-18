using System;



namespace Assignment2

{

    class Person

    {

        public int age;

        public string firstName;

        public string lastName;

        public static double sumOfAllAges;

        public Person spouse;



        public string GetFullName()

        {

            return this.lastName + ", " + this.firstName;

        }



        public void PrintNameAndAge()

        {

            Console.WriteLine(GetFullName() + " (" + this.age + ")");

        }



        public static void GetPersonInfo(Person p)

        {

            p.spouse = new Person();



            Console.Write("\nEnter Your First Name           : ");

            p.firstName = Console.ReadLine();

            Console.Write("Enter Your Last Name            : ");

            p.lastName = Console.ReadLine();

            Console.Write("Enter Your Age                  : ");

            p.age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Spouse's First Name  : ");

            p.spouse.firstName = Console.ReadLine();

            Console.Write("Enter Your Spouse's Age         : ");

            p.spouse.age = int.Parse(Console.ReadLine());

            p.spouse.lastName = p.lastName;

            p.spouse.spouse = p;

            Console.WriteLine();

        }



    }

}