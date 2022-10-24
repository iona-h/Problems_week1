using System;

namespace Next_Prime
    //find next prime n after user input
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter number: ");
            string user_string = Console.ReadLine();

            //convert to int
            int starting_n = Convert.ToInt32(user_string);

            //managing non-ints?*

            //if negative, return 2
            int sol = 2;
            //else
            if (starting_n > 0)
            {
                Console.WriteLine("starting_n > 0, entered loop");

                //start counting upwards from starting number to safety limit
                for (int i= starting_n + 1; i< starting_n + 100; i++)
                {
                    Console.WriteLine("i = {0}", i.ToString());

                    //if isPrime == True, that's sol
                    if (IsPrime(i) == true)
                    {
                        Console.WriteLine("PRIME");
                        sol = i;
                        break;
                    }
                }
            }

            //print sol
            Console.WriteLine("Sol = {0}", sol.ToString());
            Console.ReadLine();

        }

        //funtion returns True is input x is prime and False otherwise
        //x is an integer input"
        public static bool IsPrime(int a)
        {
            //exception cases for 1 and 0
            if (a == 1)
            {
                return false;
            }
            else if(a == 0)
            {
                return false;
            }
            //main code section
            else
            {
                //working backwards, try dividing x by each number less than it (up until 2)
                for (int i = a-1; i>2; i--)
                {
                    //check if remainder of division greater than 0,
                    //if so x is divisable by n
                    if (a % i ==0)
                    {
                        //if x divisable by any of the numbers less than it(other than 1),
                        //it is not prime so return False
                        return false;
                    }
                }
                //if x not divisable by any of the numbers less than it,
                //it must be prime so return True
                return true;

            }
        }

    }
}
