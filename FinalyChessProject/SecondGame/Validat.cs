using FinalChessProject;
using FinalChessProject.Figures;
using FinalyChessProject;
using System;
using System.Collections.Generic;

namespace FinalChessProject
{
    internal class Validation : Figs
    {
        public bool QueenAttacksKing(Coordinate queen, Coordinate king)
        {
            return queen.i == king.i || queen.j == king.j || Math.Abs(queen.i - king.i) == Math.Abs(queen.j - king.j);
        }

        public bool RookAttacksKing(Coordinate rook, Coordinate king)
        {
            return rook.i == king.i || rook.j == king.j;
        }

        public bool IsCheck(Coordinate kingPosition, Coordinate queen, Coordinate fRook, Coordinate sRook)
        {
            return QueenAttacksKing(queen, kingPosition) || RookAttacksKing(fRook, kingPosition) || RookAttacksKing(sRook, kingPosition);
        }

        public bool IsStalemate(Coordinate king, Coordinate queen, Coordinate fRook, Coordinate sRook, Coordinate blackKing)
        {
            List<Coordinate> list = new List<Coordinate> { fRook, sRook, queen, blackKing, king };

            int num = king.j;
            int let = king.i;

            for (int i = num - 1; i <= num + 1; i++)
            {
                for (var j = let - 1; j <= let + 1; j++)
                {
                    if (i != num || j != let)
                    {
                        king.i = i;
                        king.j = j;
                        if (!IsTheKingUnderAttack(list))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }


        public bool CheckMate(Coordinate king, Coordinate queen, Coordinate fRook, Coordinate sRook,Coordinate blackk)
        {
            return IsCheck(king, queen, fRook, sRook) && IsStalemate(king,queen,fRook,sRook,blackk);
        }

        public bool ValidCoord(Coordinate wKing, Coordinate Queen, Coordinate fRook, Coordinate sRook, Coordinate blackk)
        {
            if (!IsStalemate(wKing, Queen, fRook, sRook, blackk) && IsCheck(wKing, Queen, fRook, sRook))
            {
                return true;
            }
            return false;
        }

        public bool EqualCoordinates(List<Coordinate> coordinates)
        {
            return coordinates.Count == coordinates.Distinct().Count();
        }

        public bool IsTheKingUnderAttack(List<Coordinate> Cord)
        {
            //0 - Rook1, 1- Rook2 , 2- Queen , 3 - blackking , 4- whiteKing
            if ((Math.Abs((int)Cord[4].i - (int)Cord[2].i)) == Math.Abs((Cord[4].j - Cord[2].j)) ||
               Cord[4].j == Cord[2].j || Cord[4].i == Cord[2].i)
            {
                return false;
            }
            else if ((Cord[4].j == Cord[0].j || Cord[4].i == Cord[0].i))
            {
                return false;
            }
            else if ((Cord[4].j == Cord[1].j || Cord[4].i == Cord[1].i))
            {
                return false;
            }
            else if ((Math.Abs(Cord[4].j - Cord[3].j) == 1 &&
                Math.Abs((int)Cord[4].i - (int)Cord[3].i) == 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

