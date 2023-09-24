using System;


namespace ProjetoFinalLP1
{
    /// <summary>
    /// Class Program (principal)
    /// </summary>
    class Program
    {
        /// <summary>
        /// Primeira função a ser chamada, quando o programa é executado
        /// </summary>
        /// <param name="args">Lê os inputs da linha de comandos</param>
        static void Main(string[] args)
        {
            Board board = new Board();
            int currentPlayer = 1;
            Random random = new Random();

            while (true)
            {
                GameBoard(board);
                Console.WriteLine("Player " + currentPlayer + ", it's your turn!!");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                int steps = random.Next(1, 5);
                Console.WriteLine("Number of Steps: " + steps);

                board.MovePiece(currentPlayer, steps);

                if (board.CheckWin())
                {
                    break;
                }

                if (currentPlayer == 1)
                {
                    currentPlayer = 2;
                }
                else
                {
                    currentPlayer = 1;
                }
            }
        }

        /// <summary>
        /// Mostra o estado atual do tabuleiro.
        /// </summary>
        /// <param name="board">Tabuleiro</param>
        static void GameBoard(Board board)
        {
            string[] boardPositions = new string[14];

            for (int i = 0; i < 14; i++)
            {
                switch (board.GetPiece(i))
                {
                    case 0:
                        boardPositions[i] = "-";
                        break;
                    case 1:
                        boardPositions[i] = "X";
                        break;
                    case 2:
                        boardPositions[i] = "O";
                        break;
                }
            }

            Console.WriteLine("   1   2   3   4   5   6");
            Console.WriteLine(" ╔═══╦═══╦═══╦═══╦═══╦═══╗");
            Console.WriteLine(" ║   ║   ║   ║   ║   ║   ║");
            Console.WriteLine($"1║ {boardPositions[0]} ║ {boardPositions[1]} ║ {boardPositions[2]} ║ {boardPositions[3]} ║ {boardPositions[4]} ║ {boardPositions[5]} ║");
            Console.WriteLine(" ║   ║   ║   ║   ║   ║   ║");
            Console.WriteLine(" ╠═══╬═══╬═══╬═══╬═══╬═══╣");
            Console.WriteLine(" ║   ║   ║   ║   ║   ║   ║");
            Console.WriteLine($"2║ {boardPositions[6]} ║ {boardPositions[7]} ║ {boardPositions[8]} ║ {boardPositions[9]} ║ {boardPositions[10]} ║ {boardPositions[11]} ║");
            Console.WriteLine(" ║   ║   ║   ║   ║   ║   ║");
            Console.WriteLine(" ╚═══╩═══╩═══╩═══╩═══╩═══╝");
            Console.WriteLine("   7  8  9   10   11   12");
            Console.WriteLine("Player 1 is in position: " + board.Player1Position);
            Console.WriteLine("Player 2 is in position: " + board.Player2Position);
        }
    }
}