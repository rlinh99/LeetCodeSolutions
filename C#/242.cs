/*
Valid Anagram

Easy
*/
public class Solution242
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        
        Dictionary<char, int> dictS = new();
        Dictionary<char, int> dictT = new();

        foreach (char c in s)
        {
            if (!dictS.ContainsKey(c))
                dictS[c] = 0;
            dictS[c]++;
        }
        
        foreach (char c in t)
        {
            if (!dictT.ContainsKey(c))
                dictT[c] = 0;
            dictT[c]++;
        }

        foreach (var pair in dictS)
        {
            if (!dictT.ContainsKey(pair.Key) || dictT[pair.Key] != pair.Value)
                return false;
        }
        return true;
    }
}