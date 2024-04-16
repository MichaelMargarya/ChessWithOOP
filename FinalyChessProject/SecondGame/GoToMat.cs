using FinalChessProject.Figures;
using FinalyChessProject.Figures;

namespace FinalyChessProject.SecondGame
{
    internal class GoToMat
    {
        public Coordinate Queen { get; set; }
        public Coordinate FistRook { get; set; }
        public Coordinate SecondRook { get; set; }
        public Coordinate BlckKing { get; set; }
        public Coordinate WhiteKing { get; set; }
       

        public GoToMat(Coordinate Queen , Coordinate FistRook , Coordinate SecondRook , Coordinate WhiteKing,Coordinate BlackKing)
        {
            this.Queen = Queen;
            this.FistRook = FistRook;
            this.SecondRook = SecondRook;
            this.WhiteKing = WhiteKing;
            this.BlckKing = BlackKing;


            
        }
        public void Math(List<Coordinate> list)
        {
        
        }
        
       
            
                

    }
}
