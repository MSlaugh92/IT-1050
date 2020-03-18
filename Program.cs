using System;

namespace Assignment2

{

    class Program

    {

        static void Main(string[] args)

        {

            Person p1 = new Person();

            Person p2 = new Person();



            Console.WriteLine("\n[ Enter Information for Person 1 ]");

            Person.GetPersonInfo(p1);



            Console.WriteLine("\n[ Enter Information for Person 2 ]");

            Person.GetPersonInfo(p2);



            Console.WriteLine("[ Printing Results ]\n");

            p1.PrintNameAndAge();

            p1.spouse.PrintNameAndAge();

            p2.PrintNameAndAge();

            p2.spouse.PrintNameAndAge();





            Person.sumOfAllAges = (p1.age + p2.age + p1.spouse.age + p2.spouse.age);

            int personQuantity = 4;



            Console.WriteLine("\nAverage Age: " + Person.sumOfAllAges / personQuantity);



            Console.ReadKey();

        }

    }

}

