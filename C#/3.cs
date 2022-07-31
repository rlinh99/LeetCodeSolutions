/*
Longest Substring Without Repeating Character.
Use Dictionary/HashMap to record last appreance of a char.

Medium
*/

public class Solution3
{
    public int LengthOfLongestSubstring(string s)
    {
        int m = s.Length;
        int res = 0;
        Dictionary<char, int> dict = new();
        int i = 0;
        for (int j = 0; j < m; j++)
        {
            if (dict.ContainsKey(s[j]))
                i = Math.Max(i, dict[s[j]]);
            res = Math.Max(res, j - i + 1);
            dict[s[j]] = j + 1;
        }
        return res;
    }
}
