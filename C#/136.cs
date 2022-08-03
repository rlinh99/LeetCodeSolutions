/*
    136. Single Number

    Explanation:
    Simple hashmap manipulation, get value = 1's key

    Easy
*/
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> dict = new();
        foreach (var n in nums)
        {
            if (!dict.ContainsKey(n))
                dict[n] = 0;    
            dict[n]++;
        }

        return dict.Where(x => x.Value == 1).SingleOrDefault().Key;
    }
}