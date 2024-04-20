using FinalyChessProject;
using System.Collections.Generic;

namespace FinalChessProject.Figures
{
    internal class Rook : Figs
    {
        public char Color { get; private set; }
        public char FigureImg { get; private set; }
        public Coordinate Coord { get; set; }

        public Rook(char pieceColor)
        {
            Color = pieceColor;
            FigureImg = (pieceColor == 'W') ? '\u2656' : '\u265C';
        }

        public bool RookMove(Coordinate firstCoordinate, Coordinate secondCoordinate)
        {
            return firstCoordinate.i == secondCoordinate.i || firstCoordinate.j == secondCoordinate.j;
        }

        public List<Coordinate> FilterValidMoves(Coordinate startCoord, List<Coordinate> coordinates)
        {
            List<Coordinate> validMoves = new List<Coordinate>();

            foreach (var destinationCoord in coordinates)
            {
                if (RookMove(startCoord, destinationCoord))
                {
                    validMoves.Add(destinationCoord);
                }
            }

            return validMoves;
        }

        public List<Coordinate> CheckPossibleMoves(Coordinate startCoord)
        {
            List<Coordinate> possibleMoves = new List<Coordinate>();

           
            for (int i = 0; i < 8; i++)
            {
                Coordinate newCord = new Coordinate();
                newCord.i = i;

                if (i != startCoord.i)
                {
                    possibleMoves.Add(new Coordinate(newCord.i, startCoord.j));
                }
            }

         
            for (int j = 0; j < 8; j++)
            {
                if (j != startCoord.j)
                {
                    possibleMoves.Add(new Coordinate((int)startCoord.i, j));
                }
            }

            return possibleMoves;
        }
    }
}
