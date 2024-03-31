using FinalChessProject.Figures;

namespace FinalyChessProject
{
    public abstract class Figs
    {
        public int MoveI(Coordinate firstCordinate, Coordinate secondCordinate)
        {
            int i1 = firstCordinate.j;
            int i2 = secondCordinate.j;
            int iDifference = Math.Abs(i1 - i2);
            return iDifference;
        }
        public int MoveJ(Coordinate firstCordinate, Coordinate secondCordinate)
        {
            char j1 = (char)firstCordinate.i;
            char j2 = (char)secondCordinate.i;
            int jDifference = Math.Abs(j1 - j2);
            return jDifference;
        }
        public void AddFigureToMap(string[,] Board, Coordinate coord, char figure1)
        {
            int i = coord.j;
            int j = coord.i;
            string figure = Convert.ToString(figure1);
            Board[i, j] = figure;
        }

    }
}
