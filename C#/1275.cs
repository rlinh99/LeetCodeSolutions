/*
    LC1275
    Find Winner of TicTacToe
    Explanation:
    Record value of each column, row, diagnal and antiDiagnal

    Easy
*/

public class Solution
{
    public string Tictactoe(int[][] moves)
    {
        int[] rows = new int[3];
        int[] cols = new int[3];
        int diag = 0;
        int antiDiag = 0;

        for (int i = 0; i < moves.Length; i++)
        {
            int player = i % 2 == 0 ? 1 : -1;

            rows[moves[i][0]] += player;
            cols[moves[i][1]] += player;

            if (moves[i][0] == moves[i][1])
                antiDiag += player;
            if (moves[i][0] == 2 - moves[i][1])
                diag += player;

            if (rows.Where(x => x == 3).Any() || cols.Where(x => x == 3).Any()
              || diag == 3 || antiDiag == 3)
                return "A";

            if (rows.Where(x => x == -3).Any() || cols.Where(x => x == -3).Any()
              || diag == -3 || antiDiag == -3)
                return "B";
        }

        return moves.Length == 9 ? "Draw" : "Pending";
    }
}