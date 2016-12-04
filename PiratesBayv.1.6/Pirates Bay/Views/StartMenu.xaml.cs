using System;
using System.Windows;
using System.Windows.Input;
using Pirates_Bay.CreationalPatterns;
using Pirates_Bay.GameLogic;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Window
    {
        private MainWindow _parentWindow;

        public StartMenuViewModel ViewModel { get; set; }

        public StartMenu(MainWindow mainWindow)
        {
            InitializeComponent();

            _parentWindow = mainWindow;

            ViewModel = new StartMenuViewModel()
            {
                MinimizeCommand = new Command(() => true, () => this.Minimize()),
                CloseCommand = new Command(() => true, () => this.Close()),
                StartNewGameCommand = new Command(() => true, () => this.StartNewGame()),
                LoadStatisticsCommand = new Command(() => true, () => this.LoadStatistics()),
                LoadGameCommand = new Command(() => true, () => this.LoadGame()),
                ChangeOptionsCommand = new Command(() => true, () => this.ShowOptions()) 
            };

            this.DataContext = ViewModel;
            
        }


        private void StartMenu_OnClosed(object sender, EventArgs e)
        {
            _parentWindow.Close();
        }

        private void LoadStatistics()
        {
            
        }

        private void ShowOptions()
        {
            _parentWindow.OptionsMenu.ShowDialog();
        }

        private void LoadGame()
        {
            this.Hide();
            _parentWindow.LoadGameMenu.Show();
        }
        private void StartNewGame()
        {
            Hide();
            _parentWindow.PlayersInfoMenu.Show();
        }

        public void Minimize()
        {
            WindowState = WindowState.Minimized;
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }

}
