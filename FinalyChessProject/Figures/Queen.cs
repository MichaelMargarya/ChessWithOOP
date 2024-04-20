using FinalChessProject;
using FinalChessProject.Figures;

namespace FinalyChessProject.Figures;

internal class Queen:Figs
{
    private char _color;
    public char Color
    {
        get { return _color; }
        set { _color = value; 
          switch (value)
            {
                case 'W':
                    _color = '\u2655';
                    break;
                case 'B':
                    _color = '\u265B';
                    break;
            }
        
        
        }
    }
    public char FigureImg
    {
        get { return _color; }
    }
    public Coordinate Coord { get; set; }
    public bool QueenMove(Coordinate firstCoordinate, Coordinate secondCoordinate)
    {
        int iDiff = MoveI(firstCoordinate, secondCoordinate);
        int jDiff = MoveJ(firstCoordinate, secondCoordinate);
        return iDiff == 0 || jDiff == 0 || iDiff == jDiff;
    }
    public Queen(char pieceColor)
    {
        Color = pieceColor;
    }
    public List<Coordinate> FilterValidMoves(Coordinate startCoord, List<Coordinate> coordinates)
    {
        List<Coordinate> validMoves = new List<Coordinate>();

        foreach (var destinationCoord in coordinates)
        {
            if (QueenMove(startCoord, destinationCoord))
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

