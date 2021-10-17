// ---------------------------------------------------------------------------
// 2023. Number of Pairs of Strings With Concatenation Equal to Target
// https://leetcode.com/problems/number-of-pairs-of-strings-with-concatenation-equal-to-target/
// ---------------------------------------------------------------------------

namespace CodeKata2077.LeetCode
{
    using System.Linq;

    class Medium2023
    {
		/// <summary>
		/// A straightforward solution is using backtrack or nested For loops, however the time complexity is O(N^2).
		/// Below solution leverages the Dictionary to optimize the time complexity to O(N).
		/// </summary>
		public int NumOfPairs(string[] nums, string target)
		{
			int pairs = 0;
			var freqs = nums.GroupBy(num => num).ToDictionary(num => num.Key, num => num.Count()); ;

			foreach (var (key, value) in freqs) 
			{
				if (target.StartsWith(key)) 
				{
					var rest = target[key.Length..];
					if (freqs.TryGetValue(rest, out int rFreq)) 
					{
						if (rest == key) 
						{
							rFreq--;
						}
						pairs += value * rFreq;
					}
				}
			}

			return pairs;
		}
	}
}
