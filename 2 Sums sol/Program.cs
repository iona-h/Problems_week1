using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Sums_sol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10));
            Console.ReadLine();
        }
        public static (int, int)? FindTwoSum(List<int> y, int x)
        {
            int length = y.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (y[i] + y[j] == x)
                    {
                        return (i, j);
                    }
                }
            }
            return null;
        }
    }
}
