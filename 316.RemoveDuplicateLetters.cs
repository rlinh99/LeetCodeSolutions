public class Solution
{
    public string RemoveDuplicateLetters(string s)
    {
        if (s.Length == 0)
            return s;

        Dictionary<char, int> dict = new();

        for (int k = 0; k < s.Length; k++)
            dict[s[k]] = k;

        HashSet<char> visited = new();
        Stack<char> stk = new();

        for (int i = 0; i < s.Length; i++)
        {
            while (stk.Count > 0 &&
                  stk.Peek() > s[i] && dict.ContainsKey(stk.Peek())
                  && dict[stk.Peek()] > i && !visited.Contains(s[i]))
            {
                //when peek will present after current position, remove it safely
                visited.Remove(stk.Peek());
                stk.Pop();
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