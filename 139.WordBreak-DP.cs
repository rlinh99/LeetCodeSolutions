/*
Time: O(n^3) due to two loops + 1 substring operation.
*/
public class SolutionDP
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

public class SolutionDFS
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> hs = new HashSet<string>(wordDict);
        Queue<int> q = new();
        bool[] visited = new bool[s.Length];

        q.Enqueue(0);
        while (q.Count > 0)
        {
            var curr = q.Dequeue();
            if (visited[curr])
                continue;

            visited[curr] = true;
            for (int i = curr + 1; i <= s.Length; i++)
            {

                if (hs.Contains(s.Substring(curr, i - curr)))
                {
                    if (i == s.Length)
                        return true;

                    q.Enqueue(i);
                }
            }
        }
        return false;
    }
}