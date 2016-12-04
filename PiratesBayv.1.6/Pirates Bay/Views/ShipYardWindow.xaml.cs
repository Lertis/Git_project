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
using Pirates_Bay.GameLogic;
using Pirates_Bay.ViewModels;

namespace Pirates_Bay.Views
{
    /// <summary>
    /// Interaction logic for ShipYardWindow.xaml
    /// </summary>
    public partial class ShipYardWindow : Window
    {
        private GameLogic.GameLogic _game;

        private MainWindow _mainWindow;
        private ShipyardWindowViewModel _viewModel;

        private ShipYard _standartShipYard, _playerShipsBuilder;

        private bool _needShip;

        public ShipYardWindow(MainWindow parentWindow)
        {
            this._game = parentWindow.GetGameObject();

            this._mainWindow = parentWindow;
            _needShip = false;

            _standartShipYard = new ShipYard();

            _viewModel = new ShipyardWindowViewModel();

            InitializeComponent();

            this.DataContext = _viewModel;
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!_needShip)
            {
                this.Hide();
                _game.UpgradingShip = false;
                _game.RecognizeUserAction(_game.Players[_game.ActivePlayer].Ship.Position);
            }
        }

        private void ShipYardWindow_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible)
            {
                _viewModel.PlayerGold = _game.Players[_game.ActivePlayer].Gold;

                _playerShipsBuilder = _game.PlayersShipsBuilders[_game.ActivePlayer];

                Update();
            }
        }

        private void Update()
        {
            _viewModel.QueenAnnesRevenge = _playerShipsBuilder.BuildShip("Queen Anne`s Revenge");
            _viewModel.OldPearl = _playerShipsBuilder.BuildShip("Old Pearl");
            _viewModel.PirateBrig = _playerShipsBuilder.BuildShip("Pirate Brig");
            _viewModel.TheRanger = _playerShipsBuilder.BuildShip("The Ranger");
            _viewModel.TheBenjamin = _playerShipsBuilder.BuildShip("The Benjamin");
            _viewModel.TheRoyalFortune = _playerShipsBuilder.BuildShip("The Royal Fortune");
            _viewModel.BlackPearl = _playerShipsBuilder.BuildShip("Black Pearl");

            _viewModel.PlayerShipPrice = _game.Players[_game.ActivePlayer].Ship.CalculateCost();

            ButtonSale.IsEnabled = ((_game.Players[_game.ActivePlayer].Gold + _game.Players[_game.ActivePlayer].Ship.CalculateCost()) >=
                20000) && !_needShip;

            int armorUpgradeAmount, cannonsUpgradeAmount, sailsUpgradeAmount;

            if (_standartShipYard.Ships[0].Health == _playerShipsBuilder.Ships[0].Health)
            {
                armorUpgradeAmount = 500;
            }
            else
            {
                armorUpgradeAmount = (int)((_playerShipsBuilder.Ships[0].Health - _standartShipYard.Ships[0].Health) * 1.6);
            }

            _viewModel.ArmorUpgradeAmount = armorUpgradeAmount.ToString();
            _viewModel.ArmorUpgradeCost = (armorUpgradeAmount * 5).ToString();

            if (_standartShipYard.Ships[0].Speed == _playerShipsBuilder.Ships[0].Speed)
            {
                sailsUpgradeAmount = 25;
            }
            else
            {
                sailsUpgradeAmount = (int)((_playerShipsBuilder.Ships[0].Speed - _standartShipYard.Ships[0].Speed) * 1.6);
            }

            _viewModel.SailsUpgradeAmount = sailsUpgradeAmount.ToString();
            _viewModel.SailsUpgradeCost = (sailsUpgradeAmount * 100).ToString();

            if (_standartShipYard.Ships[0].Damage == _playerShipsBuilder.Ships[0].Damage)
            {
                cannonsUpgradeAmount = 40;
            }
            else
            {
                cannonsUpgradeAmount = (int)((_playerShipsBuilder.Ships[0].Damage - _standartShipYard.Ships[0].Damage) * 1.6);
            }

            _viewModel.CannonsUpgradeAmount = cannonsUpgradeAmount.ToString();
            _viewModel.CannonsUpgradeCost = (cannonsUpgradeAmount * 60).ToString();

            TabItemShips.IsEnabled = (_game.Players[_game.ActivePlayer].Gold +
                                      _game.Players[_game.ActivePlayer].Ship.CalculateCost()) >=
                                     20000;

            ButtonArmorShip.IsEnabled = (int.Parse(_viewModel.ArmorUpgradeCost) <= _viewModel.PlayerGold) && !_needShip;
            ButtonAddCannons.IsEnabled = (int.Parse(_viewModel.CannonsUpgradeCost) <= _viewModel.PlayerGold) && !_needShip;
            ButtonImproveSails.IsEnabled = (int.Parse(_viewModel.SailsUpgradeCost) <= _viewModel.PlayerGold) && !_needShip;

            ButtonBuyQARShip.IsEnabled = int.Parse(ButtonBuyQARShip.Content.ToString()) <= _viewModel.PlayerGold;
            ButtonBuyOPShip.IsEnabled = int.Parse(ButtonBuyOPShip.Content.ToString()) <= _viewModel.PlayerGold;
            ButtonBuyPBShip.IsEnabled = int.Parse(ButtonBuyPBShip.Content.ToString()) <= _viewModel.PlayerGold;
            ButtonBuyTRShip.IsEnabled = int.Parse(ButtonBuyTRShip.Content.ToString()) <= _viewModel.PlayerGold;
            ButtonBuyTBShip.IsEnabled = int.Parse(ButtonBuyTBShip.Content.ToString()) <= _viewModel.PlayerGold;
            ButtonBuyTRFShip.IsEnabled = int.Parse(ButtonBuyTRFShip.Content.ToString()) <= _viewModel.PlayerGold;
            ButtonBuyBPShip.IsEnabled = int.Parse(ButtonBuyBPShip.Content.ToString()) <= _viewModel.PlayerGold;
        }

        private void ButtonSale_OnClick(object sender, RoutedEventArgs e)
        {
            _needShip = true;

            _viewModel.PlayerGold += _viewModel.PlayerShipPrice;

            Update();

            _mainWindow.UpdateLayout();
        }

        private void ButtonBuyBPShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("Black Pearl", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ButtonBuyTRFShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("The Royal Fortune", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ButtonBuyTBShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("The Benjamin", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ButtonBuyTRShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("The Ranger", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ButtonBuyPBShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("Pirate Brig", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ButtonBuyOPShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("Qld Pearl", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ButtonBuyQARShip_OnClick(object sender, RoutedEventArgs e)
        {
            ExchcangeShip("Queen Anne`s Revenge", int.Parse(((Button)sender).Content.ToString()));
        }

        private void ExchcangeShip(String newShipName, int newShipCost)
        {
            SoundsGenerator.Instance.PlayCoinsDrop();

            _needShip = false;

            _viewModel.PlayerGold -= newShipCost;

            var shipPosition = _game.Players[_game.ActivePlayer].Ship.Position;

            _game.Players[_game.ActivePlayer].Ship = _playerShipsBuilder.BuildShip(newShipName);
            _game.Players[_game.ActivePlayer].Ship.Position = shipPosition;

            if (_game.ActivePlayer == 0)
            {
                _mainWindow.ViewModel.FirstPlayer.Ship = _game.Players[_game.ActivePlayer].Ship;
                _mainWindow.FirstPlayerShipImage.Source = _game.Players[_game.ActivePlayer].Ship.ModelImage;
            }
            else
            {
                _mainWindow.ViewModel.SecondPlayer.Ship = _game.Players[_game.ActivePlayer].Ship;
                _mainWindow.SecondPlayerShipImage.Source = _game.Players[_game.ActivePlayer].Ship.ModelImage;
            }

            Update();
        }

        private void ButtonArmorShip_OnClick(object sender, RoutedEventArgs e)
        {
            SoundsGenerator.Instance.PlayCoinsDrop();

            _game.PlayersShipsBuilders[_game.ActivePlayer].UpgradeHull(int.Parse(_viewModel.ArmorUpgradeAmount));

            _game.Players[_game.ActivePlayer].Ship.UpgradeHull(int.Parse(_viewModel.ArmorUpgradeAmount));

            _viewModel.PlayerGold -= int.Parse(_viewModel.ArmorUpgradeCost);
            _game.Players[_game.ActivePlayer].Gold -= int.Parse(_viewModel.ArmorUpgradeCost);

            if (_game.ActivePlayer == 0)
            {
                _mainWindow.ViewModel.FirstPlayer.Gold -= int.Parse(_viewModel.ArmorUpgradeCost);
            }
            else
            {
                _mainWindow.ViewModel.SecondPlayer.Gold -= int.Parse(_viewModel.ArmorUpgradeCost);
            }

            Update();
        }

        private void ButtonImproveSails_OnClick(object sender, RoutedEventArgs e)
        {
            SoundsGenerator.Instance.PlayCoinsDrop();

            _game.PlayersShipsBuilders[_game.ActivePlayer].UpgradeSails(int.Parse(_viewModel.SailsUpgradeAmount));

            _game.Players[_game.ActivePlayer].Ship.UpgradeSails(int.Parse(_viewModel.SailsUpgradeAmount));

            _viewModel.PlayerGold -= int.Parse(_viewModel.SailsUpgradeCost);
            _game.Players[_game.ActivePlayer].Gold -= int.Parse(_viewModel.SailsUpgradeCost);

            if (_game.ActivePlayer == 0)
            {
                _mainWindow.ViewModel.FirstPlayer.Gold -= int.Parse(_viewModel.SailsUpgradeCost);
            }
            else
            {
                _mainWindow.ViewModel.SecondPlayer.Gold -= int.Parse(_viewModel.SailsUpgradeCost);
            }

            Update();
        }

        private void ButtonAddCannons_OnClick(object sender, RoutedEventArgs e)
        {
            SoundsGenerator.Instance.PlayCoinsDrop();

            _game.PlayersShipsBuilders[_game.ActivePlayer].UpgrageCannon(int.Parse(_viewModel.CannonsUpgradeAmount));

            _game.Players[_game.ActivePlayer].Ship.UpgradeCannon(int.Parse(_viewModel.CannonsUpgradeAmount));

            _viewModel.PlayerGold -= int.Parse(_viewModel.CannonsUpgradeCost);
            _game.Players[_game.ActivePlayer].Gold -= int.Parse(_viewModel.CannonsUpgradeCost);

            if (_game.ActivePlayer == 0)
            {
                _mainWindow.ViewModel.FirstPlayer.Gold -= int.Parse(_viewModel.CannonsUpgradeCost);
            }
            else
            {
                _mainWindow.ViewModel.SecondPlayer.Gold -= int.Parse(_viewModel.CannonsUpgradeCost);
            }

            Update();
        }
    }
}
