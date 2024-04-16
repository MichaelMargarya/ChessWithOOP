using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessWpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int SquareSize = 50;
        private King king = new King();
        private Queen queen = new Queen();
        private Bishop bishop = new Bishop();
        private Rook rook = new Rook();
        private Knight knight = new Knight();
        private Pawn pawn = new Pawn();
        private bool isInitialMove;
        private Point _previousClickPosition;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string validCord = Cordinate.Text.ToLower();
            if (Cordinate.Text.Length > 2)
            {
                Cordinate.Text = "Invalid Coordinate!";
            }
            else if (validCord[0] <= 'h' && validCord[0] >= 'a')
                 {
                if (validCord[1] >= '0' && validCord[1] <= '8')
                {
                    Coordinate cord = new Coordinate(validCord);
                    string selectedColor = (Color.SelectedItem as ComboBoxItem)?.Content.ToString();
                    string selectedFigure = (Figures.SelectedItem as ComboBoxItem)?.Content.ToString();

                    if(!string.IsNullOrEmpty(selectedColor) && !string.IsNullOrEmpty(selectedFigure))
                    {
                        string imgPath = $"/img/{selectedFigure}{selectedColor.Substring(0,1).ToUpper()}.png";
                        Image figureImage = new Image();

                    }
                }

                 }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {

        }
    }
}