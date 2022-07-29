/*
Classic BFS Solution
*/
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> hs = new HashSet<string>(wordList);
        Queue<string> q = new();
        q.Enqueue(beginWord);
        int count = 0;

        while (q.Count > 0)
        {
            count++;
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                string curr = q.Dequeue();

                if (curr == endWord)
                    return count;

                for (int j = 0; j < curr.Length; j++)
                {
                    char[] arr = curr.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        arr[j] = c;
                        string temp = new string(arr);
                        if (hs.Contains(temp))
                        {
                            q.Enqueue(temp);
                            hs.Remove(temp);
                        }
                    }
                }
            }
        }
        return 0;
    }
}
