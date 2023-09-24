using System;

/// <summary>
/// Tabuleiro do Jogo
/// </summary>
public class Board
{
    private int[] board;
    
    /// <summary>
    /// Obtém a posição do jogador 1.
    /// </summary>
    public int Player1Position { get; private set; }
    
    /// <summary>
    /// Obtém a posição do jogador 2.
    /// </summary>
    public int Player2Position { get; private set; }
    
    /// <summary>
    /// Obtém o número de peças do jogador 1.
    /// </summary>
    public int Player1Pieces { get; private set; }
    
    /// <summary>
    /// Obtém o número de peças do jogador 2.
    /// </summary>
    public int Player2Pieces { get; private set; }

    /// <summary>
    /// Cria uma nova instância da classe <see cref="Board"/>
    /// </summary>
    public Board()
    {
        board = new int[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Player1Position = 0;
        Player2Position = 0;
        Player1Pieces = 7;
        Player2Pieces = 7;
    }

    /// <summary>
    /// Coloca a peça na posição correta
    /// </summary>
    /// <param name="position">Posição da peça no tabuleiro</param>
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

    /// <summary>
    /// Move a peça do jogador tendo em conta o número de passos
    /// </summary>
    /// <param name="player">Jogador que se está a mover</param>
    /// <param name="steps">Número dos passos que o jogador move</param>
    public void MovePiece(int player, int steps)
    {
        int currentPosition = 0;
        switch (player)
        {
            case 1:
                currentPosition = Player1Position;
                break;
            case 2:
                currentPosition = Player2Position;
                break;
        }

        board[currentPosition] = 0;

        int newPosition = currentPosition + steps;

        if (newPosition >= board.Length)
        {
            newPosition = 0;

            if (player == 1)
            {
                Player1Pieces--;
            }
            else
            {
                Player2Pieces--;
            }
        }

        if (player == 1)
            Player1Position = newPosition;
        else
            Player2Position = newPosition;
        board[newPosition] = player;
    }

    /// <summary>
    /// Verifica se um jogador venceu (número de peças = 0)
    public bool CheckWin()
    {
        if (Player1Pieces == 0)
        {
            Console.WriteLine("Player 1 wins!");
            return true;
        }
        else if (Player2Pieces == 0)
        {
            Console.WriteLine("Player 2 wins!");
            return true;
        }
        return false;
    }

    /// <summary>
    /// Remove a peça do jogador da posição onde se encontra
    /// </summary>
    /// <param name="player">Jogador que vai ficar sem peça</param>
    public void DestroyPiece(int player)
    {
        int currentPosition;
        if (player == 1)
        {
            currentPosition = Player1Position;
        }
        else
        {
            currentPosition = Player2Position;
        }
        board[currentPosition] = 0;
    }
}