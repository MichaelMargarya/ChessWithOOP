using FinalChessProject;
using FinalChessProject.Figures;
using FinalyChessProject.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalyChessProject.SecondGame;


public class Mate
{
    Rook rook1 = new Rook('B');
    Rook rook2 = new Rook('B');
    Queen queen = new Queen('B');
    King wKing = new King('W');

    public Coordinate WhiteKingMove(Coordinate current)
    {
        Console.WriteLine("Enter the move coordinate");
        Coordinate destination = new Coordinate(Console.ReadLine());
        if (wKing.KingMove(current, destination))
        {
            return destination;
        }
        else
        {
            throw new ArgumentException("Invalid move!");
        }
    }

    public void Mat(List<Coordinate> coordinates, Coordinate coordR1, Coordinate coordR2, Coordinate coordQ,
    Coordinate coordBK, Coordinate coordWK)
    {
        Board board = new Board();
        bool mate = false;

        // Передвигаем белого короля на первом шаге
        coordWK = WhiteKingMove(coordWK);

        do
        {
            List<Coordinate> rook1Steps = rook1.FilterValidMoves(coordR1, coordinates);
            List<Coordinate> rook2Steps = rook2.FilterValidMoves(coordR2, coordinates);
            List<Coordinate> queenSteps = queen.FilterValidMoves(coordQ, coordinates);

            if (Math.Abs(coordR1.j - coordWK.j) != 1)
            {
                if (CheckR1(rook1Steps, ref coordR1, coordWK))
                {
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
                else if (CheckR2(rook2Steps, ref coordR2, coordWK))
                {
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
                else
                {
                    coordR1.i += 1;
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
            }
            else if (Math.Abs(coordR2.j - coordWK.j) != 1)
            {
                if (CheckR2(rook2Steps, ref coordR2, coordWK))
                {
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
                else
                {
                    coordR2.i += 2;
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
            }
            else if (Math.Abs(coordQ.j - coordWK.j) != 0)
            {
                if (CheckQ(queenSteps, ref coordQ, coordWK))
                {
                    coordQ.j = coordWK.j; 
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
                else
                {
                    coordQ.i += 3; 
                    board.PrintFiguresLetterOnTheBoard(coordR1, coordR2, coordQ, coordBK, coordWK);
                }
            }

        
            if (Math.Abs(coordR1.j - coordWK.j) == 1 && Math.Abs(coordR2.j - coordWK.j) == 1
                && Math.Abs(coordQ.j - coordWK.j) == 0)
            {
                mate = true;
                Console.WriteLine("You lose the game!");
                break;
            }
            else
            {
                mate = false;
                coordWK = WhiteKingMove(coordWK); 
            }

        } while (!mate);
    }


    public bool CheckR1(List<Coordinate> rook1Steps, ref Coordinate coordR1, Coordinate coordWK)
    {
        Coordinate c = new Coordinate();
        if (coordWK.j != 1)
        {
            c.j = coordWK.j - 1;
        }
        else
        {
            c.j = coordWK.j + 1;
        }
        c.i = coordR1.i;
        if (rook1Steps.Contains(c))
        {
            coordR1.j = c.j;
            coordR1.i = c.i;
            return true;
        }
        return false;
    }

    public bool CheckR2(List<Coordinate> rook2Steps, ref Coordinate coordR2, Coordinate coordWK)
    {
        Coordinate c = new Coordinate();
        if (coordWK.j != 8)
        {
            c.j = coordWK.j + 1;
        }
        else
        {
            c.j = coordWK.j - 1;
        }
        c.i = coordR2.i;
        if (rook2Steps.Contains(c))
        {
            coordR2.j = c.i;
            coordR2.i = c.i;
            return true;
        }
        return false;
    }

    public bool CheckQ(List<Coordinate> queenSteps, ref Coordinate coordQ, Coordinate coordWK)
    {
        Coordinate c = new Coordinate();
        c.j = coordWK.j;
        c.i = coordQ.i;
        if (queenSteps.Contains(c))
        {
            return true;
        }
        return false;
    }
}
