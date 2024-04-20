using FinalChessProject;
using FinalChessProject.Figures;
using FinalyChessProject;
using FinalyChessProject.Figures;
using FinalyChessProject.SecondGame;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;
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
    Board board = new Board();

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
        bool Okay = true;
        //while (Okay)
        //{
              WriteLine("Enter white King Coordinate ");
              whiteKing.Coord = new Coordinate(ReadLine().ToLower());
            //if (valid.ValidCoord(whiteKing.Coord, blackQueen.Coord, firstRook.Coord, secondRook.Coord, blackKing.Coord))
            //{
                List<Coordinate> coord = [firstRook.Coord, secondRook.Coord, blackQueen.Coord, blackKing.Coord, whiteKing.Coord];
                King wKing = new King('W');
                Mate mate = new Mate();
        whiteKing.AddFigureToMap(board, whiteKing.Coord, whiteKing.FigureImg);
                map.NewPrintMap(board);
                if (valid.EqualCoordinates(coord) && valid.IsTheKingUnderAttack(coord)
                    && !valid.IsStalemate(coord[4], coord[2], coord[0], coord[1], coord[3]))
                {

                    mate.Mat(coord, coord[0], coord[1], coord[2], coord[3], coord[4]);
                }
               // Okay = false;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid King Cordinate Input!");
            //}

       //W }


       
    }
}

