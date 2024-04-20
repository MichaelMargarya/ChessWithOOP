using System;
using System.Collections;
using System.Collections.Generic;

namespace FinalChessProject.Figures
{
    public struct Coordinate 
    {
        public int i;
        public int j;

        private List<Coordinate> Coordinates;

        public bool IsReadOnly => false;

        public int Count => Coordinates.Count;

        public Coordinate(string coord)
        {
            char colChar = coord[0];
            int.TryParse(coord[1].ToString(), out int row);
            i = colChar - 'a';
            j = row - 1;
            Coordinates = new List<Coordinate>();
        }

       
        public Coordinate(int i ,int j)
        {
            this.i = (char)i+ 97;
            this.j = (char)j + 48;
        }
    }
}
