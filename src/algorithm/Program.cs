using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            Console.WriteLine(string.Join(",", TwoSum.Solution.TwoSum(nums, 8)));

            Console.ReadLine();
        }
    }
}
