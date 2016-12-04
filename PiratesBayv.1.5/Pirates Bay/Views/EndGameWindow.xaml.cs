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
using Pirates_Bay.CreationalPatterns;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for EndGameWindow.xaml
    /// </summary>
    public partial class EndGameWindow : Window
    {
        public VictoryViewModel ViewModel { get; set; }

        public EndGameWindow( MainWindow parentWindow)
        {
            InitializeComponent();
            ViewModel = new VictoryViewModel()
            {
                MinimizeCommand = new Command(() => true, () => this.WindowState = WindowState.Minimized),
                CloseCommand = new Command(() => true, () =>
                {
                    SoundsGenerator.Instance.StopVictorySound();

                    this.Hide();
                    parentWindow.Hide();
                    parentWindow.StartMenu.Show();
                })
            };

            this.DataContext = ViewModel;
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
