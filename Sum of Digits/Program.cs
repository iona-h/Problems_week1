using System;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask for user input
            Console.WriteLine("Enter number: ");
            string user_string = Console.ReadLine();
            Console.WriteLine(); // new line

            //sum digits of number
            //initialise sum
            int digit_sum = 0;
            //step through each number
            for (int i = 0; i < user_string.Length; i++)
            {
                Console.WriteLine(user_string[i].ToString());
                //Convert char to int:
                //clever way:
                // works because each char is internally represented by a number
                // chars '0' to '9' are represented by consecutive numbers
                // eg. finding the difference between the characters '0' and '2' results in the number 2
                //int conv = user_string[i] - '0';

                //alt method using method of char to convert to float then explicit cast to int:
                int conv = (int)Char.GetNumericValue(user_string[i]);
                digit_sum += conv;
            }

            //print result
            Console.WriteLine(" digit_sum = {0}", digit_sum);

        }
    }
}
