using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Pirates_Bay.CreationalPatterns;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for OptionsMenu.xaml
    /// </summary>
    public partial class OptionsMenu : Window
    {
        private OptionsMenuViewModel _viewModel;

        private String _currentStyle;

        private MainWindow _parentWindow;

        public OptionsMenu( MainWindow parent)
        {
            InitializeComponent();

            _parentWindow = parent;

            _viewModel = new OptionsMenuViewModel()
            {
                CloseCommand = new Command(() => true, () => this.Hide()),
                MinimizeCommand = new Command(() => true, () => this.WindowState = WindowState.Minimized),
                VolumeLevel = 0.5
            };

            this.DataContext = _viewModel;

            _currentStyle = "Dark";
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ListBoxStyles_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem) (((ListBox) sender).SelectedItem);
            if (!string.Equals(selectedItem.Content.ToString(), _currentStyle))
            {
                _currentStyle = selectedItem.Content.ToString();

                IGUIComponentsFactory styleFactory;
                switch (_currentStyle)
                {
                    case "Light":
                    {
                        styleFactory = new LightStyleFactory();
                        break;
                    }
                    case "Blue":
                    {
                        styleFactory = new BlueStyleFactory();
                        break;
                    }
                    default:
                    {
                        styleFactory = new DarkStyleFactory();
                        break;
                    }
                }

                #region OptionsMenu style
                this.Background = styleFactory.GetConteinerBackground();
                this.TitleBar.Background = styleFactory.GetTittleBarBackground();

                this.GridContainer.Children.Remove(this.TextBlockInterfaceStyle);
                this.TextBlockInterfaceStyle = styleFactory.GetDescriptionTextBlock("Interface style");
                this.GridContainer.Children.Add(this.TextBlockInterfaceStyle);
                this.TextBlockInterfaceStyle.SetValue(Grid.ColumnProperty, 1);
                this.TextBlockInterfaceStyle.SetValue(Grid.RowProperty, 1);

                this.GridContainer.Children.Remove(this.TextBlockVolume);
                this.TextBlockVolume = styleFactory.GetDescriptionTextBlock("Volume");
                this.GridContainer.Children.Add(this.TextBlockVolume);
                this.TextBlockVolume.SetValue(Grid.ColumnProperty, 1);
                this.TextBlockVolume.SetValue(Grid.RowProperty, 3);

                #endregion

                #region StartMenu style

                _parentWindow.StartMenu.Background = styleFactory.GetStartMenuBackground();

                _parentWindow.StartMenu.TitleBar.Background = styleFactory.GetTittleBarBackground();

                _parentWindow.StartMenu.ButtonStartNewGame = styleFactory.GetMenuButton("Start new game",
                    _parentWindow.StartMenu.ViewModel.StartNewGameCommand);
                _parentWindow.StartMenu.GridMenu.Children.Add(_parentWindow.StartMenu.ButtonStartNewGame);
                _parentWindow.StartMenu.ButtonStartNewGame.SetValue(Grid.RowProperty, 1);
                _parentWindow.StartMenu.ButtonStartNewGame.SetValue(Grid.ColumnProperty, 1);

                _parentWindow.StartMenu.ButtonLoadGame = styleFactory.GetMenuButton("Load game",
                    _parentWindow.StartMenu.ViewModel.LoadGameCommand);
                _parentWindow.StartMenu.GridMenu.Children.Add(_parentWindow.StartMenu.ButtonLoadGame);
                _parentWindow.StartMenu.ButtonLoadGame.SetValue(Grid.RowProperty, 3);
                _parentWindow.StartMenu.ButtonLoadGame.SetValue(Grid.ColumnProperty, 1);

                _parentWindow.StartMenu.ButtonStatistics = styleFactory.GetMenuButton("Statistics",
                    _parentWindow.StartMenu.ViewModel.LoadStatisticsCommand);
                _parentWindow.StartMenu.GridMenu.Children.Add(_parentWindow.StartMenu.ButtonStatistics);
                _parentWindow.StartMenu.ButtonStatistics.SetValue(Grid.RowProperty, 5);
                _parentWindow.StartMenu.ButtonStatistics.SetValue(Grid.ColumnProperty, 1);

                _parentWindow.StartMenu.ButtonOptions = styleFactory.GetMenuButton("Options",
                    _parentWindow.StartMenu.ViewModel.ChangeOptionsCommand);
                _parentWindow.StartMenu.GridMenu.Children.Add(_parentWindow.StartMenu.ButtonOptions);
                _parentWindow.StartMenu.ButtonOptions.SetValue(Grid.RowProperty, 7);
                _parentWindow.StartMenu.ButtonOptions.SetValue(Grid.ColumnProperty, 1);

                _parentWindow.StartMenu.ButtonExit = styleFactory.GetMenuButton("Exit",
                    _parentWindow.StartMenu.ViewModel.CloseCommand);
                _parentWindow.StartMenu.GridMenu.Children.Add(_parentWindow.StartMenu.ButtonExit);
                _parentWindow.StartMenu.ButtonExit.SetValue(Grid.RowProperty, 9);
                _parentWindow.StartMenu.ButtonExit.SetValue(Grid.ColumnProperty, 1);
                #endregion 

                #region LoadGameMenu style

                _parentWindow.LoadGameMenu.Background = styleFactory.GetLoadGameMenuBackground();

                _parentWindow.LoadGameMenu.TitleBar.Background = styleFactory.GetTittleBarBackground();

                _parentWindow.LoadGameMenu.GridSaves.Background = styleFactory.GetConteinerBackground();

                _parentWindow.LoadGameMenu.ButtonLoadGame = styleFactory.GetMenuButton("Load",
                    _parentWindow.LoadGameMenu.ViewModel.LoadCommand);
                _parentWindow.LoadGameMenu.GridMenu.Children.Add(_parentWindow.LoadGameMenu.ButtonLoadGame);
                _parentWindow.LoadGameMenu.ButtonLoadGame.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.LoadGameMenu.ButtonLoadGame.SetValue(Grid.RowProperty, 3);

                _parentWindow.LoadGameMenu.ButtonCancel = styleFactory.GetMenuButton("Cancel",
                    _parentWindow.LoadGameMenu.ViewModel.CloseCommand);
                _parentWindow.LoadGameMenu.GridMenu.Children.Add(_parentWindow.LoadGameMenu.ButtonCancel);
                _parentWindow.LoadGameMenu.ButtonCancel.SetValue(Grid.ColumnProperty, 4);
                _parentWindow.LoadGameMenu.ButtonCancel.SetValue(Grid.RowProperty, 3);
                #endregion

                #region PlayersInfoMenu style

                _parentWindow.PlayersInfoMenu.Background = styleFactory.GetPlayersInfoMenuBackground();

                _parentWindow.PlayersInfoMenu.TitleBar.Background = styleFactory.GetTittleBarBackground();

                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Remove(_parentWindow.PlayersInfoMenu.TextBlockFirstPlayerCaption);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerCaption =
                    styleFactory.GetDescriptionTextBlock("First player");
                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerCaption);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerCaption.SetValue(Grid.RowProperty, 0);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerCaption.SetValue(Grid.ColumnProperty, 0);

                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Remove(_parentWindow.PlayersInfoMenu.TextBlockSecondPlayerCaption);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerCaption =
                    styleFactory.GetDescriptionTextBlock("Second player");
                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerCaption);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerCaption.SetValue(Grid.RowProperty, 0);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerCaption.SetValue(Grid.ColumnProperty, 1);

                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName);
                BindingOperations.ClearBinding(_parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName, TextBlock.TextProperty);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName.ClearValue(TextBlock.TextProperty);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName = styleFactory.GetFilledTextBlock();              
                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName.SetValue(Grid.ColumnProperty, 0);
                Binding textBlockFirstPlayerBinding = new Binding("FirstPlayerShipName") {Mode = BindingMode.TwoWay};
                BindingOperations.SetBinding(_parentWindow.PlayersInfoMenu.TextBlockFirstPlayerShipName,
                    TextBlock.TextProperty, textBlockFirstPlayerBinding);

                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName);
                BindingOperations.ClearBinding(_parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName, TextBlock.TextProperty);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName.ClearValue(TextBlock.TextProperty);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridDataContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName.SetValue(Grid.ColumnProperty, 1);
                Binding textBlockSecondPlayerBinding = new Binding("SecondPlayerShipName") { Mode = BindingMode.TwoWay };
                BindingOperations.SetBinding(_parentWindow.PlayersInfoMenu.TextBlockSecondPlayerShipName,
                    TextBlock.TextProperty, textBlockSecondPlayerBinding);

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Background =
                    styleFactory.GetConteinerBackground();

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Background =
                    styleFactory.GetConteinerBackground();

                #region Ships characteristics TextBlocks

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipHealth);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipHealth = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipHealth);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipHealth.SetValue(Grid.RowProperty, 1);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipHealth.SetValue(Grid.ColumnProperty, 0);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipHealth.Text = "Health: 2400";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipSpeed);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipSpeed = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipSpeed);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipSpeed.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipSpeed.SetValue(Grid.ColumnProperty, 0);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipSpeed.Text = "Speed: 60";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipDamage);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipDamage = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipDamage);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipDamage.SetValue(Grid.RowProperty, 3);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipDamage.SetValue(Grid.ColumnProperty, 0);
                _parentWindow.PlayersInfoMenu.FirstPlayerFirstShipDamage.Text = "Damage: 250";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipHealth);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipHealth = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipHealth);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipHealth.SetValue(Grid.RowProperty, 1);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipHealth.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipHealth.Text = "Health: 2000";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipSpeed);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipSpeed = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipSpeed);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipSpeed.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipSpeed.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipSpeed.Text = "Speed: 60";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipDamage);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipDamage = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipDamage);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipDamage.SetValue(Grid.RowProperty, 3);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipDamage.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.PlayersInfoMenu.FirstPlayerSecondShipDamage.Text = "Damage: 300";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipHealth);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipHealth = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipHealth);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipHealth.SetValue(Grid.RowProperty, 1);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipHealth.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipHealth.Text = "Health: 1900";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipSpeed);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipSpeed = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipSpeed);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipSpeed.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipSpeed.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipSpeed.Text = "Speed: 90";

                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipDamage);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipDamage = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridFirstPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipDamage);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipDamage.SetValue(Grid.RowProperty, 3);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipDamage.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.PlayersInfoMenu.FirstPlayerThirdShipDamage.Text = "Damage: 270";


                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipHealth);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipHealth = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipHealth);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipHealth.SetValue(Grid.RowProperty, 1);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipHealth.SetValue(Grid.ColumnProperty, 0);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipHealth.Text = "Health: 2400";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipSpeed);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipSpeed = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipSpeed);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipSpeed.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipSpeed.SetValue(Grid.ColumnProperty, 0);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipSpeed.Text = "Speed: 60";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipDamage);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipDamage = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipDamage);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipDamage.SetValue(Grid.RowProperty, 3);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipDamage.SetValue(Grid.ColumnProperty, 0);
                _parentWindow.PlayersInfoMenu.SecondPlayerFirstShipDamage.Text = "Damage: 250";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipHealth);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipHealth = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipHealth);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipHealth.SetValue(Grid.RowProperty, 1);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipHealth.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipHealth.Text = "Health: 2000";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipSpeed);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipSpeed = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipSpeed);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipSpeed.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipSpeed.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipSpeed.Text = "Speed: 60";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipDamage);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipDamage = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipDamage);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipDamage.SetValue(Grid.RowProperty, 3);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipDamage.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.PlayersInfoMenu.SecondPlayerSecondShipDamage.Text = "Damage: 300";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipHealth);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipHealth = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipHealth);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipHealth.SetValue(Grid.RowProperty, 1);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipHealth.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipHealth.Text = "Health: 1900";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipSpeed);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipSpeed = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipSpeed);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipSpeed.SetValue(Grid.RowProperty, 2);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipSpeed.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipSpeed.Text = "Speed: 90";

                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Remove(
                    _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipDamage);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipDamage = styleFactory.GetFilledTextBlock();
                _parentWindow.PlayersInfoMenu.GridSecondPlayerShipsContainer.Children.Add(
                    _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipDamage);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipDamage.SetValue(Grid.RowProperty, 3);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipDamage.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.PlayersInfoMenu.SecondPlayerThirdShipDamage.Text = "Damage: 270";

                #endregion

                _parentWindow.PlayersInfoMenu.ButtonPlay = styleFactory.GetMenuButton("Play",
                    _parentWindow.PlayersInfoMenu.ViewModel.StartPlayCommand);
                _parentWindow.PlayersInfoMenu.GridButtonContainer.Children.Add(_parentWindow.PlayersInfoMenu.ButtonPlay);
                _parentWindow.PlayersInfoMenu.ButtonPlay.SetValue(Grid.ColumnProperty, 1);

                #endregion

                #region MainWindow style

                _parentWindow.GridOuterContainer.Background = styleFactory.GetConteinerBackground();

                _parentWindow.GridTitleBar.Background = styleFactory.GetTittleBarBackground();

                _parentWindow.ButtonNewGame = styleFactory.GetMenuButton("New game",
                   _parentWindow.ViewModel.StartNewGameCommand);
                _parentWindow.GridOptions.Children.Add(_parentWindow.ButtonNewGame);
                _parentWindow.ButtonNewGame.SetValue(Grid.RowProperty, 4);
                _parentWindow.ButtonNewGame.SetValue(Grid.ColumnProperty, 3);
                _parentWindow.ButtonNewGame.SetValue(Grid.ColumnSpanProperty, 2);

                _parentWindow.ButtonOptions = styleFactory.GetMenuButton("Options",
                   _parentWindow.ViewModel.ShowOptionsCommand);
                _parentWindow.GridOptions.Children.Add(_parentWindow.ButtonOptions);
                _parentWindow.ButtonOptions.SetValue(Grid.RowProperty, 4);
                _parentWindow.ButtonOptions.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.ButtonOptions.SetValue(Grid.ColumnSpanProperty,2);

                #endregion

                #region SaveDialog style

                _parentWindow.SaveDialog.Background = styleFactory.GetConteinerBackground();

                _parentWindow.SaveDialog.TitleBar.Background = styleFactory.GetTittleBarBackground();

                _parentWindow.SaveDialog.GridMenu.Children.Remove(_parentWindow.SaveDialog.TextBlockQuestion);
                _parentWindow.SaveDialog.TextBlockQuestion =
                    styleFactory.GetDescriptionTextBlock("Save this game?");
                _parentWindow.SaveDialog.GridMenu.Children.Add(
                    _parentWindow.SaveDialog.TextBlockQuestion);
                _parentWindow.SaveDialog.TextBlockQuestion.SetValue(Grid.RowProperty, 1);
                _parentWindow.SaveDialog.TextBlockQuestion.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.SaveDialog.TextBlockQuestion.SetValue(Grid.ColumnSpanProperty, 5);

                _parentWindow.SaveDialog.ButtonSave = styleFactory.GetMenuButton("Save",
                    _parentWindow.SaveDialog.ViewModel.SaveCommand);
                _parentWindow.SaveDialog.GridMenu.Children.Add(_parentWindow.SaveDialog.ButtonSave);
                _parentWindow.SaveDialog.ButtonSave.SetValue(Grid.RowProperty, 3);
                _parentWindow.SaveDialog.ButtonSave.SetValue(Grid.ColumnProperty, 1);

                _parentWindow.SaveDialog.ButtonExit = styleFactory.GetMenuButton("No, thanks",
                    _parentWindow.SaveDialog.ViewModel.ExitCommand);
                _parentWindow.SaveDialog.GridMenu.Children.Add(_parentWindow.SaveDialog.ButtonExit);
                _parentWindow.SaveDialog.ButtonExit.SetValue(Grid.RowProperty, 3);
                _parentWindow.SaveDialog.ButtonExit.SetValue(Grid.ColumnProperty, 3);

                _parentWindow.SaveDialog.ButtonCancel = styleFactory.GetMenuButton("Cancel",
                    _parentWindow.SaveDialog.ViewModel.CloseCommand);
                _parentWindow.SaveDialog.GridMenu.Children.Add(_parentWindow.SaveDialog.ButtonCancel);
                _parentWindow.SaveDialog.ButtonCancel.SetValue(Grid.RowProperty, 3);
                _parentWindow.SaveDialog.ButtonCancel.SetValue(Grid.ColumnProperty, 5);

                #endregion

                #region EndGameWindow style

                _parentWindow.EndGameWindow.TitleBar.Background = styleFactory.GetTittleBarBackground();

                _parentWindow.EndGameWindow.ButtonOk = styleFactory.GetMenuButton("Ok",
                    _parentWindow.EndGameWindow.ViewModel.CloseCommand);
                _parentWindow.EndGameWindow.GridContainer.Children.Add(_parentWindow.EndGameWindow.ButtonOk);
                _parentWindow.EndGameWindow.ButtonOk.SetValue(Grid.ColumnProperty, 2);
                _parentWindow.EndGameWindow.ButtonOk.SetValue(Grid.RowProperty, 3);

                _parentWindow.EndGameWindow.GridContainer.Children.Remove(
                    _parentWindow.EndGameWindow.TextBlockWinnerCaption);
                BindingOperations.ClearBinding(_parentWindow.EndGameWindow.TextBlockWinnerCaption, TextBlock.TextProperty);
                _parentWindow.EndGameWindow.TextBlockWinnerCaption.ClearValue(TextBlock.TextProperty);
                _parentWindow.EndGameWindow.TextBlockWinnerCaption = styleFactory.GetDescriptionTextBlock("");
                _parentWindow.EndGameWindow.GridContainer.Children.Add(
                    _parentWindow.EndGameWindow.TextBlockWinnerCaption);
                _parentWindow.EndGameWindow.TextBlockWinnerCaption.SetValue(Grid.RowProperty, 1);
                _parentWindow.EndGameWindow.TextBlockWinnerCaption.SetValue(Grid.ColumnProperty, 1);
                _parentWindow.EndGameWindow.TextBlockWinnerCaption.SetValue(Grid.ColumnSpanProperty,3);

                Binding textBlockWinnerCaptioBinding = new Binding("Text") { Mode = BindingMode.OneWay };
                BindingOperations.SetBinding(_parentWindow.EndGameWindow.TextBlockWinnerCaption,
                    TextBlock.TextProperty, textBlockWinnerCaptioBinding);

                #endregion
                this.UpdateLayout();
                _parentWindow.StartMenu.UpdateLayout();
                _parentWindow.UpdateLayout();
                _parentWindow.PlayersInfoMenu.UpdateLayout();
                _parentWindow.StatisticsWindow.UpdateLayout();
                _parentWindow.LoadGameMenu.UpdateLayout();
            }
        }

        private void SliderVolume_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SoundsGenerator.Instance.SetVolume(e.NewValue/100);
        }
    }
}
