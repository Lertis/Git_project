using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using Pirates_Bay.GameLogic;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for LoadGameMenu.xaml
    /// </summary>
    public partial class LoadGameMenu : Window
    {
        public LoadGameMenuViewModel ViewModel { get; set; }

        private MainWindow _parentWindow;

        private FileInfo[] _savesFileInfos;

        private List<SaveDescription> _savesDescriptions;

        public LoadGameMenu(MainWindow parentWindow)
        {
            _parentWindow = parentWindow;

            InitializeComponent();

            ViewModel = new LoadGameMenuViewModel()
            {
                CloseCommand = new Command(() => true, () =>
                {
                    this.Hide();
                    _parentWindow.StartMenu.Show();
                }),
                MinimizeCommand = new Command(() => true, () => this.WindowState = WindowState.Minimized),
                LoadCommand =  new Command(()=>true, this.LoadSave)
            };

            this.DataContext = ViewModel;
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void LoadGameMenu_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                var directory = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory + @"\Saves");

                _savesFileInfos = directory.GetFiles("*.pbs", SearchOption.AllDirectories);

                _savesDescriptions = new List<SaveDescription>();
                var formatter = new BinaryFormatter();

                foreach (var savesFileInfo in _savesFileInfos)
                {
                    using (
                        Stream stream = new FileStream(savesFileInfo.FullName, FileMode.Open, FileAccess.Read,
                            FileShare.None))
                    {
                        _savesDescriptions.Add((SaveDescription) formatter.Deserialize(stream));
                    }

                }

                DataGridSaves.ItemsSource = _savesDescriptions;
            }
        }

        private void LoadSave()
        {
            if (DataGridSaves.SelectedIndex >= 0)
            {
                GameCaretaker loader = new GameCaretaker();

                loader.LoadGame(_savesFileInfos[DataGridSaves.SelectedIndex].FullName);

                this.Hide();

                _parentWindow.StartLoadedGame(loader.GetMemento());
            }
        }

        private void DataGridSaves_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (DataGridSaves.SelectedIndex >= 0 && e.Key == Key.Delete)
            {
                _savesFileInfos[DataGridSaves.SelectedIndex].Delete();

                _savesDescriptions.RemoveAt(DataGridSaves.SelectedIndex);

                DataGridSaves.ItemsSource = _savesDescriptions;

                DataGridSaves.UpdateLayout();
            }
        }
    }
}
