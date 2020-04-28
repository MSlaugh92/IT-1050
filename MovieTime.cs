using System;

using System.Collections.Generic;

using System.Text;



namespace Assignment4

{

    class MovieTime

    {

        public int people { get; set; }

        public int children { get; set; }

        public int seniors { get; set; }

        public int adults { get; set; }

        public bool matinee { get; set; }





        public int smSodas { get; set; }

        public int lgSodas { get; set; }

        public int hotDogs { get; set; }

        public int popcorns { get; set; }

        public int candies { get; set; }

        public int freeCandies { get; private set; }



        public float totalPrice { get; private set; }

        private float ticketDiscount;

        public bool freePopcorn { get; private set; }





        public MovieTime()

        {

            people = 1;

            children = 0;

            seniors = 0;

            adults = 0;

        }



        public float CalculateTotal()

        {

            if (matinee)

            {

                totalPrice = children * 3.99f;

                totalPrice += seniors * 4.50f;

                totalPrice += adults * 5.99f;

            }

            else

            {

                totalPrice = children * 6.99f;

                totalPrice += seniors * 8.50f;

                totalPrice += adults * 10.99f;

            }

            totalPrice += smSodas * 3.50f;

            totalPrice += lgSodas * 5.99f;

            totalPrice += hotDogs * 3.99f;

            totalPrice += popcorns * 4.50f;

            totalPrice += candies * 1.99f;



            return totalPrice;

        }



        public void Promotions()

        {

            if (lgSodas > 0 && popcorns > 0)

            {

                if (lgSodas > popcorns)

                {

                    ticketDiscount += popcorns;

                }

                else if (popcorns > lgSodas)

                {

                    ticketDiscount += lgSodas;

                }

                else

                {

                    ticketDiscount += lgSodas;

                }



                if (people > ticketDiscount)

                {

                    totalPrice -= ticketDiscount * 2;

                }

                else

                {

                    totalPrice -= people * 2;

                }

            }





            if (matinee == false && people > 3)

            {

                freePopcorn = true;

            }



            freeCandies = candies / 3;

        }

    }

}