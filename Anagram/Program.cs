using System;
using System.Linq;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise word array, star char charray and valid_anagrams list
            string[] words = { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };
            char[] star = { 's', 't', 'a', 'r' };
            List<string> valid_anagrams = new List<string>();

            //declare ok_counter
            int ok_counter = 0;
            bool valid_char = true;

            //for every word in dictionary
            foreach (string word in words)
            {
                Console.WriteLine("Word = {0}", word);

                //reset ok_counter and valid_char before each new word
                ok_counter = 0;
                valid_char = true;

                //for every character in word
                foreach (char character in word)
                {

                    Console.WriteLine("character = {0}", character);

                    //if character in [s, t, a, r], increment ok_counter
                    if (star.Contains(character))
                    {
                        ++ok_counter;
                    }

                    //else, break
                    else
                    {
                        Console.WriteLine("Invalid character: Not anagram");
                        valid_char = false; //set valid_char to false
                        break;
                    }

                }
                //if ok_counter == 4 and valid_char is true, append word to list of anagrams
                if (ok_counter == 4 && valid_char == true)
                {
                    Console.WriteLine("True anagram");
                    //append to valid_anagrams list
                    valid_anagrams.Add(word);
                }
                if (ok_counter != 4 && valid_char == true)
                {
                    Console.WriteLine("Too many/too few characters: Not anagram");
                }
            }

            //after all words checked
            Console.WriteLine("True anagrams:");
            foreach (var anagram in valid_anagrams)
            {
                Console.WriteLine(anagram);
            }
        }
    }
}
