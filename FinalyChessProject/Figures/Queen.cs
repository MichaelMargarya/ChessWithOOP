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
}
