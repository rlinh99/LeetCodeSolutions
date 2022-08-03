/*
    Isomorphic String

    Explanation:
    check distinct mapping with dictionary

    Easy
*/

public class Solution205
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> dict = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.ContainsKey(s[i]))
            {
                if (dict.ContainsValue(t[i]))
                    return false;
                dict[s[i]] = t[i];
            }

            if (dict[s[i]] != t[i])
                return false;
        }

        return true;
    }
}