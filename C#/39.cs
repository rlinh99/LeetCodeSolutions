/*
    39. Combination Sum

    Explanation:
    Classic Backtracking.

    Medium
*/

public class Solution39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> res = new();
        Backtrack(res, new List<int>(), candidates, target, 0);
        return res;
    }

    private void Backtrack(List<IList<int>> res, List<int> aRes, int[] candidates, int target, int pos)
    {
        if (target == 0)
        {
            res.Add(new List<int>(aRes));
            return;
        }

        if (target < 0)
            return;
            
        for (int i = pos; i < candidates.Length; i++)
        {
            aRes.Add(candidates[i]);
            Backtrack(res, aRes, candidates, target - candidates[i], i);
            aRes.RemoveAt(aRes.Count - 1);
        }
    }
}
