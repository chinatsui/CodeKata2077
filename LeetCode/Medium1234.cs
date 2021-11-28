// ---------------------------------------------------------------------------
// 1234. Replace the Substring for Balanced String
// https://leetcode.com/problems/replace-the-substring-for-balanced-string/
// ---------------------------------------------------------------------------

using System;

namespace CodeKata2077.LeetCode
{
    internal class Medium1234
    {
        public static int BalancedString(string str) 
        {
            if (string.IsNullOrEmpty(str) || str.Length % 4 != 0)
            {
                throw new ArgumentException("Invalid Input", str);
            }

            int[] count = new int[128];
            foreach (char ch in str)
            {
                count[ch]++;
            }

            int start = 0, n = str.Length, k = n / 4, res = n;
            for (int end = 0; end < n; end++)
            {
                count[str[end]]--;
                while (start < n && count['Q'] <= k && count['W'] <= k && count['E'] <= k && count['R'] <= k)
                {
                    res = Math.Min(res, end - start + 1);
                    count[str[start++]]++;
                }
            }

            return res;
        }
    }
}
