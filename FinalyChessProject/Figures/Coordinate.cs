using System;
using System.Numerics;

namespace FinalChessProject.Figures
{
    public struct Coordinate
    {
        public int i;
        public int j;

        public Coordinate(string coord)
        {
            char colChar = coord[0];
            int.TryParse(coord[1].ToString(), out j);
            i = colChar - 'a';
            j = j - 1;
        }
        public static bool operator ==(Coordinate a , Coordinate b)
        {
             if(a.i == b.i && a.j == b.j)
            {
                return true;
            }
             return false;
        }
        public static bool operator !=(Coordinate a , Coordinate b)
        {
            if(a == b)
            {
               return false;
            }
            return true;
        }
    }
}
