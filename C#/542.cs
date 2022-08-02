public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {

        if (mat == null || mat.Length == 0)
            return new int[0][];

        int m = mat.Length, n = mat[0].Length;
        Queue<(int, int)> q = new();
        HashSet<(int, int)> visited = new();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 0)
                {
                    q.Enqueue((i, j));
                    visited.Add((i, j));
                }
            }
        }

        List<(int, int)> dirs = new List<(int, int)>(){
            (0,1), (1,0), (0,-1), (-1, 0)
        };
        int dis = 1;
        while (q.Count > 0)
        {
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                var curr = q.Dequeue();

                foreach (var dir in dirs)
                {
                    int newX = curr.Item1 + dir.Item1;
                    int newY = curr.Item2 + dir.Item2;
                    if (newX >= 0 && newX < m && newY >= 0 && newY < n && !visited.Contains((newX, newY)))
                    {
                        mat[newX][newY] = dis;
                        q.Enqueue((newX, newY));
                        visited.Add((newX, newY));
                    }
                }
            }
            dis++;
        }

        return mat;
    }
}