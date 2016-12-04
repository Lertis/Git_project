using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pirates_Bay.GameLogic;

namespace Pirates_Bay.ViewModels
{
    class ShipyardWindowViewModel: ViewModelBase
    {
        private String _armorUpgradeAmount, _sailsUpgradeAmount, _cannonsUpgradeAmount;

        private String _armorUpgradeCost, _sailsUpgradeCost, _cannonsUpgradeCost;

        private int _playerShipPrice;

        private int _playerGold;

        private Ship _queenAnnesRevenge, _oldPearl, _pirateBrig, _theRanger, _theBenjamin, _theRoyalFortune, _blackPearl;

        public String ArmorUpgradeAmount
        {
            get { return _armorUpgradeAmount; }
            set
            {
                _armorUpgradeAmount = value;
                OnPropertyChanged("ArmorUpgradeAmount");
            }
        }

        public String SailsUpgradeAmount
        {
            get { return _sailsUpgradeAmount; }
            set
            {
                _sailsUpgradeAmount = value;
                OnPropertyChanged("SailsUpgradeAmount");
            }
        }

        public String CannonsUpgradeAmount
        {
            get { return _cannonsUpgradeAmount; }
            set
            {
                _cannonsUpgradeAmount = value;
                OnPropertyChanged("CannonsUpgradeAmount");
            }
        }

        public String ArmorUpgradeCost
        {
            get { return _armorUpgradeCost; }
            set
            {
                _armorUpgradeCost = value;
                OnPropertyChanged("ArmorUpgradeCost");
            }
        }

        public String SailsUpgradeCost
        {
            get { return _sailsUpgradeCost; }
            set
            {
                _sailsUpgradeCost = value;
                OnPropertyChanged("SailsUpgradeCost");
            }
        }

        public String CannonsUpgradeCost
        {
            get { return _cannonsUpgradeCost; }
            set
            {
                _cannonsUpgradeCost = value;
                OnPropertyChanged("CannonsUpgradeCost");
            }
        }

        public int PlayerShipPrice
        {
            get { return _playerShipPrice; }
            set
            {
                _playerShipPrice = value;
                OnPropertyChanged("PlayerShipPrice");
            }
        }

        public int PlayerGold
        {
            get { return _playerGold; }
            set
            {
                _playerGold = value;
                OnPropertyChanged("PlayerGold");
            }
        }

        public Ship QueenAnnesRevenge
        {
            get { return _queenAnnesRevenge; }
            set
            {
                _queenAnnesRevenge = value;
                OnPropertyChanged("QueenAnnesRevenge");
            }
        }

        public Ship OldPearl
        {
            get { return _oldPearl; }
            set
            {
                _oldPearl = value;
                OnPropertyChanged("OldPearl");
            }
        }

        public Ship PirateBrig
        {
            get { return _pirateBrig; }
            set
            {
                _pirateBrig = value;
                OnPropertyChanged("PirateBrig");
            }
        }

        public Ship TheRanger
        {
            get { return _theRanger; }
            set
            {
                _theRanger = value;
                OnPropertyChanged("TheRanger");
            }
        }

        public Ship TheBenjamin
        {
            get { return _theBenjamin; }
            set
            {
                _theBenjamin = value;
                OnPropertyChanged("TheBenjamin");
            }
        }

        public Ship TheRoyalFortune
        {
            get { return _theRoyalFortune; }
            set
            {
                _theRoyalFortune = value;
                OnPropertyChanged("TheRoyalFortune");
            }
        }

        public Ship BlackPearl
        {
            get { return _blackPearl; }
            set
            {
                _blackPearl = value;
                OnPropertyChanged("BlackPearl");
            }
        }
    }
}
