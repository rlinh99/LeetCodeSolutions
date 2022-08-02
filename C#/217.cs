/*
Contains Duplicate

Easy
*/
public class Solution217
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hSet = new HashSet<int>();
        foreach (var i in nums)
        {
            if (hSet.Contains(i))
                return true;
            hSet.Add(i);
        }
        return false;
    }
}