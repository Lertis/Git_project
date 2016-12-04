using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Pirates_Bay.GameLogic;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for SaveGameDialodWindow.xaml
    /// </summary>
    ///
    public partial class SaveGameDialodWindow : Window
    {
        public SaveGameDialogWindowViewModel ViewModel { get; set; }

        private MainWindow _parentWindow;

        public SaveGameDialodWindow(MainWindow parent)
        {
            InitializeComponent();

            _parentWindow = parent;

            ViewModel = new SaveGameDialogWindowViewModel()
            {
                CloseCommand = new Command(() => true, () => this.Hide()),
                MinimizeCommand = new Command(() => true, () => this.WindowState = WindowState.Minimized),
                ExitCommand = new Command(()=>true, () =>
                {
                    if (_parentWindow.NewGameBegining)
                    {
                        this.Hide();
                        _parentWindow.Hide();
                        _parentWindow.PlayersInfoMenu.Show();
                    }
                    else
                    {
                        this.Hide();
                        _parentWindow.Close();
                    }
                }), SaveCommand = new Command(()=>true, () =>
                {
                    if (_parentWindow.NewGameBegining)
                    {
                        this.Hide();
                        SaveGame();
                        _parentWindow.Hide();
                        _parentWindow.PlayersInfoMenu.Show();
                    }
                    else
                    {
                        this.Hide();
                        SaveGame();
                        _parentWindow.Close();
                    }
                })
            };

            this.DataContext = ViewModel;
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void SaveGame()
        {
            GameCaretaker caretaker = new GameCaretaker(_parentWindow.GenerateGameMemento());

            caretaker.SaveGame();
        }
    }
}
