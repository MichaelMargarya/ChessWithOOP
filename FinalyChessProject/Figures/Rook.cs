using FinalChessProject.Figures;

namespace FinalyChessProject.Figures;

internal class Rook:Figs
{
    private char _color;
    public char Color
    {
        get { return _color; }
        set
        {
            _color = value;
            switch (value)
            {
                case 'W':
                    _color = '\u2656';
                    break;
                case 'B':
                    _color = '\u265C';
                    break;
            }
        }
    }
    public char FigureImg
    {
        get { return _color;}
    }
    public Coordinate Coord { get; set; }

    public bool RookMove(Coordinate firstCoordinate , Coordinate secondCoordinate)
    {
        int iDiff = MoveI(firstCoordinate, secondCoordinate);
        int jDiff = MoveJ(firstCoordinate, secondCoordinate);
        return iDiff == 0 || jDiff == 0;
    }
    public Rook(char pieceColor)
    {
        Color = pieceColor;
    }
}
