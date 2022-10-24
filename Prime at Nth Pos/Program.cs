using System;
using System.Linq;

namespace Prime_at_Nth_Pos
    //find nth prime number
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter number: ");
            string user_string = Console.ReadLine();

            //convert to int
            int n_pos = Convert.ToInt32(user_string);

            //init sol and prime_count
            int sol = 2;
            int prime_count = 0;
            
            //start counting upwards from starting number to safety limit
            for (int i = 2; i < 100; i++)
            {
                //if isPrime == True, increment prime_count
                if (IsPrime(i) == true)
                {
                    prime_count++;
                }

                //if prime_count == n_pos, sol =i, break
                if (prime_count == n_pos)
                {
                    sol = i;
                    break;
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
            else if (a == 0)
            {
                return false;
            }
            //main code section
            else
            {
                //working backwards, try dividing x by each number less than it (up until 2)
                for (int i = a - 1; i > 2; i--)
                {
                    //check if remainder of division greater than 0,
                    //if so x is divisable by n
                    if (a % i == 0)
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
