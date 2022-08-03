/*
    LC994
    Rotting Orange
    BFS and count the number of fresh oranges

    Medium
*/

public class RottingOrangeSolution
{
    public int OrangesRotting(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        
        List<(int, int)> dirs = new List<(int, int)>{
            (1, 0), (0, 1), (-1, 0), (0, -1)
        };

        Queue<(int, int)> q = new();
        int fresh = 0;
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 2)
                    q.Enqueue((i, j));
                if (grid[i][j] == 1)
                    fresh++;
            }
        }

        if (fresh == 0)
            return 0;

        int res = 0;
        while (q.Count > 0)
        {
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                var curr = q.Dequeue();
                int x = curr.Item1, y = curr.Item2;
                foreach (var dir in dirs)
                {
                    int newx = x + dir.Item1;
                    int newy = y + dir.Item2;
                    if (newx >= 0 && newx < m && newy >= 0 && newy < n && grid[newx][newy] == 1)
                    {
                        grid[newx][newy] = 2;
                        q.Enqueue((newx, newy));
                        fresh--;
                    }
                }
            }
            res++;
        }

        return fresh == 0 ? res - 1 : -1;
    }
}