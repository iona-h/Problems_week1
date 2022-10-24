using System;

namespace String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing
            //string testStr = "abc123";
            //for (int counter = 0; counter < testStr.Length; counter++)
            //{
            //    Console.WriteLine("counter = {0}", counter);
            //    Console.WriteLine(testStr[counter].ToString());
            //}

            //Console.WriteLine(); // new line
            //for (int counter = testStr.Length -1; counter >= 0; counter--)
            //{
            //    Console.WriteLine("counter = {0}", counter);
            //    Console.WriteLine(testStr[counter].ToString());
            //}

            //take user input and assign to var
            // ask for user input
            Console.WriteLine("Enter word: ");
            string user_string = Console.ReadLine();
            Console.WriteLine(); // new line

            //print out in reverse
            Console.WriteLine(); // new line
            for (int counter = user_string.Length - 1; counter >= 0; counter--)
            {
                //Console.WriteLine("counter = {0}", counter);
                Console.Write(user_string[counter].ToString());
            }

            Console.WriteLine(); //new line
        }
    }
}
