using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[] { -1 }; // -1表示未找到
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        result = new int[] { i, j };
                }
            }

            return result;
        }
    }
}
