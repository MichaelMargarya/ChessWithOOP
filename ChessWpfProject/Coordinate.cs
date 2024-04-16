using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChessWpfProject
{
    public struct Coordinate
    {
        public int i;
        public int j;

        public Coordinate(string mesage)
        {

            this.i = mesage[0] - 'a';
            this.j = mesage[1] - 49;


        }

    }
}
