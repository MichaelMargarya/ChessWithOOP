using FinalChessProject.Figures;

namespace FinalyChessProject.Figures
{
    public class King : Figs
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
                        _color = '\u2654';
                        break;
                    case 'B':
                        _color = '\u265A';
                        break;
                }
            }
        }
 
        public char FigureImg
        {
            get { return _color; }
        }
        public Coordinate Coord { get; set; }

        public bool KingMove(Coordinate firstCoordinate, Coordinate secondCoordinate)
        {
            int iDiff = MoveI(firstCoordinate, secondCoordinate);
            int jDiff = MoveJ(firstCoordinate, secondCoordinate);
            return iDiff <= 1 && jDiff <= 1;
        }
        public King(char pieceColor)
        {
            Color = pieceColor;
        }
    }
}
