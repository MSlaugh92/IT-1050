using System;



namespace Assignment4

{

    class Program

    {

        static void Main(string[] args)

        {

            MovieTime movieTime = new MovieTime();

            string input;



            DisplayHeader();



            Console.Write("Are you bringing anybody? (yes/no): ");

            input = Console.ReadLine();

            if (input.ToLower() == "yes")

            {

                DisplayHeader();



                Console.Write("How many people (including yourself) are coming?: ");

                movieTime.people = int.Parse(Console.ReadLine());



                Console.Write("How many are children?: ");

                movieTime.children = int.Parse(Console.ReadLine());



                Console.Write("How many are seniors?: ");

                movieTime.seniors = int.Parse(Console.ReadLine());



                movieTime.adults = movieTime.people - movieTime.children - movieTime.seniors;

            }

            else if (input.ToLower() == "no")

            {

                DisplayHeader();



                Console.WriteLine("Ticket for one? Enjoy!");

                Console.Write("Press any key to continue...");

                Console.ReadLine();

            }

            else

            {

                DisplayHeader();



                Console.WriteLine(" Invalid Entry! ");

                Console.Write("Press any key to continue...");

            }



            DisplayHeader();

            Console.Write("Do you want to see a matinee or an evening film? (matinee/evening): ");

            input = Console.ReadLine();

            if (input.ToLower() == "matinee")

            {

                movieTime.matinee = true;

            }

            else if (input.ToLower() == "evening")

            {

                movieTime.matinee = false;

            }

            else

            {

                DisplayHeader();



                Console.WriteLine("Invalid I will assume matinee since it is cheaper");

                Console.Write("Press any key to continue...");

                Console.ReadLine();

                movieTime.matinee = true;

            }



            DisplayHeader();

            Console.WriteLine("Gotta have snacks! Enter quantities in whole numbers.\n");

            Console.Write("How many small sodas?: ");

            movieTime.smSodas = int.Parse(Console.ReadLine());

            Console.Write("How many large sodas?: ");

            movieTime.lgSodas = int.Parse(Console.ReadLine());

            Console.Write("How many hot dogs?: ");

            movieTime.hotDogs = int.Parse(Console.ReadLine());

            Console.Write("How many popcorns?: ");

            movieTime.popcorns = int.Parse(Console.ReadLine());

            Console.Write("How many candies?: ");

            movieTime.candies = int.Parse(Console.ReadLine());



            DisplayHeader();

            Console.WriteLine("Your total before coupons would be: {0:C}\n", movieTime.CalculateTotal());



            movieTime.Promotions();



            Console.WriteLine("After coupons, your total will be: {0:C}", movieTime.totalPrice);



            if (movieTime.freePopcorn)

            {

                Console.WriteLine("You may also get a free popcorn!");

            }



            if (movieTime.freeCandies > 0)

            {

                Console.WriteLine("You will also get {0} free candies!", movieTime.freeCandies);

            }



            Console.Write("Press any key to exit...");

            Console.ReadLine();

        }



        static void DisplayHeader()

        {

            Console.Clear();
            Console.WriteLine("******NIGHT AT THE MOVIES CALCULATOR******\n");
          

        }

    }

}