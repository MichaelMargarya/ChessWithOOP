using Classic.SecondGameMode;
using FinalChessProject;
using FinalChessProject.Figures;
using FinalyChessProject;
using FinalyChessProject.Figures;
using static System.Console;
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
        WriteLine("Enter Coordinate Fist Black Rook");
        map.NewPrintMap(board);
        firstRook.Coord = new Coordinate(ReadLine().ToLower());
        firstRook.AddFigureToMap(board, firstRook.Coord, firstRook.FigureImg);
        map.NewPrintMap(board);
        WriteLine("Enter Coordinate second black Rook");
        secondRook.Coord = new Coordinate(ReadLine().ToLower());
        secondRook.AddFigureToMap(board, secondRook.Coord, secondRook.FigureImg);
        //WriteLine("Enter WHITE KING coordinate");
        //whiteKing.Coord = new Coordinate(ReadLine().ToLower());
        //if (valid.ValidCoord(whiteKing.Coord,blackQueen.Coord , firstRook.Coord,secondRook.Coord))
        //{
        //    whiteKing.AddFigureToMap(board,whiteKing.Coord,whiteKing.FigureImg);

        //}
        bool isDone = true;
        while (isDone)
        {
            System.Console.WriteLine("Enter white King Coordinate");
            
            Coordinate whiteKingCoordinate = new Coordinate(ReadLine().ToLower());

         
            if (!valid.IsStalemate(whiteKingCoordinate, blackQueen.Coord, firstRook.Coord, secondRook.Coord))
            {
                whiteKing.AddFigureToMap(board,whiteKingCoordinate,whiteKing.FigureImg);
                continue;
            }

            
            if (valid.IsCheck(whiteKingCoordinate, blackQueen.Coord, firstRook.Coord, secondRook.Coord))
            {
                System.Console.WriteLine("Invalid input, king is in check!");
                continue;
            }

            System.Console.WriteLine("Enter Destination Coordinate!");
            string destinationInput = System.Console.ReadLine().ToLower();
            Coordinate destinationCoordinate = new Coordinate(destinationInput);

            
            //if (KingCanMove(whiteKingCoordinate, destinationCoordinate))
            //{
            //    whiteKing.AddFigureToMap(board, destinationCoordinate, '♔');
            //    map.NewPrintMap(board);
            //}
            if(whiteKing.KingMove(whiteKing.Coord , destinationCoordinate))
            {
                whiteKing.AddFigureToMap(board, destinationCoordinate, whiteKing.FigureImg);
                map.NewPrintMap(board);
            }
            else
            {
                WriteLine("Invalid move!");
            }
        }
    }

 
}
