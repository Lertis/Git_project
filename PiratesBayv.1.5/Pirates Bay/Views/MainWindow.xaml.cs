using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using Pirates_Bay.CreationalPatterns;
using Pirates_Bay.GameLogic;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public StartMenu StartMenu { get; set; }
        public OptionsMenu OptionsMenu { get; set; }
        public PlayersInfo PlayersInfoMenu { get; set; }
        public LoadGameMenu LoadGameMenu { get; set; }
        public StatisticsWindow StatisticsWindow { get; set; }
        public SaveGameDialodWindow SaveDialog { get; set; }
        public EndGameWindow EndGameWindow { get; set; }
        public ShipYardWindow ShipYardWindow { get; set; }

        public bool NewGameBegining { get; set; }

        public MainWindowViewModel ViewModel { get; set; }

        private GameLogic.GameLogic _game;

        private List<Button> _mapSquearesButtons;

        private readonly Random _random = new Random();

        public System.Windows.Controls.Image FirstPlayerShipImage { get; set; }
        public System.Windows.Controls.Image SecondPlayerShipImage { get; set; }

        private int _mapWidth, _mapHeight;

        private double _mapSquareWidth, _mapSquareHeight;

        public MainWindow()
        {
            _mapWidth = 14;
            _mapHeight = 8;

            InitializeComponent();

            _game = new GameLogic.GameLogic();
            _game.DisplayShip += this.CreateShipImage;
            _game.PlayerActivated += this.OnPlayerActivated;
            _game.ShipMoved += this.OnShipMoved;
            _game.TreasureCollected += this.OnTreasureCollected;
            _game.AttackedEnemy += this.OnAttackedEnemy;
            _game.PlayerWon += this.OnPlayerWon;
            _game.ShowShipYard += (sender, args) => ShipYardWindow.ShowDialog();
            StartMenu = new StartMenu(this);
            StartMenu.Show();

            OptionsMenu = new OptionsMenu(this);
            PlayersInfoMenu = new PlayersInfo(this);
            LoadGameMenu = new LoadGameMenu(this);
            StatisticsWindow = new StatisticsWindow();
            SaveDialog = new SaveGameDialodWindow(this);
            EndGameWindow = new EndGameWindow(this);
            ShipYardWindow = new ShipYardWindow(this);

            ViewModel = new MainWindowViewModel()
            {
                CloseCommand = new Command(() => true, () =>
                {
                    NewGameBegining = false;
                    SaveDialog.ShowDialog();
                }),
                MinimizeCommand = new Command(() => true, () => this.WindowState = WindowState.Minimized),
                ShowOptionsCommand = new Command(() => true, () => OptionsMenu.ShowDialog()),
                StartNewGameCommand = new Command(() => true, () =>
                {
                    NewGameBegining = true;

                    SaveDialog.ShowDialog();
                })
            };

            this.DataContext = ViewModel;

            GridMapContainer.Cursor = new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\CrossedGrinArrow.ani");

            _mapSquearesButtons = new List<Button>();
        }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            StartMenu.Close();
            OptionsMenu.Close();
            StatisticsWindow.Close();
            LoadGameMenu.Close();
            PlayersInfoMenu.Close();
            SaveDialog.Close();
            EndGameWindow.Close();
            ShipYardWindow.Close();
        }

        private void TitleBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public void StartNewGame()
        {
            _game.Initialize(PlayersInfoMenu.ViewModel.FirstPlayerName, PlayersInfoMenu.ViewModel.FirstPlayerShipName,
                PlayersInfoMenu.ViewModel.SecondPlayerName, PlayersInfoMenu.ViewModel.SecondPlayerShipName);

            FillUI();
        }

        public void StartLoadedGame(GameMemento newGame)
        {
            _game.SetGameMemento(newGame);

            FillUI();
        }

        /// <summary>
        /// Draw map, fill players info and start game
        /// </summary>
        private void FillUI()
        {
            ViewModel.FirstPlayer = new PlayerViewModel(_game.Players[0].Ship, _game.Players[0].Name, _game.Players[0].Gold);
            ViewModel.SecondPlayer = new PlayerViewModel(_game.Players[1].Ship, _game.Players[1].Name, _game.Players[1].Gold);

            CanvasMap.Children.Clear();
            _mapSquearesButtons.Clear();

            foreach (var square in _game.Map.Squares)
            {
                CreateMapSquareButton(square);
            }

            _game.Start();

            this.Show();
        }

        /// <summary>
        ///Create button which represents MapSquare and set button backgroun depending on the type of square
        /// </summary>
        /// <param name="source">Represents one square of map, which will be drawed on UI</param>
        private void CreateMapSquareButton(MapSquare source)
        {
            Button newMapSquare = new Button()
            {
                Height = _mapSquareHeight,
                Width = _mapSquareWidth
            };

            newMapSquare.Click += this.MapSquare_Click;
            newMapSquare.SetValue(Canvas.LeftProperty, source.Position.X * _mapSquareWidth);
            newMapSquare.SetValue(Canvas.TopProperty, source.Position.Y * _mapSquareHeight);

            newMapSquare.Style = (Style)newMapSquare.FindResource("MapSquare");

            switch (source.Type)
            {
                case MapSquareType.Treasure:
                    {
                        newMapSquare.Background = new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\Skarb.png", UriKind.Relative)));
                        break;
                    }
                case MapSquareType.Land:
                    {

                        newMapSquare.Background = new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\Island" + _random.Next(1, 7) + ".png", UriKind.Relative)));
                        break;
                    }
                case MapSquareType.ShipYard:
                    {
                        newMapSquare.Background = new ImageBrush(new BitmapImage(new Uri(@"Resources\Background images\ShipYard.png", UriKind.Relative)));
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            _mapSquearesButtons.Add(newMapSquare);
            CanvasMap.Children.Add(newMapSquare);
        }

        /// <summary>
        /// Set specific cursors for each square of map, that shows actions, which ship may does.
        /// </summary>
        /// <param name="position">Ship position.</param>
        /// <param name="moveRadius">How many cells may overcome ship.</param>
        private void UpdateMapCursors(System.Drawing.Point position, int moveRadius)
        {
            var enabledSquares = _game.Map.GetEnabledSquares(position, moveRadius);

            FirstPlayerShipImage.Cursor = new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\CrossedGrinArrow.ani");
            SecondPlayerShipImage.Cursor = new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\CrossedGrinArrow.ani");

            foreach (var mapSquearesButton in _mapSquearesButtons)
            {
                mapSquearesButton.Cursor =
                    new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\CrossedGrinArrow.ani");
            }
            foreach (var mapSquearesButton in _mapSquearesButtons.Where(b => enabledSquares.Any(square => (square.Position.X == (double)b.GetValue(Canvas.LeftProperty) / _mapSquareWidth) && (square.Position.Y == (double)b.GetValue(Canvas.TopProperty) / _mapSquareHeight))))
            {
                mapSquearesButton.Cursor = new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\AnimatedGrinArrow.ani");
            }

            if (enabledSquares.Any(s => s.Type == MapSquareType.ShipYard))
            {
                foreach (var enabledSquare in enabledSquares.Where(s => s.Type == MapSquareType.ShipYard).ToList())
                {
                    _mapSquearesButtons.First(
                        b =>
                            ((double)b.GetValue(Canvas.LeftProperty) == (enabledSquare.Position.X * _mapSquareWidth)) &&
                            ((double)b.GetValue(Canvas.TopProperty) == (enabledSquare.Position.Y * _mapSquareHeight))).Cursor =
                        new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\GreenCross.ani");
                }
            }


            var enemy = _game.Players.Find(p => p.Ship.Position != position).Ship;

            if (enabledSquares.Any(s => s.Position == enemy.Position))
            {
                if (_game.ActivePlayer == 0)
                {
                    SecondPlayerShipImage.Cursor = new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\PiratesKnife.cur");
                }
                else
                {
                    FirstPlayerShipImage.Cursor = new Cursor(System.AppDomain.CurrentDomain.BaseDirectory + @"\Cursors\PiratesKnife.cur");
                }
            }


            CanvasMap.UpdateLayout();
        }

        private void CreateShipImage(Ship sender)
        {
            if (sender.Position == _game.Players[0].Ship.Position)
            {
                FirstPlayerShipImage = new System.Windows.Controls.Image()
                {
                    Source = sender.ModelImage,
                    Width = _mapSquareWidth,
                    Height = _mapSquareHeight
                };
                FirstPlayerShipImage.MouseLeftButtonDown += this.MapSquare_Click;

                FirstPlayerShipImage.SetValue(Canvas.LeftProperty, sender.Position.X * _mapSquareWidth);
                FirstPlayerShipImage.SetValue(Canvas.TopProperty, sender.Position.Y * _mapSquareHeight);


                CanvasMap.Children.Add(FirstPlayerShipImage);
            }
            else
            {
                SecondPlayerShipImage = new System.Windows.Controls.Image()
                {
                    Source = sender.ModelImage,
                    Width = _mapSquareWidth,
                    Height = _mapSquareHeight
                };
                SecondPlayerShipImage.MouseLeftButtonDown += this.MapSquare_Click;

                SecondPlayerShipImage.SetValue(Canvas.LeftProperty, sender.Position.X * _mapSquareWidth);
                SecondPlayerShipImage.SetValue(Canvas.TopProperty, sender.Position.Y * _mapSquareHeight);

                CanvasMap.Children.Add(SecondPlayerShipImage);
            }

            CanvasMap.UpdateLayout();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _mapSquareHeight = CanvasMap.ActualHeight / _mapHeight;
            _mapSquareWidth = CanvasMap.ActualWidth / _mapWidth;

            Hide();
        }

        private void OnAttackedEnemy(Ship sender)
        {
            System.Windows.Controls.Image smoke = new System.Windows.Controls.Image();

            smoke.Source = new BitmapImage(new Uri(System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Background images\DarkSmoke.png"));

            System.Windows.Controls.Image shipImage;

            if (_game.ActivePlayer == 0)
            {
                shipImage = FirstPlayerShipImage;
            }
            else
            {
                shipImage = SecondPlayerShipImage;
            }

            smoke.Width = shipImage.Width;
            smoke.Height = 25;
            smoke.Stretch = Stretch.Fill;

            CanvasMap.Children.Add(smoke);

            smoke.SetValue(Canvas.TopProperty, (double)shipImage.GetValue(Canvas.TopProperty) + shipImage.Height - 25);
            smoke.SetValue(Canvas.LeftProperty, shipImage.GetValue(Canvas.LeftProperty));

            CanvasMap.UpdateLayout();

            Storyboard story = new Storyboard();
            DoubleAnimation dbCanvasY = new DoubleAnimation();
            dbCanvasY.From = (double)smoke.GetValue(Canvas.TopProperty);
            dbCanvasY.To = (double)shipImage.GetValue(Canvas.TopProperty) - 10;
            dbCanvasY.Duration = new Duration(TimeSpan.FromSeconds(1.5));
            dbCanvasY.AccelerationRatio = 1;

            story.Children.Add(dbCanvasY);
            Storyboard.SetTarget(dbCanvasY, smoke);
            Storyboard.SetTargetProperty(dbCanvasY, new PropertyPath(Canvas.TopProperty));


            SoundsGenerator.Instance.PlayCanonShot();
            story.Completed += new EventHandler(delegate
            {
                CanvasMap.Children.Remove(smoke);
                CanvasMap.UpdateLayout();
            });

            story.Begin();
        }

        public GameMemento GenerateGameMemento()
        {
            return _game.CreateGameMemento();
        }

        private void OnPlayerActivated(Player sender)
        {
            UpdateMapCursors(sender.Ship.Position, _game.MovementsLeft);

            //DoubleAnimation widthAnimation = new DoubleAnimation(_firstPlayerShipImage.Width, _firstPlayerShipImage.Width + 10, TimeSpan.FromSeconds(0.3));
            //widthAnimation.AutoReverse = true;
            //DoubleAnimation heightAnimation = new DoubleAnimation(_firstPlayerShipImage.Height, _firstPlayerShipImage.Height + 8, TimeSpan.FromSeconds(0.3));
            //heightAnimation.AutoReverse = true;

            //DoubleAnimation topAnimation = new DoubleAnimation();
            //topAnimation.AutoReverse = true;
            //topAnimation.Duration = TimeSpan.FromSeconds(0.3);

            //DoubleAnimation leftAnimation = new DoubleAnimation();
            //leftAnimation.AutoReverse = true;
            //leftAnimation.Duration = TimeSpan.FromSeconds(0.3);

            if (sender.Ship.Position == ViewModel.FirstPlayer.Ship.Position)
            {
                ImageFirstUserActive.Visibility = Visibility.Visible;
                ImageSecondUserActive.Visibility = Visibility.Hidden;

                //Storyboard.SetTarget(widthAnimation, _firstPlayerShipImage);
                //Storyboard.SetTargetProperty(widthAnimation, new PropertyPath(System.Windows.Controls.Image.WidthProperty));

                //Storyboard.SetTarget(heightAnimation, _firstPlayerShipImage);
                //Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(System.Windows.Controls.Image.HeightProperty));

                //topAnimation.From = (double)_firstPlayerShipImage.GetValue(Canvas.TopProperty);
                //topAnimation.To = (double)_firstPlayerShipImage.GetValue(Canvas.TopProperty) - 5;

                //leftAnimation.From = (double)_firstPlayerShipImage.GetValue(Canvas.LeftProperty);
                //leftAnimation.To = (double)_firstPlayerShipImage.GetValue(Canvas.LeftProperty) - 4;

                //Storyboard.SetTarget(topAnimation, _firstPlayerShipImage);
                //Storyboard.SetTargetProperty(topAnimation, new PropertyPath(Canvas.TopProperty));

                //Storyboard.SetTarget(leftAnimation, _firstPlayerShipImage);
                //Storyboard.SetTargetProperty(leftAnimation, new PropertyPath(Canvas.LeftProperty));
            }
            else
            {
                ImageFirstUserActive.Visibility = Visibility.Hidden;
                ImageSecondUserActive.Visibility = Visibility.Visible;

                //Storyboard.SetTarget(widthAnimation, _secondPlayerShipImage);
                //Storyboard.SetTargetProperty(widthAnimation, new PropertyPath(System.Windows.Controls.Image.WidthProperty));

                //Storyboard.SetTarget(heightAnimation, _secondPlayerShipImage);
                //Storyboard.SetTargetProperty(heightAnimation, new PropertyPath(System.Windows.Controls.Image.HeightProperty));

                //topAnimation.From = (double)_secondPlayerShipImage.GetValue(Canvas.TopProperty);
                //topAnimation.To = (double)_secondPlayerShipImage.GetValue(Canvas.TopProperty) - 5;

                //leftAnimation.From = (double)_secondPlayerShipImage.GetValue(Canvas.LeftProperty);
                //leftAnimation.To = (double)_secondPlayerShipImage.GetValue(Canvas.LeftProperty) - 4;

                //Storyboard.SetTarget(topAnimation, _secondPlayerShipImage);
                //Storyboard.SetTargetProperty(topAnimation, new PropertyPath(Canvas.TopProperty));

                //Storyboard.SetTarget(leftAnimation, _secondPlayerShipImage);
                //Storyboard.SetTargetProperty(leftAnimation, new PropertyPath(Canvas.LeftProperty));
            }

            //Storyboard storyboard = new Storyboard();

            //storyboard.Children.Add(widthAnimation);
            //storyboard.Children.Add(heightAnimation);
            //storyboard.Children.Add(topAnimation);
            //storyboard.Children.Add(leftAnimation);

            //storyboard.Begin();
        }

        private void MapSquare_Click(object sender, EventArgs e)
        {
            System.Drawing.Point position;
            if (sender.GetType() == typeof(Button))
                position =  new System.Drawing.Point(
                    (int)(((double)((Button)sender).GetValue(Canvas.LeftProperty)) / _mapSquareWidth),
                    (int)(((double)((Button)sender).GetValue(Canvas.TopProperty)) / _mapSquareHeight));

            else
                position = new System.Drawing.Point(
                    (int)(((double)((System.Windows.Controls.Image)sender).GetValue(Canvas.LeftProperty)) / _mapSquareWidth),
                    (int)(((double)((System.Windows.Controls.Image)sender).GetValue(Canvas.TopProperty)) / _mapSquareHeight));

            if (
                _game.Map.GetEnabledSquares(_game.Players[_game.ActivePlayer].Ship.Position, _game.MovementsLeft)
                    .Any(s => s.Position == position))
            {
                _game.RecognizeUserAction(position);
            }
        }

        private void OnShipMoved(Ship ship, List<System.Drawing.Point> route)
        {
            var verticalAnimations = new DoubleAnimation[route.Count - 1];
            var horizontalAnimations = new DoubleAnimation[route.Count - 1];

            System.Windows.Controls.Image imageToMove;
            System.Windows.Controls.Image enemyImage;

            if (ship.Position == ViewModel.FirstPlayer.Ship.Position)
            {
                imageToMove = FirstPlayerShipImage;
            }
            else
            {
                imageToMove = SecondPlayerShipImage;
            }

            verticalAnimations[0] = new DoubleAnimation(route[0].Y * _mapSquareHeight, route[1].Y * _mapSquareHeight, TimeSpan.FromSeconds(1));

            horizontalAnimations[0] = new DoubleAnimation(route[0].X * _mapSquareWidth, route[1].X * _mapSquareWidth, TimeSpan.FromSeconds(1));

            Storyboard.SetTarget(verticalAnimations[0], imageToMove);
            Storyboard.SetTargetProperty(verticalAnimations[0], new PropertyPath(Canvas.TopProperty));

            Storyboard.SetTarget(horizontalAnimations[0], imageToMove);
            Storyboard.SetTargetProperty(horizontalAnimations[0], new PropertyPath(Canvas.LeftProperty));

            for (int i = 1; i < route.Count - 1; i++)
            {
                verticalAnimations[i] = new DoubleAnimation(verticalAnimations[i - 1].To.Value, route[i + 1].Y * _mapSquareHeight, TimeSpan.FromSeconds(1));

                horizontalAnimations[i] = new DoubleAnimation(horizontalAnimations[i - 1].To.Value, route[i + 1].X * _mapSquareWidth, TimeSpan.FromSeconds(1));

                Storyboard.SetTarget(verticalAnimations[i], imageToMove);
                Storyboard.SetTargetProperty(verticalAnimations[i], new PropertyPath(Canvas.TopProperty));

                Storyboard.SetTarget(horizontalAnimations[i], imageToMove);
                Storyboard.SetTargetProperty(horizontalAnimations[i], new PropertyPath(Canvas.LeftProperty));
            }

            var storyboards = new Storyboard[route.Count - 1];

            for (int i = 0; i < route.Count - 1; i++)
            {
                storyboards[i] = new Storyboard();

                storyboards[i].Children.Add(verticalAnimations[i]);
                storyboards[i].Children.Add(horizontalAnimations[i]);

                if (i != route.Count - 2)
                    storyboards[i].Completed += (sender, args) => { storyboards[i + 1].Begin(); };
            }

            SoundsGenerator.Instance.PlayWavesSound();
            storyboards[0].Begin();

            UpdateMapCursors(ship.Position, _game.MovementsLeft);
        }

        private void OnTreasureCollected(Player sender, System.Drawing.Point treasurePosition)
        {
            SoundsGenerator.Instance.PlayCoinsDrop();

            if (_game.ActivePlayer == 0)
                ViewModel.FirstPlayer.Gold = sender.Gold;
            else
                ViewModel.SecondPlayer.Gold = sender.Gold;

            _mapSquearesButtons.Find(
                b =>
                    ((((double)b.GetValue(Canvas.LeftProperty)) / _mapSquareWidth) == treasurePosition.X) &&
                    ((((double)b.GetValue(Canvas.TopProperty)) / _mapSquareHeight) == treasurePosition.Y)).Background = new SolidColorBrush(Colors.Transparent);
        }

        private void OnPlayerWon(Player sender)
        {
            EndGameWindow.ViewModel.Text = sender.Name + " win!";

            SoundsGenerator.Instance.PlayVictorySound();

            EndGameWindow.ShowDialog();
        }

        private void ImageFirstUserActive_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _game.ActivatePlayer(_game.Players[1]);
        }

        private void ImageSecondUserActive_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _game.ActivatePlayer(_game.Players[0]);
        }

        public GameLogic.GameLogic GetGameObject()
        {
            return _game;
        }
    }
}
