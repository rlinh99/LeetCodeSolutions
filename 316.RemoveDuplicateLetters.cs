public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        Dictionary<char, int> dict = new();
        HashSet<char> visited = new();
        Stack<char> stk = new();
        //find the last position of the string.
        for (int k = 0; k < s.Length; k++)
            dict[s[k]] = k;

        for (int i = 0; i < s.Length; i++)
        {
            while (stk.Count > 0 && stk.Peek() > s[i]
                 && dict[stk.Peek()] > i && !visited.Contains(s[i]))
            {
                visited.Remove(stk.Pop());
            }

            if (!visited.Contains(s[i]))
            {
                stk.Push(s[i]);
                visited.Add(s[i]);
            }
        }
        return string.Join("", stk.Reverse());
    }
}