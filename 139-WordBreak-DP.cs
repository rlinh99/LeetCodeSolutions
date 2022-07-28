/*
Time: O(n^3) due to two loops + 1 substring operation.
*/
public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> hs = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;
        for (int i = 0; i <= s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                if (dp[i] && hs.Contains(s.Substring(i, j - i)))
                {
                    dp[j] = true;
                }
            }
        }
        return dp[s.Length];
    }
}