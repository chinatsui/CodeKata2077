// ---------------------------------------------------------------------------
// 1. Two Sum
// https://leetcode.com/problems/two-sum/
// ---------------------------------------------------------------------------

using System.Collections.Generic;

namespace CodeKata2077.LeetCode
{
    static class Easy1
    {
        public static int[] TwoSum(int[] nums, int target) 
        {
            var numIndices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                if (numIndices.TryGetValue(target - nums[i], out int j))
                {
                    return new int[] { i, j };
                }
                else 
                {
                    numIndices[nums[i]] = i;
                }
            }
            return null;
        }
    }
}
