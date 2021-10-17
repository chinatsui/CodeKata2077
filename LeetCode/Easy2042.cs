// ---------------------------------------------------------------------------
// 2042. Check if Numbers Are Ascending in a Sentence
// https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/
// ---------------------------------------------------------------------------

namespace CodeKata2077.LeetCode
{
    using System;

    class Easy2042
    {
        public bool AreNumbersInAscending(string s) 
        {
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
