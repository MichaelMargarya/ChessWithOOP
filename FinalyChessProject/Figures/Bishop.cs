using FinalChessProject.Figures;

namespace FinalyChessProject.Figures
{
    public class Bishop : Figs
    {
        private char color;

        public char Color
        {
            get { return color; }
            set
            {
                color = value;
                switch (value)
                {
                    case 'W':
                        color = '\u2657';
                        break;
                    case 'B':
                        color = '\u265D';
                        break;
                }
            }
        }

        public char FigureImg
        {
            get { return color; }
        }
        public Coordinate Coord { get; set; }

        public bool BishopMove(Coordinate firstCoordinate, Coordinate secondCoordinate)
        {
            int iDiff = MoveI(firstCoordinate, secondCoordinate);
            int jDiff = MoveJ(firstCoordinate, secondCoordinate);
            return iDiff == jDiff;
        }

        public Bishop(char pieceColor)
        {
            Color = pieceColor;
        }
    }
}
