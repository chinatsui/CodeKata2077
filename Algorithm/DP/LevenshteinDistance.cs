using System;

namespace CodeKata2077.Algorithm.DP
{
    class LevenshteinDistance
    {
        public static int Calculate(string strA, string strB) 
        {
            if (string.IsNullOrEmpty(strA) && string.IsNullOrEmpty(strB)) return 0;

            if (string.IsNullOrEmpty(strA)) return strB.Length;

            if (string.IsNullOrEmpty(strB)) return strA.Length;

            // normalize to lower case.
            strA = strA.ToLower();
            strB = strB.ToLower();

            int n = strA.Length, m = strB.Length;
            int[,] minDist = new int[n, m];
            minDist[0, 0] = strA[0] == strB[0] ? 0 : 1;

            // init the first row.
            for (int j = 1; j < m; j++) 
            {
                minDist[0, j] = minDist[0, j - 1] + 1;
            }

            // init the first column.
            for (int i = 1; i < n; i++) 
            {
                minDist[i, 0] = minDist[i - 1, 0] + 1;
            }

            // Start DP.
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    minDist[i, j] = Math.Min(
                        Math.Min(minDist[i - 1, j] + 1, minDist[i, j - 1] + 1),
                        strA[i] == strB[j] ? minDist[i - 1, j - 1] : minDist[i - 1, j - 1] + 1);
                }
            }

            return minDist[n - 1, m - 1];
        }
    }
}
