using FinalChessProject;
using FinalChessProject.Figures;
using FinalyChessProject;
using FinalyChessProject.Figures;
using static System.Console;
namespace FinalChessProject;
public class SecondMode : Figs
{
    King whiteKing = new King('W');
    Queen blackQueen = new Queen('B');
    King blackKing = new King('B');
    Rook firstRook = new Rook('B');
    Rook secondRook = new Rook('B');
    Validation valid = new Validation();

    public void StartG(string[,] board)
    {
        board = new string[8, 8];
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Board map = new Board();
        map.PrintMap(board);
        WriteLine("Enter Coordinate black king");
        blackKing.Coord = new Coordinate(ReadLine().ToLower());
        blackKing.AddFigureToMap(board, blackKing.Coord, blackKing.FigureImg);
        map.NewPrintMap(board);
        WriteLine("Enter Coordinate Black Queen");
        blackQueen.Coord = new Coordinate(ReadLine().ToLower());
        blackQueen.AddFigureToMap(board, blackQueen.Coord, blackQueen.FigureImg);
        map.NewPrintMap(board);
        WriteLine("Enter Coordinate Fist Black Rook");
        firstRook.Coord = new Coordinate(ReadLine().ToLower());
        firstRook.AddFigureToMap(board, firstRook.Coord, firstRook.FigureImg);
        map.NewPrintMap(board);
        WriteLine("Enter Coordinate second black Rook");
        secondRook.Coord = new Coordinate(ReadLine().ToLower());
        secondRook.AddFigureToMap(board, secondRook.Coord, secondRook.FigureImg);
        map.NewPrintMap(board);
        //WriteLine("Enter WHITE KING coordinate");
        //whiteKing.Coord = new Coordinate(ReadLine().ToLower());
        //if (valid.ValidCoord(whiteKing.Coord,blackQueen.Coord , firstRook.Coord,secondRook.Coord))
        //{
        //    whiteKing.AddFigureToMap(board,whiteKing.Coord,whiteKing.FigureImg);

        //}
        bool isDone = true;
        WriteLine("Enter white King Coordinate");
        Coordinate whiteKingCoordinate = new Coordinate(ReadLine().ToLower());
        while (isDone)
        {

            if (valid.IsStalemate(whiteKingCoordinate, blackQueen.Coord, firstRook.Coord, secondRook.Coord))
            {
                WriteLine("Invalid input, enter new coordinate for White King!");
                whiteKingCoordinate = new Coordinate(Console.ReadLine().ToLower());

            }
            else if(valid.IsCheck(whiteKingCoordinate, blackQueen.Coord, firstRook.Coord, secondRook.Coord))
            {
                WriteLine("Invalid input, enter new coordinate for White King!");
                whiteKingCoordinate = new Coordinate(Console.ReadLine().ToLower());
            }
            else
            {
                whiteKing.AddFigureToMap(board, whiteKingCoordinate, whiteKing.FigureImg);
                map.NewPrintMap(board);
            }
     
           

            WriteLine("Enter Destination Coordinate!");
            Coordinate destinationInput = new Coordinate(Console.ReadLine().ToLower());
       
            
            //if (KingCanMove(whiteKingCoordinate, destinationCoordinate))
            //{
            //    whiteKing.AddFigureToMap(board, destinationCoordinate, '♔');
            //    map.NewPrintMap(board);
            //}
            if(whiteKing.KingMove(whiteKing.Coord , destinationInput))
            {
                whiteKing.AddFigureToMap(board, destinationInput, whiteKing.FigureImg);
                map.NewPrintMap(board);
            }
            else
            {
                WriteLine("Invalid move!");
            }
        }
   
        
    }

 
}
