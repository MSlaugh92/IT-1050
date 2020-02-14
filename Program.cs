using System;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenation

            Console.Write("First Name? --> ");
            string firstName = Console.ReadLine();

            Console.Write("Middle Name? --> ");
            string middleName = Console.ReadLine();

            Console.Write("Last Name? --> ");
            string lastName = Console.ReadLine();

            string fullName = (firstName + " " + middleName + " " + lastName);

            
            //Arithmetic Expression
            
            Console.Write("What is you age? --> ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your height in feet? --> ");
            int baseFeet = int.Parse(Console.ReadLine());

            Console.Write("What is your height in inches? --> ");
            double extraInches = double.Parse(Console.ReadLine());

            const double multiplier = 2.54;
            const int inchesPerFoot = 12;

            double inches = (baseFeet * inchesPerFoot) + extraInches;
            double heightCM = inches * multiplier;


            //Boolean Expression

            Console.Write("Are you a US citizen(true or false)? --> ");
            bool isCitizen = bool.Parse(Console.ReadLine());

            bool canVote = (age >= 18) && isCitizen;


            Console.WriteLine("Your full name is: '" + fullName + "'.");
            Console.WriteLine("Your height in CM is: '" + heightCM + "'.");
            Console.WriteLine("Your voter eligibility is: '" + canVote + "'.");
            Console.WriteLine("Press any key to exit");
           
            
            
            Console.ReadKey();
            }
    }
}
