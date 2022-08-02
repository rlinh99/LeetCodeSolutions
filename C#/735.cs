/*
Asteroid Collision
Simple Stack

Medium
*/

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stk = new Stack<int>();
        foreach (var a in asteroids)
        {
            if (stk.Count == 0)
            {
                stk.Push(a);
                continue;
            }

            if (stk.Peek() * a > 0 ||
              (stk.Peek() * a < 0 && a > 0))
            {
                stk.Push(a);
                continue;
            }

            bool alive = true;
            while (stk.Count != 0 && stk.Peek() * a < 0)
            {
                var b = stk.Pop();
                if (Math.Abs(a) > Math.Abs(b))
                    continue;
                else
                {
                    if (Math.Abs(a) != Math.Abs(b))
                        stk.Push(b);
                    alive = false;
                    break;
                }
            }
            if (alive)
                stk.Push(a);
        }

        var result = stk.ToArray();
        Array.Reverse(result);
        return result;
    }
}