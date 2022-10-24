using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise number of layers
            int num_layers = 5;

            //Top to centre of diamond----

            //loop over n of lines
            for (int i = 1; i < num_layers + 1; i++)
            //for (int i = num_layers + 1; i >= 1; i--)
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

            //Centre to bottom of diamond----

            //loop over n of lines
            //for (int i = 1; i < num_layers + 1; i++)
            //for (int i = num_layers + 1; i >= 1; i--)
            for (int i = num_layers - 1; i >= 1; i--)
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
