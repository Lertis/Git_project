using System.Windows;
using System.Windows.Input;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for PlayersInfo.xaml
    /// </summary>
    public partial class PlayersInfo : Window
    {
        private MainWindow _mainWindow;

        public PlayersInfoViewModel ViewModel { get; set; }

        public PlayersInfo(MainWindow mainWindow)
        {
            InitializeComponent();

            this._mainWindow = mainWindow;

            ViewModel = new PlayersInfoViewModel()
            {
                FirstPlayerName = "Player 1",
                SecondPlayerName = "Player 2",
                FirstPlayerShipName = "Queen Anne`s Revenge",
                SecondPlayerShipName = "Queen Anne`s Revenge",
                MinimizeCommand = new Command(() => true, () => this.Minimize()),
                CloseCommand = new Command(() => true, () => this.BackToStartMenu()),
                StartPlayCommand = new Command(() => true, () => this.StartPlay())
            };

            this.DataContext = ViewModel;
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Minimize()
        {
            WindowState = WindowState.Minimized;
        }

        private void BackToStartMenu()
        {
            _mainWindow.StartMenu.Show();
            Hide();
        }

        private void StartPlay()
        {
            Hide();

            _mainWindow.StartNewGame();
        }

        private void ImageFirstUserSecondShip_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImageFirstUserSecondShip.Margin = new Thickness(2);

            ImageFirstUserFirstShip.Margin = new Thickness(7);
            ImageFirstUserThirdShip.Margin = new Thickness(7);

            TextBlockFirstPlayerShipName.Text = "Old Pearl";
        }

        private void ImageFirstUserFirstShip_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImageFirstUserFirstShip.Margin = new Thickness(2);

            ImageFirstUserSecondShip.Margin = new Thickness(7);
            ImageFirstUserThirdShip.Margin = new Thickness(7);

            TextBlockFirstPlayerShipName.Text = "Queen Anne`s Revenge";
        }

        private void ImageFirstUserThirdShip_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImageFirstUserThirdShip.Margin = new Thickness(2);

            ImageFirstUserFirstShip.Margin = new Thickness(7);
            ImageFirstUserSecondShip.Margin = new Thickness(7);

            TextBlockFirstPlayerShipName.Text = "Pirate Brig";
        }

        private void ImageSecondUserFirstShip_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImageSecondUserFirstShip.Margin = new Thickness(2);

            ImageSecondUserSecondShip.Margin = new Thickness(7);
            ImageSecondUserThirdShip.Margin = new Thickness(7);

            TextBlockSecondPlayerShipName.Text = "Queen Anne`s Revenge";
        }

        private void ImageSecondUserSecondShip_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImageSecondUserSecondShip.Margin = new Thickness(2);

            ImageSecondUserFirstShip.Margin = new Thickness(7);
            ImageSecondUserThirdShip.Margin = new Thickness(7);

            TextBlockSecondPlayerShipName.Text = "Old Pearl";
        }

        private void ImageSecondUserThirdShip_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ImageSecondUserThirdShip.Margin = new Thickness(2);

            ImageSecondUserFirstShip.Margin = new Thickness(7);
            ImageSecondUserSecondShip.Margin = new Thickness(7);

            TextBlockSecondPlayerShipName.Text = "Pirate Brig";
        }
    }
}
