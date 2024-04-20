using FinalChessProject.Figures;
using FinalyChessProject.Figures;
using System;

namespace FinalChessProject
{
    public class Board
    {
        public string[,] map = new string[8, 8];
        private Letters let = new Letters();

        public void NewPrintMap(string[,] board)
        {
            let.AddLetterCord();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {

                    if ((i + j) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(board[i, j] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (j == 7)
                    {
                        Console.Write("| " + Convert.ToString(i + 1));
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintMap(string[,] board)
        {
            let.AddLetterCord();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = " ";
                    if ((i + j) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(" " + board[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (j == 7)
                    {
                        Console.Write("| " + Convert.ToString(i + 1));
                    }
                }
                Console.WriteLine();
            }
        }

        public void AddFiguresInMap(Coordinate coordinate, string[,] map, char figure)
        {
            if (coordinate.i < map.GetLength(0) && coordinate.j < map.GetLength(1))
            {
                map[coordinate.i, coordinate.j] = $"{figure}";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void PrintFiguresLetterOnTheBoard(Coordinate firstRook, Coordinate secondRook, Coordinate coordQueen, Coordinate coordBlackK, Coordinate coordWhiteK)
        {
            Rook firstRookFigure = new Rook('B');
            Rook secondRookFigure = new Rook('B');
            Queen queenFigure = new Queen('B');
            King blackKingFigure = new King('B');
            King whiteKingFigure = new King('W');

            AddFiguresInMap(firstRook, map, firstRookFigure.FigureImg);
            AddFiguresInMap(secondRook, map, secondRookFigure.FigureImg);
            AddFiguresInMap(coordQueen, map, queenFigure.FigureImg);
            AddFiguresInMap(coordBlackK, map, blackKingFigure.FigureImg);
            AddFiguresInMap(coordWhiteK, map, whiteKingFigure.FigureImg);
        }
    }
}
