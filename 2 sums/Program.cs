using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_sums
// Write a function that, when passed a list and a target sum,
// returns, efficiently with respect to time used, two distinct
// zero-based indices of any two of the numbers, whose sum
// is equal to the target sum
{
    class Program
    {
        //main
        static void Main(string[] args)
        {
            //initialise list and target sum
            List<int> input_list = new List<int>() { 3, 1, 5, 7, 5, 9 };
            int target_sum = 10;

            //testing

            //call FindTwoSum()
            Tuple<int, int> output = FindTwoSum(input_list, target_sum);

            //print output if not null
            if (output != null)
            {
                Console.WriteLine("output = {0}", output.ToString());
            }
            else
            {
                Console.WriteLine("No possible solution");
            }

            Console.WriteLine("Done");
            Console.ReadLine();

        }

        //bonus functions
        public static Tuple<int, int> FindTwoSum(List<int> my_list, int target)
        //public void FindTwoSum(List<int> my_list, int target)
        {
            //search through list: rotating a
            for (int i = 0; i < my_list.Count - 2; i++)
            {
                Console.WriteLine("a = {0}", my_list[i]);

                //List<int> new_list = my_list.RemoveAt(i);
                //alt strart: cloned list then remove
                List<int> clonedList = new List<int>(my_list);
                clonedList.RemoveAt(i); //checked

                //alt strat: test if number in list that can complete
                //find test_number to reach target
                int test_number = target - my_list[i]; // test**
                Console.WriteLine("test_number = {0}", test_number);

                //check if test_number in my_list
                if (my_list.Contains(test_number))
                //if yes, return (mylist[i], test_number) in output tuple
                {
                    //Tuple<int, int> output_tuple = new Tuple<int, int>(my_list[i], test_number);
                    //return output_tuple;
                    return new Tuple<int, int>(my_list[i], test_number);
                }

            }

            //otherwise, return null
            return null;
        }
    }
}
