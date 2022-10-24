using System;

namespace Stars_on_Screen
// Free to use Arrays, ArrayList or StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise number of layers
            int num_layers = 5;

            //loop over n of lines
            for (int i = 1; i < num_layers + 1; i++)
            {

                //PRINT INITIAL SPACES: (num_layers - 1) number of spaces
                for (int space = 0; space < num_layers - i; space++)
                {
                    Console.Write(" ");
                }

                //PRINT ALTERNATING SEQUENCE OF STAR
                //For first case: just print one star
                Console.Write("*");
                //then append n additional space stars for each new line after this
                if (i > 1)
                {
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("**");
                    }
                }

                //start new line
                Console.WriteLine();
            }
        }
    }
}
