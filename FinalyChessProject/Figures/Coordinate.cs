using System;
using System.Collections;
using System.Collections.Generic;

namespace FinalChessProject.Figures
{
    public struct Coordinate : ICollection<Coordinate> // , IEnumerable<Coordinate>
    {
        public int i;
        public int j;

        private List<Coordinate> Coordinates;

        public bool IsReadOnly => false;

        public int Count => Coordinates.Count;

        public Coordinate(string coord)
        {
            char colChar = coord[0];
            int.TryParse(coord[1].ToString(), out j);
            i = colChar - 'a';
            j = j - 1;
            Coordinates = new List<Coordinate>();
        }

        public void Add(Coordinate item)
        {
            Coordinates.Add(item);
        }

        public void Clear()
        {
            Coordinates.Clear();
        }

       

       

        public IEnumerator<Coordinate> GetEnumerator()
        {
            return Coordinates.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Coordinates.GetEnumerator();
        }

        public bool Contains(Coordinate item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Coordinate[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Coordinate item)
        {
            throw new NotImplementedException();
        }

        //  operators
        public static bool operator ==(Coordinate a, Coordinate b)
        {
            return a.i == b.i && a.j == b.j;
        }

        public static bool operator !=(Coordinate a, Coordinate b)
        {
            return !(a == b);
        }
     

    }
}
