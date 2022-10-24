using System;

namespace Problems
{
    class Program
    {
        // Custom problem: Find a randomly chosen number between 1 and 99 with 5 tries
        static void Main(string[] args)
        {
            //create random  numebr generator
            System.Random random = new System.Random();

            //initialise secret_number
            int secret_number = random.Next(100);

            Console.WriteLine("secret_number = {0}", secret_number);

            //initialise guess var
            int guess = 0;

            //for each of 5 guesses
            for (int i = 0; i < 5; i++)
            {
                // ask for user input
                Console.Write("Enter guess: ");
                guess = Convert.ToInt16(Console.ReadLine());

                // give conditional output: higher/lower/equal = win
                //if get correct
                if (guess == secret_number)
                {
                    Console.WriteLine("GUESS CORRECT!");
                    break;
                }
                else if (guess > secret_number)
                {
                    Console.WriteLine("Try lower");
                }
                else
                {
                    Console.WriteLine("Try higher");
                }

                //if final go give final pass/fail
                if (i==4)
                {
                    Console.WriteLine("Final guess failed");
                }

            }

         Console.WriteLine("GAME OVER");

        }
    }
}
