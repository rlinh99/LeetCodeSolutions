/*
    Is Subsequence
    
    Explanation:
    search on left string, two pointers

    Easy
*/

public class Solution392
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;

        int left = 0, right = 0;
        while (left < s.Length && right < t.Length)
        {
            if (s[left] == t[right])
                left++;
            right++;

            if (left == s.Length)
                return true;
        }
        return false;
    }
}