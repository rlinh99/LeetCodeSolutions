public class Solution
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p))
            return string.IsNullOrEmpty(s);
        var dp = new bool[s.Length + 1, p.Length + 1];
        //initialize dp matrix
        dp[0, 0] = true;
        // handle the cases when s = 0;
        for (int i = 2; i <= p.Length; i++)
            dp[0, i] = p[i - 1] == '*' && dp[0, i - 2];

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                //if current position is not star - only valid matching will be s[i-1] == p[j-1] or pattern = '.'
                if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                    dp[i, j] = dp[i - 1, j - 1];
                /* if current position = '*'.
                   1.when curr represents 0. 
                   2. when curr follows a char
                   3. when curr follows '.'
                   also previous curr must be valid in this subcase.
                */
                else if (p[j - 1] == '*')
                    dp[i, j] = dp[i, j - 2] || ((s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1, j]);
            }
        }
        return dp[s.Length, p.Length];
    }
}