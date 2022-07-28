public class Solution
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