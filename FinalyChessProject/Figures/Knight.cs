using FinalChessProject.Figures;

namespace FinalyChessProject.Figures;

internal class Knight:Figs
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
                    _color = '\u265E';
                    break;
                case 'B':
                    _color = '\u2658';
                    break;
            }

        }
    }
    public char FigureImg
    {
        get {return _color; }
    }
    public Coordinate Coord { get; set; }
    public bool KnightMove(Coordinate firstCoordinate , Coordinate secondCoordinate)
    {
        int iDiff = MoveI(firstCoordinate, secondCoordinate);
        int jDiff = MoveJ(firstCoordinate, secondCoordinate);
        return (iDiff == 2 && jDiff == 1) || (iDiff == 1 && jDiff == 2);
    }
    public Knight(char pieceColor)
    {
        Color = pieceColor;
    }

}
