// ---------------------------------------------------------------------------
// 2023. Number of Pairs of Strings With Concatenation Equal to Target
// https://leetcode.com/problems/number-of-pairs-of-strings-with-concatenation-equal-to-target/
// ---------------------------------------------------------------------------

namespace CodeKata2077.LeetCode
{
	using System.Linq;

    static class Medium2023
    {
		/// <summary>
		/// A straightforward solution is using backtrack or nested For loops, however the time complexity is O(N^2).
		/// Below solution leverages the Dictionary to optimize the time complexity to O(N).
		/// </summary>
		public static int NumOfPairs(string[] nums, string target)
		{
			int pairs = 0;
			var freqs = nums.GroupBy(num => num).ToDictionary(num => num.Key, num => num.Count());
			foreach(var (left, lCount) in freqs) 
			{
				if (target.StartsWith(left)) 
				{
					var right = target[left.Length..];
					if (freqs.TryGetValue(right, out int rCount))
					{
						if (left == right) 
						{
							rCount--;
						}
						pairs += lCount * rCount;
					}
				}
			}
			return pairs;
		}
	}
}
