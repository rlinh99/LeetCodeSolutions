/*
    Single Number 2
    Same as 136

    Medium
*/
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, int> dict = new();
        foreach (int num in nums)
        {
            if (!dict.ContainsKey(num))
                dict[num] = 0;
            dict[num]++;
        }
        return dict.Where(x => x.Value == 1).First().Key;
    }
}