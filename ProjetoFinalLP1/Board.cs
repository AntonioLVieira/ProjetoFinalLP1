using System;

public class Board
{
    private int[] board;
    public int player1Position { get; private set; }
    public int player2Position { get; private set; }

    public Board()
    {
        board = new int[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        player1Position = 0;
        player2Position = 0;
    }

    public int GetPieceAtPosition(int position)
    {
        if (position >= 0 && position < board.Length)
        {
            return board[position];
        }
        else
        {
            return -1;
        }
    }

    public void MovePiece(int player, int steps)
    {
        int currentPosition = (player == 1) ? player1Position : player2Position;

        board[currentPosition] = 0;

        int newPosition = currentPosition + steps;

        if (newPosition >= board.Length)
            newPosition = board.Length - 1;

        if (player == 1)
            player1Position = newPosition;
        else
            player2Position = newPosition;

        board[newPosition] = player;
    }

    public bool CheckWin(int player)
    {
        return (player1Position >= board.Length - 1 || player2Position >= board.Length - 1);
    }
}