namespace FinalyChessProject;

using FinalChessProject;
using System.Threading.Channels;
using static System.Console;
public class StartGame
{
    public void Start()
    {
        string[,] map = new string[8,8];
        WriteLine("Enter Game Mode:F-first game , S - second game");
        ConsoleKeyInfo userpreesed = Console.ReadKey();
        WriteLine();
        switch (userpreesed.Key)
        {
            case ConsoleKey.F:
                FirstGame firstGame = new FirstGame();
                firstGame.StartGame(map);
                break;
                case ConsoleKey.S:
                SecondMode game = new SecondMode();
                game.StartG(map);
          break;
            default:
                Start();
                break;
        }
    }
}
