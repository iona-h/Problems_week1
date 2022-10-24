using System;

namespace Palindrome
    // test if input word palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //take user input and assign to var
            // ask for user input
            Console.WriteLine("Enter word: ");
            string user_string = Console.ReadLine();
            Console.WriteLine(); // new line

            //initialise reversed string
            string Reverse_string = string.Empty;

            //step through in reverse
            Console.WriteLine(); // new line
            for (int counter = user_string.Length - 1; counter >= 0; counter--)
            {
                //append each character to new string
                Reverse_string += user_string[counter];
            }

            //print reversed string
            Console.WriteLine("The reverse string {0}", Reverse_string);

            //test if reversed string is same as input string
            if (Reverse_string == user_string)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
