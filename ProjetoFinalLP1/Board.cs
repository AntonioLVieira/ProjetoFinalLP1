using System;

public class Board
{
    private int[] board;
    public int player1Position { get; private set; }
    public int player2Position { get; private set; }
    public int player1Pieces { get; private set; }
    public int player2Pieces { get; private set; }

    public Board()
    {
        board = new int[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        player1Position = 0;
        player2Position = 0;
        player1Pieces = 7;
        player2Pieces = 7;
    }

    public int GetPiece(int position)
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
        int currentPosition = 0;
        switch (player)
        {
            case 1:
                currentPosition = player1Position;
                break;
            case 2:
                currentPosition = player2Position;
                break;
    }

        board[currentPosition] = 0;

        int newPosition = currentPosition + steps;

        if (newPosition >= board.Length)
        {
            newPosition = 0;

            if (player == 1)
            {
                player1Pieces--;
            }
            else
            {
                player2Pieces--;
            }
        }

        if (player == 1)
            player1Position = newPosition;
        else
        player2Position = newPosition;
        board[newPosition] = player;
    }

    public bool CheckWin()
    {
        if (player1Pieces == 0)
        {
            Console.WriteLine("Player 1 wins!");
            return true;
        }
        else if (player2Pieces == 0)
        {
            Console.WriteLine("Player 2 wins!");
            return true;
        }
        return false;
    }   

    public void DestroyPiece(int player)
    {
        int currentPosition;
        if (player == 1)
        {
            currentPosition = player1Position;
        }
        else
        {
            currentPosition = player2Position;
        }
        board[currentPosition] = 0;
    }

    public void NewPiece(int player)
    {
        if (player == 1)
            player1Position = 0;
        else
            player2Position = 0;
    }
}
