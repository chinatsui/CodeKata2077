// ---------------------------------------------------------------------------
// 2042. Check if Numbers Are Ascending in a Sentence
// https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/
// ---------------------------------------------------------------------------

namespace CodeKata2077.LeetCode
{
    using System;

    static class Easy2042
    {
        public static bool AreNumbersInAscending(string s) 
        {
            if (string.IsNullOrEmpty(s)) 
            {
                return false;
            }

            string[] subs = s.Split(' ', StringSplitOptions.None);
            int last = -1;
            foreach (string sub in subs)
            {
                if (int.TryParse(sub, out int cur))
                {
                    if (cur <= last)
                    {
                        return false;
                    }
                    last = cur;
                }
            }
            return true;
        }
    }
}
