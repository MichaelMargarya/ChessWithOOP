using System;
namespace FinalChessProject;
    using FinalChessProject.Figures;
using static System.Console;
    using FinalyChessProject.Figures;
    using FinalyChessProject;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Headers;

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

        public bool IsStalemate(Coordinate king, Coordinate queen, Coordinate fRook, Coordinate sRook)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    Coordinate neighbor = new Coordinate { i = king.i + i, j = king.j + j };

                    if (!IsCheck(neighbor, queen, fRook, sRook))
                        return false;
                }
            }

            Console.WriteLine("*******Stalemate*******");
            return true;
        }

        public bool CheckMate(Coordinate king, Coordinate queen, Coordinate fRook, Coordinate sRook)
        {
            return IsCheck(king, queen, fRook, sRook) && IsStalemate(king, queen, fRook, sRook);
        }
        public bool ValidCoord(Coordinate wKing , Coordinate Queen , Coordinate fRook , Coordinate sRook )
        {
            if(!IsStalemate(wKing,Queen,fRook,sRook) && IsCheck(wKing,Queen,fRook,sRook))
            {
                return true;
            }
        return false;
        }

    //public Coordinate ValCoord(Coordinate whiteKingCoordinate, Coordinate blackQueen, Coordinate firstRook, Coordinate secondRook)
    //{
    //    Board map = new Board();

    //    if (!IsStalemate(whiteKingCoordinate, blackQueen, firstRook, secondRook) && !IsCheck(whiteKingCoordinate, blackQueen, firstRook, secondRook))
    //    {

    //      //  return map.GetCoordinate(map.map);
    //    }
    //    else
    //    {

    //        Console.WriteLine("Enter new Coordinate:");
    //        return ValCoord(whiteKingCoordinate, blackQueen, firstRook, secondRook);
    //    }
    //}
    //public Coordinate GetCoordinate(string[,] map)
    //{


    //    for (int i = 0; i < 8; i++)
    //    {
    //        for (int j = 0; j < 8; j++)
    //        {

    //            Coordinate tempCoord = new Coordinate();
    //            tempCoord.i = i;
    //            tempCoord.j = j;
    //         //   bool game = IsStalemate(tempCoord, blackQueen, firstRook, secondRook);// && !IsCheck(whiteKing, blackQueen, firstRook, secondRook)
    //            if (game)
    //            {
    //                Coordinate list = new Coordinate();
    //                list.Add(tempCoord);
    //                return list;
    //            }
    //        }
    //    }


    //    return new Coordinate();
    //}

}

