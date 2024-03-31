using FinalChessProject;
using FinalChessProject.Figures;
using FinalyChessProject.Figures;
using static System.Console;

namespace FinalyChessProject;

public class FirstGame: Figs
{
   Board board = new Board();
    public void StartGame(string[,] map)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        WriteLine("Enter Figure : K - king , B - bishop , Q - Queen , R - Rook , H -Knight");
        ConsoleKeyInfo pressedKey = ReadKey();
        WriteLine();
        bool userInput = true;
        while(userInput)
        {
            board.PrintMap(map);
            //WriteLine("Enter first Coordinate");
            //Coordinate firstCoord = new Coordinate(ReadLine().ToLower());
            //Write("Enter second Coordinate");
            //Coordinate secondCoord = new Coordinate(ReadLine().ToLower());
            switch (pressedKey.Key)
            {
                case ConsoleKey.K:
                    King king = new King('W');
                    WriteLine("Enter first Coordinate");
                    Coordinate firstCoord = new Coordinate(ReadLine().ToLower());
                    king.AddFigureToMap(map, firstCoord,king.FigureImg);
                    board.NewPrintMap(map);
                    Write("Enter second Coordinate");
                    Coordinate secondCoord = new Coordinate(ReadLine().ToLower());
                    if(king.KingMove(firstCoord,secondCoord))
                    {
                        king.AddFigureToMap(map,secondCoord,king.FigureImg);
                        userInput = false;
                        board.NewPrintMap(map);
                    }
                   break;
                case ConsoleKey.B:
                    Bishop bishop = new Bishop('W');
                    WriteLine("Enter first Coordinate");
                    Coordinate firstCoorda = new Coordinate(ReadLine().ToLower());
                    bishop.AddFigureToMap(map, firstCoorda, bishop.FigureImg);
                    board.NewPrintMap(map);
                    Write("Enter second Coordinate");
                    Coordinate secondCoorda = new Coordinate(ReadLine().ToLower());
                    if(bishop.BishopMove(firstCoorda,secondCoorda))
                    {
                      bishop.AddFigureToMap(map, secondCoorda, bishop.FigureImg);
                        userInput = false;
                        board.NewPrintMap(map);
                    }
                    break;
                case ConsoleKey.Q:
                    Queen queen = new Queen('W');
                    WriteLine("Enter first Coordinate");
                    Coordinate firstCoordq = new Coordinate(ReadLine().ToLower());
                    queen.AddFigureToMap(map, firstCoordq, queen.FigureImg);
                    board.NewPrintMap(map);
                    Write("Enter second Coordinate");
                    Coordinate secondCoordq = new Coordinate(ReadLine().ToLower());
                    if(queen.QueenMove(firstCoordq,secondCoordq))
                    {
                        queen.AddFigureToMap(map, secondCoordq, queen.FigureImg);
                        userInput = false;
                        board.NewPrintMap(map);
                    }
                    break;
                    case ConsoleKey.R:
                    Rook rook = new Rook('W');
                    WriteLine("Enter first Coordinate");
                    Coordinate firstCoordr = new Coordinate(ReadLine().ToLower());
                    rook.AddFigureToMap(map,firstCoordr,rook.FigureImg);
                    board.NewPrintMap(map);
                    Write("Enter second Coordinate");
                    Coordinate secondCoordr = new Coordinate(ReadLine().ToLower());
                    if(rook.RookMove(firstCoordr,secondCoordr))
                    {
                        rook.AddFigureToMap(map,secondCoordr,rook.FigureImg);
                        userInput = false;
                        board.NewPrintMap(map);
                    }
                    break;
                case ConsoleKey.H:
                    Knight knight = new Knight('W');
                    WriteLine("Enter first Coordinate");
                    Coordinate firstCoordh = new Coordinate(ReadLine().ToLower());
                    knight.AddFigureToMap(map,firstCoordh,knight.FigureImg);
                    board.NewPrintMap(map);
                    Write("Enter second Coordinate");
                    Coordinate secondCoordh = new Coordinate(ReadLine().ToLower());
                    if(knight.KnightMove(firstCoordh,secondCoordh))
                        {
                        knight.AddFigureToMap(map, secondCoordh, knight.FigureImg);
                        userInput = false;
                        board.NewPrintMap(map);
                        }
                    break;
            }

        }

    }
}
